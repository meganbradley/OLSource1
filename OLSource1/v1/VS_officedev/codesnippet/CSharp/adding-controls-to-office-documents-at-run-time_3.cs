            UserControl1 customControl = new UserControl1();

            Microsoft.Office.Tools.Excel.ControlSite dynamicControl =
                this.Controls.AddControl(customControl, range1, "dynamic");