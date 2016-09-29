---
title: "CMFCPropertyGridProperty::GetData"
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
  - "CMFCPropertyGridProperty.GetData"
  - "GetData"
  - "CMFCPropertyGridProperty::GetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetData method"
ms.assetid: 84c6d893-132f-46d3-ae7d-ef65312621d5
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::GetData
Retrieves a `DWORD` value that is associated with a property.  
  
## Syntax  
  
```  
DWORD_PTR GetData() const;  
```  
  
## Return Value  
 A `DWORD` value.  
  
## Remarks  
 The data that is returned is an application-specific value, such as a number or a pointer to other data. Specify the data value when you construct the property or when you call the [CMFCPropertyGridProperty::SetData](../vs140/cmfcpropertygridproperty--setdata.md) method.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridProperty::SetData](../vs140/cmfcpropertygridproperty--setdata.md)   
 [CMFCPropertyGridProperty::CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty--cmfcpropertygridproperty.md)