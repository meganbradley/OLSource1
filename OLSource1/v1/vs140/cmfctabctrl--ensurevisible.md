---
title: "CMFCTabCtrl::EnsureVisible"
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
  - "CMFCTabCtrl::EnsureVisible"
  - "CMFCTabCtrl.EnsureVisible"
  - "EnsureVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnsureVisible method"
ms.assetid: 6b39976e-2edb-4ea6-a07c-5f33b9951a49
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::EnsureVisible
Ensures that a tab is visible.  
  
## Syntax  
  
```  
virtual BOOL EnsureVisible(  
   int iTab   
);  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of a tab.  
  
## Return Value  
 `TRUE` if it is successful; `FALSE` if the `iTab` parameter index is invalid.  
  
## Remarks  
 Use this method to guarantee that the specified tab is visible. The tab control will scroll if it is required.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)