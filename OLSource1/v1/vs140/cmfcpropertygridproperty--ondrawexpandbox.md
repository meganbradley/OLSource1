---
title: "CMFCPropertyGridProperty::OnDrawExpandBox"
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
  - "CMFCPropertyGridProperty.OnDrawExpandBox"
  - "OnDrawExpandBox"
  - "CMFCPropertyGridProperty::OnDrawExpandBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawExpandBox method"
ms.assetid: 4e4a9666-bff3-446d-91cc-6064e578cdee
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::OnDrawExpandBox
Called by the framework to draw an expand box control near a property that contains sub-properties.  
  
## Syntax  
  
```  
virtual void OnDrawExpandBox(  
   CDC* pDC,  
   CRect rectExpand   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectExpand`  
 A bounding rectangle that specifies where to draw the expand box control.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## Remarks  
 Click the expand box control to expand or collapse a list of sub-properties. The expand box control is designated by a square that contains a plus (+) or minus (-) sign. A plus sign indicates that the property can be expanded to show a list of sub-properties. A minus sign indicates that the list can be collapsed to show only the property.  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)