---
title: "CFrameWnd::GetActiveView"
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
  - "CFrameWnd.GetActiveView"
  - "CFrameWnd::GetActiveView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActiveView method"
  - "CFrameWnd class, operations"
ms.assetid: 1b18d845-e722-4081-b05b-4679d67aa001
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::GetActiveView
Call this member function to obtain a pointer to the active view (if any) attached to a frame window (`CFrameWnd`).  
  
## Syntax  
  
```  
  
CView* GetActiveView( ) const;  
```  
  
## Return Value  
 A pointer to the current [CView](../vs140/cview-class.md). If there is no current view, returns **NULL**.  
  
## Remarks  
 This function returns **NULL** when called for an MDI main frame window (`CMDIFrameWnd`). In an MDI application, the MDI main frame window does not have a view associated with it. Instead, each individual child window (`CMDIChildWnd`) has one or more associated views. The active view in an MDI application can be obtained by first finding the active MDI child window and then finding the active view for that child window. The active MDI child window can be found by calling the function `MDIGetActive` or **GetActiveFrame** as demonstrated in the following:  
  
 [!code[NVC_MFCWindowing#2](../vs140/codesnippet/CPP/cframewnd--getactiveview_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::SetActiveView](../vs140/cframewnd--setactiveview.md)   
 [CFrameWnd::GetActiveDocument](../vs140/cframewnd--getactivedocument.md)