---
title: "CTabView::RemoveView"
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
  - "CTabView.RemoveView"
  - "RemoveView"
  - "CTabView::RemoveView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveView method"
ms.assetid: a960e098-41c1-4809-ae9b-7cc99fb87a05
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabView::RemoveView
Removes the view from the tab control.  
  
## Syntax  
  
```  
BOOL RemoveView(  
   int iTabNum   
);  
```  
  
#### Parameters  
 [in] `iTabNum`  
 The index of the view to remove.  
  
## Return Value  
 The index of the removed view if this method succeeds. Otherwise -1.  
  
## Remarks  
  
## Requirements  
 **Header:** afxTabView.h  
  
## See Also  
 [CTabView Class](../vs140/ctabview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)