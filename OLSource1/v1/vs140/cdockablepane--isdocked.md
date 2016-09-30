---
title: "CDockablePane::IsDocked"
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
  - "CDockablePane.IsDocked"
  - "CDockablePane::IsDocked"
  - "IsDocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDocked method"
ms.assetid: 2bcea672-e338-4037-88ee-28c56cdc6782
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::IsDocked
Determines whether the current pane is docked.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the dockable pane does not belong to a miniframe window or if it is floating in a miniframe window with another pane. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the pane is a child of a miniframe window and there are no other panes that belong to the miniframe window.  
  
## Remarks  
 To determine whether the pane is docked to the main frame window, call [CDockablePane::GetDefaultPaneDivider](../vs140/cdockablepane--getdefaultpanedivider.md). If the method returns a non-NULL pointer, the pane is docked at the main frame window.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)