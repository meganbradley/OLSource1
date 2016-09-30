---
title: "CMFCPropertyGridProperty::GetOriginalValue"
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
  - "CMFCPropertyGridProperty::GetOriginalValue"
  - "CMFCPropertyGridProperty.GetOriginalValue"
  - "GetOriginalValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOriginalValue method"
ms.assetid: 46926379-0561-46bd-a531-04951e65b765
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::GetOriginalValue
Retrieves the initial value of the current property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The original value of the current property.  
  
## Remarks  
 Use this method to undo the effect of an edit operation that changes the value of the current property.  
  
 The original value of the current property is set by the [CMFCPropertyGridProperty::CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty--cmfcpropertygridproperty.md) constructor, modified by the [CMFCPropertyGridProperty::SetOriginalValue](../vs140/cmfcpropertygridproperty--setoriginalvalue.md) method, and reset by the [CMFCPropertyGridProperty::ResetOriginalValue](../vs140/cmfcpropertygridproperty--resetoriginalvalue.md) method.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridProperty::CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty--cmfcpropertygridproperty.md)   
 [CMFCPropertyGridProperty::SetOriginalValue](../vs140/cmfcpropertygridproperty--setoriginalvalue.md)   
 [CMFCPropertyGridProperty::ResetOriginalValue](../vs140/cmfcpropertygridproperty--resetoriginalvalue.md)