using System.Security.Cryptography;
//NOT FINISHED,I DO THIS IN MY FREE TIME WHEN AM FINISHED WITH OTHER TASKS
namespace slots
{//aim of the game is to get a pair or 3 in a row and you would earn a profit
    //HOWEVER, if you roll a rotten tomato in any of the slot,you get nothing,regardless if you got a pair
    //the fruits didn't take long to make (and I acidently found a way to make a pressing animation)
    //missing alot of feature (which is the coins,start button, counter to only press the slow button once because I wasted most of my time on a randomised belt that is so bad c# can't even load it)
    //
    public partial class Form1 : Form
    {
        //when comparing the items,we will use the item/image id, this is because it is easier to convert the id into image by using the id as an indext,meaning we don't need to use a loop to search the matching id to the image
        //
        Image apple = slots.Resource1.download;//image/item      id=0
        Image banana = slots.Resource1.banana;// image/item      id=1
        Image oranges = slots.Resource1.oranges;// image/item    id = 2
        Image rottenTomatos = slots.Resource1.rottentomatos;//image/item id=3
        Image cherry = slots.Resource1.cherry;//image/item              id=4

        //stop button
        Image buttonCooldown = slots.Resource1.red_button;
        Image buttonReady = slots.Resource1.green_button;

        Image slowbuttonready = slots.Resource1.slowdownReady;
        Image slowdowncooldown = slots.Resource1.slowdownCooldown__1_;


        int[] belt = {0,1,3,2,3,4};
        int currentslot = 0;

        private void BeltCeration()
        {


            //TURNS OUT RANDOMISUNG AN ARRAY IS HARD,TOO LONG AND WON'T LOAD THE FORM
            Random RNG = new Random();

            int[] ids = { 0, 1, 2, 4 };//id of fruit not included 3(rotten tomatos)
            int[,] placement = { { 0, -1 }, { 1, -1 }, { 2, -1 }, { 3, -1 }, { 4, -1 }, { 5, -1 } };//placement for the belt {placement,id of fruit -1=none
            int rottenTomatos = 2;//how many rotten tomatos in the belt
            do//places the 2 rotten tomatos
            {
                int number = RNG.Next(0, 6);//genertate the number 0 to 5, the placement number in 2d aray placement
                if (placement[number, 1] == -1)//if the spot empty,add the id 3 to [number][1],remove 1 rotten tomato
                {
                    placement[number, 1] = 3;
                    rottenTomatos--;
                }

            }
            while (rottenTomatos > 0);//stops when all rotten tomatos have been added

            int[] fruit_order = new int[4];
            int counter = 0;//goes up after every sucessful suffle 
            int[] placed = new int[4];
            do//suffelse the order of the placing of the fruits
            {
                int number = RNG.Next(0, 5);
                if (!(placed.Contains(number)) && !(number == 3))//if we already suffeled that number or it was a 3(we already placed the rotten tomatos)
                {
                    placed[counter] = number;
                    counter++;
                }
            }
            while (counter > 4);//stops after all numbers been placed

            
            for (int i = 0; i < 4; i++)
            {
                counter = 0;//reset to 0
                bool itemplaced = false;
                while(!(itemplaced))
                {
                    if (placement[counter, 1] == -1)//bubble shorts for the first empty spot
                    {
                        placement[counter, 1] = placed[counter];
                        itemplaced = true;
                        counter++;
                    }

                }
                

            }
            for (int i = 0;i < 6;i++)//converts the placement array into the belt, without the placement number
            {
                belt[i] = placement[i, 1];
            }
            


        }
        public struct buttons
        {
            //each button will have 

            //if it is in cooldown or not
            //their image showing they are ready to be pressed or not
            //NOTE:their pictureboxes are already set,no need to add them to the record

            public bool cooldown;
            public Image ready;
            public Image Notready;
            public PictureBox buttonPixtureBox;


        }

        public struct TheSlots
        {
            //each slots should have a

            //picturebox
            //item id
            //item potion in belt
            //if it is spinning or not

            public PictureBox SlotBox;
            public int ItemID;
            public int potion;
            public bool IsSpin;

        }
        TheSlots[] SLOTS = new TheSlots[3];//cerates the slots
        buttons[] BUTTONS = new buttons[2];//cerates buttons

        public Form1()
        {

            InitializeComponent();
        }

        private void setup()
        {//sets the slots picture boxes and sets the image and item to the starting potion of the belt
            PictureBox[] boxes = { slot1, slot2, slot3 };
            for (int i = 0; i < boxes.Length; i++)
            {
                SLOTS[i].SlotBox = boxes[i];
                SLOTS[i].IsSpin = true;
                SLOTS[i].potion = 0;
                IdAndImageSetting(belt[0], i);

            }
            BUTTONS[0].ready = buttonReady;
            BUTTONS[1].ready = slowbuttonready;

            BUTTONS[0].Notready = buttonCooldown;
            BUTTONS[1].Notready = slowdowncooldown;

            BUTTONS[0].buttonPixtureBox = button;
            BUTTONS[1].buttonPixtureBox = Theslowbutton;

            BUTTONS[0].buttonPixtureBox.Image = BUTTONS[0].Notready;
            BUTTONS[1].buttonPixtureBox.Image = BUTTONS[1].Notready;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BeltCeration(); because of how bad my belt randomising was,the form won't load and so I 
            setup();//sets the slots
            ButtonInCoolDown(0);
            ButtonInCoolDown(1);

        }

        private void IdAndImageSetting(int id, int indext)//this will update the slots record
        {
            Image[] itemasimage = { apple, banana, oranges, rottenTomatos, cherry };//use to convert id into image

            SLOTS[indext].ItemID = id;//stores the id of the item
            SLOTS[indext].SlotBox.Image = itemasimage[id];//sets the image into the id item
        }


        private void NextItem(object sender, EventArgs e)//the next item in the belt is set into the slots
        {
            for (int i = 0; i < 3; i++)
            {
                if (SLOTS[i].IsSpin)
                {
                    if (SLOTS[i].potion == belt.Length-1)//if the slots is in the end of the belt
                    {
                        SLOTS[i].potion = 0;
                        IdAndImageSetting(belt[SLOTS[i].potion], i);//loops back to the start of the belt
                    }
                    else
                    {
                        SLOTS[i].potion++;
                        IdAndImageSetting(belt[SLOTS[i].potion], i);//else the next item is assine to the slot
                    }
                }



            }

        }


        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(BUTTONS[0].cooldown))//if the button is not in cooldown,play the action
            {
                button_action();
            }

        }

        private void button_action()
        {
            SLOTS[currentslot].IsSpin = false;//the current slot stops spinning and we focus on the next slot,put the button on cooldown
            currentslot++;
            ButtonInCoolDown(0);




        }
        private void ButtonInCoolDown(int indext)//sets the cooldown
        {
            BUTTONS[indext].cooldown = true;
            BUTTONS[indext].buttonPixtureBox.Image = BUTTONS[indext].Notready;
            if (indext == 0)
            {
                ButtonCoolDown.Start();
            }
            else
            {
                slowbuttoncooldown.Start();
            }


        }

        private void ButtonCoolDown_Tick(object sender, EventArgs e)//once cool down is over, the button is set to play
        {
            BUTTONS[0].cooldown = false;
            BUTTONS[0].buttonPixtureBox.Image = BUTTONS[0].ready;
            ButtonCoolDown.Stop();
        }

        private void Theslowbutton_MouseClick(object sender, MouseEventArgs e)//you are only allow to press this button once
        {
            if (!(BUTTONS[1].cooldown))
            {
                SlotTimer.Interval += 100;
                ButtonInCoolDown(1);

            }
        }

        private void slowbuttoncooldown_Tick(object sender, EventArgs e)
        {
            BUTTONS[1].cooldown = false;
            BUTTONS[1].buttonPixtureBox.Image = BUTTONS[1].ready;
            slowbuttoncooldown.Stop();
        }
    }
}