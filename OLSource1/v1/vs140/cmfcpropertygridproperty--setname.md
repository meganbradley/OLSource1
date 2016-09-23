---
title: "CMFCPropertyGridProperty::SetName"
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
  - CMFCPropertyGridProperty.SetName
  - SetName
  - CMFCPropertyGridProperty::SetName
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetName method
ms.assetid: 4f535aaa-f3dc-4cab-971d-8e713a827243
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPropertyGridProperty::SetName
Sets the name of a property.  
  
## Syntax  
  
```  
void SetName(  
   LPCTSTR lpszName,  
   BOOL bRedraw=TRUE   
);  
```  
  
#### Parameters  
 [in] `lpszName`  
 The property name.  
  
 [in] `bRedraw`  
 `TRUE` to redraw the property immediately; otherwise, `FALSE`. The default value is `TRUE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridProperty::GetName](../vs140/cmfcpropertygridproperty--getname.md)