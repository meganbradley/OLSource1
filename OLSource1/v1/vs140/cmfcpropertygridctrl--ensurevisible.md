---
title: "CMFCPropertyGridCtrl::EnsureVisible"
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
  - "CMFCPropertyGridCtrl::EnsureVisible"
  - "CMFCPropertyGridCtrl.EnsureVisible"
  - "EnsureVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnsureVisible method"
ms.assetid: 48307847-5f54-4bc6-b3eb-90a5ba601117
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::EnsureVisible
Scrolls a property grid control and expands property items until the specified property is visible.  
  
## Syntax  
  
```  
void EnsureVisible(  
   CMFCPropertyGridProperty* pProp,  
   BOOL bExpandParents=FALSE   
);  
```  
  
#### Parameters  
 [in] `pProp`  
 Pointer to a property.  
  
 [in] `bExpandParents`  
 `TRUE` to expand parent items to make the specified property visible; otherwise, `FALSE`. The default is `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)