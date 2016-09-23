---
title: "CPane::MovePane"
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
  - MovePane
  - CPane::MovePane
  - CPane.MovePane
dev_langs: 
  - C++
helpviewer_keywords: 
  - MovePane method
ms.assetid: f84ee750-9502-4255-ae95-22032f6d51c6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::MovePane
Moves the pane to the specified rectangle.  
  
## Syntax  
  
```  
virtual CSize MovePane(  
   CRect rectNew,  
   BOOL bForceMove,  
   HDWP& hdwp  
);  
```  
  
#### Parameters  
 [in] `rectNew`  
 Specifies the new rectangle for the pane.  
  
 [in] `bForceMove`  
 If `TRUE`, this method ignores the minimum allowed pane size ([CPane::GetMinSize](../vs140/cpane--getminsize.md)); otherwise, the pane is adjusted, if necessary, to ensure that it is at least the minimum allowed size.  
  
 [in] `hdwp`  
 Not used.  
  
## Return Value  
 A `CSize` object that contains the differences in width and height between the new and old rectangles (old rectangle –`rectNew`).  
  
## Remarks  
 This method is used only for dockable panes.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart)](../vs140/hierarchy-chart.md)