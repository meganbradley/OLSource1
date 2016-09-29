---
title: "CTabView::SetActiveView"
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
  - "SetActiveView"
  - "CTabView::SetActiveView"
  - "CTabView.SetActiveView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetActiveView method"
ms.assetid: d8dd5f5a-493e-4182-8c3f-0f0fca8449bb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabView::SetActiveView
Makes a view active.  
  
## Syntax  
  
```  
BOOL SetActiveView(  
   int iTabNum   
);  
```  
  
#### Parameters  
 [in] `iTabNum`  
 The zero-based index of the tab view.  
  
## Return Value  
 `TRUE` if the specified view was made active, `FALSE` if the view's index is invalid.  
  
## Remarks  
 For more information see [CMFCTabCtrl::SetActiveTab](../vs140/cmfctabctrl--setactivetab.md).  
  
## Requirements  
 **Header:** afxTabView.h  
  
## See Also  
 [CTabView Class](../vs140/ctabview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)