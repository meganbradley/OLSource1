      CProgressCtrl myCtrl;

      // Create a smooth child progress control.
      myCtrl.Create(WS_CHILD|WS_VISIBLE|PBS_SMOOTH, CRect(10,10,200,30), 
         pParentWnd, IDC_PROGRESSCTRL);

      // Set the background color to red.
      myCtrl.SetBkColor(RGB(255, 0, 0));   