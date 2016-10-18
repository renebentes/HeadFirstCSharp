using System.Windows.Forms;

namespace Page316.HideInHouse
{
    public partial class Form1 : Form
    {
        private Location currentLocation;

        private RoomWithDoor livingRoom;
        private Room diningRoom;
        private RoomWithDoor kitchen;

        private OutsideWithDoor frontYard;
        private OutsideWithDoor backYard;
        private Outside garden;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);

            diningRoom.Exists = new Location[] { livingRoom, kitchen };
            livingRoom.Exists = new Location[] { diningRoom };
            kitchen.Exists = new Location[] { diningRoom };

            frontYard.Exists = new Location[] { backYard, garden };
            backYard.Exists = new Location[] { frontYard, garden };
            garden.Exists = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            exits.Items.Clear();
            foreach (var location in currentLocation.Exists)
                exits.Items.Add(location.Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description;

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
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}