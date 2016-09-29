---
title: "CTabView::AddView"
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
  - "CTabView::AddView"
  - "CTabView.AddView"
  - "AddView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddView method"
ms.assetid: f7b99c23-3469-4844-bfcd-4be41fc49bdc
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabView::AddView
Adds a view to the tab control.  
  
## Syntax  
  
```  
int AddView(  
   CRuntimeClass* pViewClass,  
   const CString& strViewLabel,  
   int iIndex=-1,  
   CCreateContext* pContext=NULL   
);  
```  
  
#### Parameters  
 [in] `pViewClass`  
 A pointer to a runtime class of the inserted view.  
  
 [in] `strViewLabel`  
 Specifies the tab's text.  
  
 [in] `iIndex`  
 Specifies the zero-based position at which to insert the view. If the position is -1 the new tab is inserted at the end.  
  
 [in] `pContext`  
 A pointer to the `CCreateContext` of the view.  
  
## Return Value  
 A view index if this method succeeds. Otherwise, -1.  
  
## Remarks  
 Call this function to add a view to the tab control that is embedded in a frame.  
  
## Requirements  
 **Header:** afxTabView.h  
  
## See Also  
 [CTabView Class](../vs140/ctabview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)