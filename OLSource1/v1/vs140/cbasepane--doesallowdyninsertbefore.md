---
title: "CBasePane::DoesAllowDynInsertBefore"
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
  - "CBasePane::DoesAllowDynInsertBefore"
  - "DoesAllowDynInsertBefore"
  - "CBasePane.DoesAllowDynInsertBefore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoesAllowDynInsertBefore method"
ms.assetid: 394755fd-7f7d-4e3a-bbc0-b289c0637d58
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::DoesAllowDynInsertBefore
Determines whether another pane can be dynamically inserted between this pane and the parent frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if a user can insert another pane; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method to determine whether a user can dynamically insert a pane before this pane.  
  
 For example, suppose your application creates a pane docked at the left side of the frame (such as the Outlook bar). To prevent the user from docking another pane to the left of the first pane, override this method and return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 We recommend that you override this method and return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for non-floating panes derived from [CDockablePane Class](../vs140/cdockablepane-class.md).  
  
 The default implementation returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)