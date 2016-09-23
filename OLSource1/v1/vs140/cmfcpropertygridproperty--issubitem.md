---
title: "CMFCPropertyGridProperty::IsSubItem"
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
  - IsSubItem
  - CMFCPropertyGridProperty.IsSubItem
  - CMFCPropertyGridProperty::IsSubItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsSubItem method
ms.assetid: 04d1284f-05da-494e-bb94-b1c402b0bd68
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPropertyGridProperty::IsSubItem
Indicates whether the specified property is a sub-item of the current property.  
  
## Syntax  
  
```  
BOOL IsSubItem(  
   CMFCPropertyGridProperty* pProp   
) const;  
```  
  
#### Parameters  
 [in] `pProp`  
 A pointer to a property.  
  
## Return Value  
 `TRUE` if the specified property is a sub-item of the current property; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)