        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
            if (System.DateTime.Now.Hour > 16)
            {
                Microsoft.Office.Tools.Ribbon.RibbonButton button =
                    this.Factory.CreateRibbonButton();
                button.Label = "New Button";
                group1.Items.Add(button);
            }
        }