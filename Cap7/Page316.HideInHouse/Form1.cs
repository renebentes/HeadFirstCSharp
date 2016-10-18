using System;
using System.Threading;
using System.Windows.Forms;

namespace Page316.HideInHouse
{
    public partial class Form1 : Form
    {
        private int moves;
        private Location currentLocation;

        private RoomWithDoor livingRoom;
        private RoomWithHidingPlace diningRoom;
        private RoomWithDoor kitchen;
        private Room stairs;
        private RoomWithHidingPlace hallway;
        private RoomWithHidingPlace bathroom;
        private RoomWithHidingPlace masterBedroom;
        private RoomWithHidingPlace secondBedroom;

        private OutsideWithDoor frontYard;
        private OutsideWithDoor backYard;
        private OutsideWithHidingPlace garden;
        private OutsideWithHidingPlace driveway;

        private readonly Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + moves + " moves!");
                var foundLocation = currentLocation as IHidingPlace;
                description.Text = "You found your opponent in " + moves + " moves! He was hiding " + foundLocation.HidingPlaceName + ".";
            }
            moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "inside the closet", "an oak door with a brass knob");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier", "in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "in the cabinet", "a screen door");
            stairs = new Room("Stairs", " a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a larger bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");

            frontYard = new OutsideWithDoor("Front Yard", false, "a heavy-looking oak door");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");

            diningRoom.Exists = new Location[] { livingRoom, kitchen };
            livingRoom.Exists = new Location[] { diningRoom, stairs };
            kitchen.Exists = new Location[] { diningRoom };
            stairs.Exists = new Location[] { livingRoom, hallway };
            hallway.Exists = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exists = new Location[] { hallway };
            masterBedroom.Exists = new Location[] { hallway };
            secondBedroom.Exists = new Location[] { hallway };
            frontYard.Exists = new Location[] { backYard, garden, driveway };
            backYard.Exists = new Location[] { frontYard, garden, driveway };
            garden.Exists = new Location[] { backYard, frontYard };
            driveway.Exists = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exists.Length; i++)
                exits.Items.Add(currentLocation.Exists[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(move #" + moves + ")";

            if (currentLocation is IHidingPlace)
            {
                var hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Check " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void goHere_Click(object sender, System.EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exists[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, System.EventArgs e)
        {
            var hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                description.Text = i + "... ";
                Application.DoEvents();
                Thread.Sleep(200);
            }

            description.Text = "Ready or not, here I come!";
            Application.DoEvents();
            Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}