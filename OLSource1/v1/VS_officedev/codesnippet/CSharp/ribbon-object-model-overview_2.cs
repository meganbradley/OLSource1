        protected override Microsoft.Office.Core.IRibbonExtensibility
            CreateRibbonExtensibilityObject()
        {
            bool myCondition = false;
            if (myCondition == true)
            {
                Ribbon1 tempRibbon = new Ribbon1();
                tempRibbon.tab1.ControlId.ControlIdType =
                    Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
                tempRibbon.tab1.ControlId.OfficeId = "TabHome";
                return Globals.Factory.GetRibbonFactory().CreateRibbonManager( 
                    new Microsoft.Office.Tools.Ribbon.IRibbonExtension[]
                     { tempRibbon });
            }
            else
            {
                Ribbon2 tempRibbon = new Ribbon2();
                tempRibbon.tab1.ControlId.ControlIdType =
                    Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
                tempRibbon.tab1.ControlId.OfficeId = "TabInsert";
                return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                                    new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { tempRibbon });
            }
        }