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
>  The attached down arrow will appear only if the `TBSTYLE_EX_DRAWDDARROWS` extended style has been set.  
  
 When the user clicks on this arrow (or the button itself, if no arrow is present), a `TBN_DROPDOWN` notification message is sent to the parent of the toolbar control. You can then handle this notification and display a pop-up menu; similar to the behavior of Internet Explorer.  
  
 The following procedure illustrates how to implement a drop-down toolbar button with a pop-up menu:  
  
### To implement a drop-down button  
  
1.  Once your `CToolBarCtrl` object has been created, set the `TBSTYLE_EX_DRAWDDARROWS` style, using the following code:  
  
     [!code[NVC_MFCControlLadenDialog#36](../VS_csharp/codesnippet/CPP/using-drop-down-buttons-in-a-toolbar-control_1.cpp)]  
  
2.  Set the `TBSTYLE_DROPDOWN` style for any new ([InsertButton](../Topic/CToolBarCtrl::InsertButton.md) or [AddButtons](../Topic/CToolBarCtrl::AddButtons.md)) or existing ([SetButtonInfo](../Topic/CToolBarCtrl::SetButtonInfo.md)) buttons that will be drop-down buttons. The following example demonstrates modifying an existing button in a `CToolBarCtrl` object:  
  
     [!code[NVC_MFCControlLadenDialog#37](../VS_csharp/codesnippet/CPP/using-drop-down-buttons-in-a-toolbar-control_2.cpp)]  
  
3.  Add a `TBN_DROPDOWN` handler to the parent class of the toolbar object.  
  
     [!code[NVC_MFCControlLadenDialog#38](../VS_csharp/codesnippet/CPP/using-drop-down-buttons-in-a-toolbar-control_3.cpp)]  
  
4.  In the new handler, display the appropriate popup menu. The following code demonstrates one method:  
  
     [!code[NVC_MFCControlLadenDialog#39](../VS_csharp/codesnippet/CPP/using-drop-down-buttons-in-a-toolbar-control_4.cpp)]  
  
## See Also  
 [Using CToolBarCtrl](../VS_csharp/using-ctoolbarctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)