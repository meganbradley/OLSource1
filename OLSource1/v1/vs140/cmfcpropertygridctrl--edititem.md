---
title: "CMFCPropertyGridCtrl::EditItem"
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
  - "CMFCPropertyGridCtrl.EditItem"
  - "CMFCPropertyGridCtrl::EditItem"
  - "EditItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EditItem method"
ms.assetid: d6edf8b8-0405-4083-97c4-1386cbc74b65
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::EditItem
Called by the framework when the user starts to modify a property.  
  
## Syntax  
  
```  
virtual BOOL EditItem(  
   CMFCPropertyGridProperty* pProp,  
   LPPOINT lptClick=NULL   
);  
```  
  
#### Parameters  
 [in] `pProp`  
 Pointer to a property.  
  
 [in] `lptClick`  
 The point on the property grid control that the user clicked to begin the edit operation. The point is in the client coordinates of the control. The default value is `NULL`.  
  
## Return Value  
 `TRUE` if method is successful; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)