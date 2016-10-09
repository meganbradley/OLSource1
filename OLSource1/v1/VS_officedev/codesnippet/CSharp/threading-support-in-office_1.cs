            System.Threading.Thread t = new System.Threading.Thread(AnObject.aMethod);

            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();