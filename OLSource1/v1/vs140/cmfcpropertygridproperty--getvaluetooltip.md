---
title: "CMFCPropertyGridProperty::GetValueTooltip"
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
  - "GetValueTooltip"
  - "CMFCPropertyGridProperty::GetValueTooltip"
  - "CMFCPropertyGridProperty.GetValueTooltip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetValueTooltip method"
ms.assetid: 3ad9a977-fed2-4fda-8d52-2d751da82106
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::GetValueTooltip
Called by the framework to retrieve the text representation of the property value that is then displayed in a tooltip.  
  
## Syntax  
  
```  
virtual CString GetValueTooltip();  
```  
  
## Return Value  
 A `CString` object containing the textual representation of the property value. By default, this value is the empty string.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)