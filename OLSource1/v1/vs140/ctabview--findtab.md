---
title: "CTabView::FindTab"
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
  - FindTab
  - CTabView.FindTab
  - CTabView::FindTab
dev_langs: 
  - C++
helpviewer_keywords: 
  - FindTab method
ms.assetid: 9a6ac27e-3312-4d37-967f-7bd0efc8e582
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTabView::FindTab
Returns the index of the specified view in the tab control.  
  
## Syntax  
  
```  
int FindTab(  
   HWND hWndView   
) const;  
```  
  
#### Parameters  
 [in] `hWndView`  
 The handle of the view.  
  
## Return Value  
 The index of the view if it is found; otherwise, -1.  
  
## Remarks  
 Call this function to retrieve the index of a view that has a specified handle.  
  
## Requirements  
 **Header:** afxTabView.h  
  
## See Also  
 [CTabView Class](../vs140/ctabview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)