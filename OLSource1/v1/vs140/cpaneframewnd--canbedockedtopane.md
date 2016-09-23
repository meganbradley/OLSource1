---
title: "CPaneFrameWnd::CanBeDockedToPane"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CanBeDockedToPane
  - CPaneFrameWnd.CanBeDockedToPane
  - CPaneFrameWnd::CanBeDockedToPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanBeDockedToPane method
ms.assetid: 61dcb452-971c-44a1-898c-7a995f3b09d7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPaneFrameWnd::CanBeDockedToPane
Determines whether the mini-frame window can be docked to a pane.  
  
## Syntax  
  
```  
virtual BOOL CanBeDockedToPane(  
   const CDockablePane* pDockingBar  
) const;  
```  
  
#### Parameters  
 [in] `pDockingBar`  
 A pane.  
  
## Return Value  
 Nonzero if the mini-frame can be docked to `pDockingBar`; otherwise 0.  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)