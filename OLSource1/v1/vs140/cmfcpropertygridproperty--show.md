---
title: "CMFCPropertyGridProperty::Show"
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
  - "Show"
  - "CMFCPropertyGridProperty::Show"
  - "CMFCPropertyGridProperty.Show"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Show method"
ms.assetid: e0681015-ab82-466f-ab2f-8d126edaa1aa
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::Show
Shows or hides a property.  
  
## Syntax  
  
```  
void Show(  
   BOOL bShow=TRUE,  
   BOOL bAdjustLayout=TRUE   
);  
```  
  
#### Parameters  
 [in] `bShow`  
 `TRUE` to display the current property and its sub-items; `FALSE` to hide the current property and its sub-items. The default value is `TRUE`.  
  
 [in] `bAdjustLayout`  
 `TRUE` to recalculate how to draw the label and value of a property and then draw the property; `FALSE` to use existing calculations to draw the property. The default value is `TRUE`.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)