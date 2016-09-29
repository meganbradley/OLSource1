---
title: "CMFCPropertyGridCtrl::AddProperty"
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
  - "CMFCPropertyGridCtrl::AddProperty"
  - "AddProperty"
  - "CMFCPropertyGridCtrl.AddProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddProperty method"
ms.assetid: 9804fc7b-f121-42c2-9bb7-97b71b78da6d
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::AddProperty
Adds a new property to a property grid control.  
  
## Syntax  
  
```  
int AddProperty(  
   CMFCPropertyGridProperty* pProp,  
   BOOL bRedraw=TRUE,  
   BOOL bAdjustLayout=TRUE   
);  
```  
  
#### Parameters  
 [in] `pProp`  
 Pointer to a property.  
  
 [in] `bRedraw`  
 `TRUE` to redraw the property immediately; otherwise, `FALSE`. The default value is `TRUE`.  
  
 [in] `bAdjustLayout`  
 `TRUE` to recalculate how to draw the text and value of the property, and then draw the property; `FALSE` to use existing calculations to draw the property. The default value is `TRUE`.  
  
## Return Value  
 If this method succeeds, the zero-based index of the position in the property grid control where the property is added; otherwise, -1.  
  
## Remarks  
 This method adds a pointer to the specified property to the end of the list of properties in the property grid control. Do not destroy the properties or allow them to go out of scope before the grid control is destroyed. When you are done with the property grid control, call [CMFCPropertyGridCtrl::RemoveAll](../vs140/cmfcpropertygridctrl--removeall.md) to delete all the added properties. The AddProperty method fails if the specified property has already been added to the list.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridCtrl::AdjustLayout](../vs140/cmfcpropertygridctrl--adjustlayout.md)