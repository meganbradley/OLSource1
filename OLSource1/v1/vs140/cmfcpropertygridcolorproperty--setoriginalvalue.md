---
title: "CMFCPropertyGridColorProperty::SetOriginalValue"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: 9cda1d8e-e634-48e6-be7a-4be68c916daa
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridColorProperty::SetOriginalValue
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
 [CMFCPropertyGridColorProperty](../vs140/cmfcpropertygridcolorproperty-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridProperty::ResetOriginalValue](../vs140/cmfcpropertygridproperty--resetoriginalvalue.md)   
 [COleVariant Class](../vs140/colevariant-class.md)