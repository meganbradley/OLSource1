---
title: "CMFCPropertyGridProperty::GetOptionCount"
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
  - "GetOptionCount"
  - "CMFCPropertyGridProperty.GetOptionCount"
  - "CMFCPropertyGridProperty::GetOptionCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOptionCount method"
ms.assetid: 7c2f8867-86ca-482c-9ebe-dcf19894cd9a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::GetOptionCount
Retrieves the number of options that belong to a property.  
  
## Syntax  
  
```  
int GetOptionCount() const;  
```  
  
## Return Value  
 The number of property list items (options) that are contained in the property control.  
  
## Remarks  
 Call the [CMFCPropertyGridProperty::AddOption](../vs140/cmfcpropertygridproperty--addoption.md) method to add items to the property list. Call the [CMFCPropertyGridProperty::RemoveAllOptions](../vs140/cmfcpropertygridproperty--removealloptions.md) method to remove all items.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)