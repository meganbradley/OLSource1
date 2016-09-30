---
title: "CDockablePane::EnableGripper"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDockablePane.EnableGripper"
  - "CDockablePane::EnableGripper"
  - "EnableGripper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableGripper method"
ms.assetid: be4274d5-e102-474c-8633-f030d2ada263
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::EnableGripper
Shows or hides the caption (also called the gripper).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to enable the caption; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 When the framework creates dockable panes, they do not have the **WS_STYLE** window style, even if specified. This means that the pane's caption is a non-client area that is controlled by the framework, but this area differs from the standard window caption.  
  
 You can show or hide the caption at any time. The framework hides the caption when a pane is added as a tab to a tabbed window or when a pane is floated in a miniframe window.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)