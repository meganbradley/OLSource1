---
title: "Using a Hot Key Control"
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
  - "CHotKeyCtrl class, using"
  - "hot key controls"
ms.assetid: cdd6524b-cc43-447f-b151-164273559685
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using a Hot Key Control
Typical usage of a hot key control follows the pattern below:  
  
-   The control is created. If the control is specified in a dialog box template, creation is automatic when the dialog box is created. (You should have a [CHotKeyCtrl](../VS_csharp/chotkeyctrl-class.md) member in your dialog class that corresponds to the hot key control.) Alternatively, you can use the [Create](../Topic/CHotKeyCtrl::Create.md) member function to create the control as a child window of any window.  
  
-   If you want to set a default value for the control, call the [SetHotKey](../Topic/CHotKeyCtrl::SetHotKey.md) member function. If you want to prohibit certain shift states, call [SetRules](../Topic/CHotKeyCtrl::SetRules.md). For controls in a dialog box, a good time to do this is in the dialog box's [OnInitDialog](../Topic/CDialog::OnInitDialog.md) function.  
  
-   The user interacts with the control by pressing a hot key combination when the hot key control has focus. The user then somehow indicates that this task is complete, perhaps by clicking a button in the dialog box.  
  
-   When your program is notified that the user has selected a hot key, it should use the member function [GetHotKey](../Topic/CHotKeyCtrl::GetHotKey.md) to retrieve the virtual key and shift state values from the hot key control.  
  
-   Once you know what key the user selected, you can set the hot key using one of the methods described in [Setting a Hot Key](../VS_csharp/setting-a-hot-key.md).  
  
-   If the hot key control is in a dialog box, it and the `CHotKeyCtrl` object will be destroyed automatically. If not, you need to ensure that both the control and the `CHotKeyCtrl` object are properly destroyed.  
  
## See Also  
 [Using CHotKeyCtrl](../VS_csharp/using-chotkeyctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)