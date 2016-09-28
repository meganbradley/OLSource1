---
title: "CMFCPropertyGridProperty::OnDrawValue"
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
  - "CMFCPropertyGridProperty::OnDrawValue"
  - "OnDrawValue"
  - "CMFCPropertyGridProperty.OnDrawValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawValue method"
ms.assetid: dac64b95-2630-44c1-a1d7-79f9daef6fe3
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::OnDrawValue
Called by the framework to display the property value.  
  
## Syntax  
  
```  
virtual void OnDrawValue(  
   CDC* pDC,  
   CRect rect   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A bounding rectangle that specifies where to draw the property value.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)