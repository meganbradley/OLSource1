---
title: "Using CToolTipCtrl to Create and Manipulate a CToolTipCtrl Object"
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
  - "CToolTipCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tool tips [C++], creating"
  - "CToolTipCtrl class, using"
ms.assetid: 0a34583f-f66d-46a1-a239-31b80ea395ad
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using CToolTipCtrl to Create and Manipulate a CToolTipCtrl Object
Here is an example of [CToolTipCtrl](../VS_csharp/ctooltipctrl-class.md) usage:  
  
### To create and manipulate a CToolTipCtrl  
  
1.  Construct the `CToolTipCtrl` object.  
  
2.  Call [Create](../Topic/CToolTipCtrl::Create.md) to create the Windows tool tip common control and attach it to the `CToolTipCtrl` object.  
  
3.  Call [AddTool](../Topic/CToolTipCtrl::AddTool.md) to register a tool with the tool tip control, so that the information stored in the tool tip is displayed when the cursor is on the tool.  
  
4.  Call [SetToolInfo](../Topic/CToolTipCtrl::SetToolInfo.md) to set the information that a tool tip maintains for a tool.  
  
5.  Call [SetToolRect](../Topic/CToolTipCtrl::SetToolRect.md) to set a new bounding rectangle for a tool.  
  
6.  Call [HitTest](../Topic/CToolTipCtrl::HitTest.md) to test a point to determine whether it is within the bounding rectangle of the given tool and, if so, retrieve information about the tool.  
  
7.  Call [GetToolCount](../Topic/CToolTipCtrl::GetToolCount.md) to retrieve a count of the tools registered with the tool tip control.  
  
## See Also  
 [Using CToolTipCtrl](../VS_csharp/using-ctooltipctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)