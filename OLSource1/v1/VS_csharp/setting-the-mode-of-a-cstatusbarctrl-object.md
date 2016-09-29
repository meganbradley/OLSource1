---
title: "Setting the Mode of a CStatusBarCtrl Object"
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
  - "CStatusBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "simple mode and status bar controls"
  - "IsSimple method, using"
  - "SetSimple method"
  - "status bar controls, simple and nonsimple modes"
  - "non-simple mode and status bar controls"
  - "CStatusBarCtrl class, simple and nonsimple modes"
ms.assetid: ca6076e5-1501-4e33-8d35-9308941e46c0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Setting the Mode of a CStatusBarCtrl Object
There are two modes for a `CStatusBarCtrl` object: simple and nonsimple. In the majority of cases, your status bar control will have one or more parts, along with text and perhaps an icon or icons. This is called the nonsimple mode. For more information on this mode, see [Initializing the Parts of a CStatusBarCtrl Object](../VS_csharp/initializing-the-parts-of-a-cstatusbarctrl-object.md).  
  
 However, there are cases where you only need to display a single line of text. In this case, the simple mode is sufficient for your needs. To change the mode of the `CStatusBarCtrl` object to simple, make a call to the [SetSimple](../Topic/CStatusBarCtrl::SetSimple.md) member function. Once the status bar control is in simple mode, set the text by calling the **SetText** member function, passing 255 as the value for the **nPane** parameter.  
  
 You can use the [IsSimple](../Topic/CStatusBarCtrl::IsSimple.md) function to determine what mode the `CStatusBarCtrl` object is in.  
  
> [!NOTE]
>  If the status bar object is being changed from nonsimple to simple, or vice versa, the window is immediately redrawn and, if applicable, any defined parts are automatically restored.  
  
## See Also  
 [Using CStatusBarCtrl](../VS_csharp/using-cstatusbarctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)