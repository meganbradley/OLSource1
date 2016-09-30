---
title: "Using Drop-Down Buttons in a Toolbar Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "TBN_DROPDOWN"
  - "TBSTYLE_EX_DRAWDDARROWS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CToolBarCtrl class, drop-down buttons"
  - "toolbars [C++], drop-down buttons"
  - "drop-down buttons in toolbars"
  - "TBSTYLE_EX_DRAWDDARROWS"
  - "TBN_DROPDOWN notification"
ms.assetid: b859f758-d2f6-40d9-9c26-0ff61993b9b2
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Drop-Down Buttons in a Toolbar Control
In addition to standard push buttons, a toolbar can also have drop-down buttons. A drop-down button is usually indicated by the presence of an attached down arrow.  
  
> [!NOTE]
>  The attached down arrow will appear only if the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> extended style has been set.  
  
 When the user clicks on this arrow (or the button itself, if no arrow is present), a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> notification message is sent to the parent of the toolbar control. You can then handle this notification and display a pop-up menu; similar to the behavior of Internet Explorer.  
  
 The following procedure illustrates how to implement a drop-down toolbar button with a pop-up menu:  
  
### To implement a drop-down button  
  
1.  Once your <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object has been created, set the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> style, using the following code:  
  
     [!code[NVC_MFCControlLadenDialog#36](../vs140/codesnippet/CPP/using-drop-down-buttons-in-a-toolbar-control_1.cpp)]  
  
2.  Set the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> style for any new ([InsertButton](../vs140/ctoolbarctrl--insertbutton.md) or [AddButtons](../vs140/ctoolbarctrl--addbuttons.md)) or existing ([SetButtonInfo](../vs140/ctoolbarctrl--setbuttoninfo.md)) buttons that will be drop-down buttons. The following example demonstrates modifying an existing button in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object:  
  
     [!code[NVC_MFCControlLadenDialog#37](../vs140/codesnippet/CPP/using-drop-down-buttons-in-a-toolbar-control_2.cpp)]  
  
3.  Add a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> handler to the parent class of the toolbar object.  
  
     [!code[NVC_MFCControlLadenDialog#38](../vs140/codesnippet/CPP/using-drop-down-buttons-in-a-toolbar-control_3.cpp)]  
  
4.  In the new handler, display the appropriate popup menu. The following code demonstrates one method:  
  
     [!code[NVC_MFCControlLadenDialog#39](../vs140/codesnippet/CPP/using-drop-down-buttons-in-a-toolbar-control_4.cpp)]  
  
## See Also  
 [Using CToolBarCtrl](../vs140/using-ctoolbarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)