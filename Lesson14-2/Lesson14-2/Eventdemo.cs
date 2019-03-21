using System;
using System.Windows.Forms;
using System.Drawing;

//custom delegate
public delegate void Startdelegate();

class Eventdemo : Form
    {
        //custom event
        public event Startdelegate StartEvent;

        public Eventdemo()
        {
            Button clickMe = new Button();

            clickMe.Parent = this;
            clickMe.Text = "Click Me";
            clickMe.Location = new Point(
                (ClientSize.Width - clickMe.Width) / 2,
                (ClientSize.Height - clickMe.Height) / 2);

            //an EventHandler delegate is assigned to the button's Click event
            clickMe.Click += new EventHandler(OnClickMeClicked);

            //our custom "StartDelegate" delegate is assigned to our custom "StartEvent" event
            StartEvent += new Startdelegate(OnStartEvent);

        //fire our custom event
        StartEvent();
        }

        //this method is called when the "clickMe" button is pressed
        public void OnClickMeClicked(object sender, EventArgs ea)
        {
            MessageBox.Show("You Clicked Me Button!");
        }

        //this method is called when the "StartEvent" Event is fired
        public void OnStartEvent()
        {
            MessageBox.Show("I Just Started!");
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Eventdemo());

        }
    }
