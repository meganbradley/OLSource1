---
title: "CMFCPropertyGridProperty::SetOriginalValue"
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
  - "SetOriginalValue"
  - "CMFCPropertyGridProperty::SetOriginalValue"
  - "CMFCPropertyGridProperty.SetOriginalValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOriginalValue method"
ms.assetid: 6f5f6e0e-dccc-4d5c-832b-6dd25c8c5f86
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::SetOriginalValue
Sets the original value of an editable property.  
  
## Syntax  
  
```  
virtual void SetOriginalValue(  
   const COleVariant& varValue  
);  
```  
  
#### Parameters  
 [in] `varValue`  
 A value.  
  
## Remarks  
 Use the [CMFCPropertyGridProperty::ResetOriginalValue](../vs140/cmfcpropertygridproperty--resetoriginalvalue.md) method to reset the original value of an edited property.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridProperty::ResetOriginalValue](../vs140/cmfcpropertygridproperty--resetoriginalvalue.md)   
 [COleVariant Class](../vs140/colevariant-class.md)