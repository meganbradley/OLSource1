---
title: "CMFCPropertyGridCtrl::GetProperty"
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
  - "GetProperty"
  - "CMFCPropertyGridCtrl.GetProperty"
  - "CMFCPropertyGridCtrl::GetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProperty method"
ms.assetid: 32101829-548a-4bcb-9da8-80f564f18d5b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::GetProperty
Retrieves a pointer to the property object that corresponds to the specified index of an item in a property grid control.  
  
## Syntax  
  
```  
CMFCPropertyGridProperty* GetProperty(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 [in] `nIndex`  
 The zero-based index of a property grid control item.  
  
 This method asserts if the `nIndex` parameter is less than zero or greater than or equal to the number of properties.  
  
## Return Value  
 A pointer to the property object that corresponds to the specified index if this method is successful; otherwise, `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)