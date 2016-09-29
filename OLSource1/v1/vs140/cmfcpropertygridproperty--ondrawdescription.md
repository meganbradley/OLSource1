---
title: "CMFCPropertyGridProperty::OnDrawDescription"
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
  - "OnDrawDescription"
  - "CMFCPropertyGridProperty::OnDrawDescription"
  - "CMFCPropertyGridProperty.OnDrawDescription"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawDescription method"
ms.assetid: c9afbf2d-fe82-48bc-898a-b2751116719a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::OnDrawDescription
Called by the framework to draw the property description.  
  
## Syntax  
  
```  
virtual void OnDrawDescription(  
   CDC* pDC,  
   CRect rect   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A bounding rectangle that specifies where to draw the property description.  
  
## Remarks  
 By default, this method draws the property name and description in the font used by the parent property list control. The property description is drawn in regular style and the property name is drawn in bold style.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)