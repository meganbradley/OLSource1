---
title: "CDockablePane::CanBeAttached"
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
  - "CanBeAttached"
  - "CDockablePane::CanBeAttached"
  - "CDockablePane.CanBeAttached"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeAttached method"
ms.assetid: 0aa4d1ca-a25e-4a97-87c8-ec8ca7ae6102
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CanBeAttached
Determines whether the current pane can be docked to another pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the dockable pane can be docked to another pane or to the main frame window; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 By default, this method always returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Override this method in a derived class to enable or disable docking without calling [CBasePane::EnableDocking](../vs140/cbasepane--enabledocking.md).  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)