---
title: "Spin Button Member Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "spin button control, methods"
  - "CSpinButtonCtrl class, methods"
ms.assetid: a08a26fd-b803-4cbe-a509-395fa357d057
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Spin Button Member Functions
There are several member functions available for the spin control ([CSpinButtonCtrl](../vs140/cspinbuttonctrl-class.md)). Use these functions to change the following attributes of the spin button.  
  
-   **Acceleration** You can adjust the rate at which the position changes when the user holds down the arrow button. To work with acceleration, use the [SetAccel](../vs140/cspinbuttonctrl--setaccel.md) and [GetAccel](../vs140/cspinbuttonctrl--getaccel.md) member functions.  
  
-   **Base** You can change the base (either 10 or 16) used to display the position in the caption of the buddy window. To work with the base, use the [GetBase](../vs140/cspinbuttonctrl--getbase.md) and [SetBase](../vs140/cspinbuttonctrl--setbase.md) member functions.  
  
-   **Buddy Window** You can dynamically set the buddy window. To query or change which control is the buddy window, use the [GetBuddy](../vs140/cspinbuttonctrl--getbuddy.md) and [SetBuddy](../vs140/cspinbuttonctrl--setbuddy.md) member functions.  
  
-   **Position** You can query and change the position. To work directly with position, use the [GetPos](../vs140/cspinbuttonctrl--getpos.md) and [SetPos](../vs140/cspinbuttonctrl--setpos.md) member functions. Since the caption of the buddy control may have changed (for example, in the case that the buddy is an edit control), <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> retrieves the current caption and adjusts the position accordingly.  
  
-   **Range** You can change the maximum and minimum positions for the spin button. By default, the maximum is set to 0, and the minimum is set to 100. Since the default maximum is less than the default minimum, the actions of the arrow buttons is counter-intuitive. Typically, you will set the range using the [SetRange](../vs140/cspinbuttonctrl--setrange.md) member function. To query the range use [GetRange](../vs140/cspinbuttonctrl--getrange.md).  
  
## See Also  
 [Using CSpinButtonCtrl](../vs140/using-cspinbuttonctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)