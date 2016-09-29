---
title: "CPaneFrameWnd::IsRollDown"
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
  - "CPaneFrameWnd.IsRollDown"
  - "CPaneFrameWnd::IsRollDown"
  - "IsRollDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsRollDown method"
ms.assetid: ac42419f-2bfb-4642-80a4-39c1c719c798
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::IsRollDown
Determines whether a mini-frame window should be rolled down.  
  
## Syntax  
  
```  
virtual BOOL IsRollDown() const;  
```  
  
## Return Value  
 `TRUE` if the mini-frame window must be rolled down; otherwise, `FALSE`.  
  
## Remarks  
 This method is called by the framework to determine whether a mini-frame window should be rolled down. The rollup/rolldown feature is enabled for a mini-frame window if it contains at least one pane that has the `AFX_CBRS_AUTO_ROLLUP` flag. This flag is set when a pane is created. For more information, see [CBasePane::CreateEx](../vs140/cbasepane--createex.md).  
  
 By default, the framework checks whether the mouse pointer is inside the mini-frame window bounding rectangle to determine whether the window has to be rolled down. You can override this behavior in a derived class.  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)