---
title: "CMFCPropertyGridCtrl::DeleteProperty"
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
  - "CMFCPropertyGridCtrl.DeleteProperty"
  - "CMFCPropertyGridCtrl::DeleteProperty"
  - "DeleteProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteProperty method"
ms.assetid: 53894fbd-fba5-44e6-a25f-333024483045
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::DeleteProperty
Deletes the specified property from the property grid control.  
  
## Syntax  
  
```  
BOOL DeleteProperty(  
   CMFCPropertyGridProperty*& pProp,  
   BOOL bRedraw=TRUE,  
   BOOL bAdjustLayout=TRUE   
);  
```  
  
#### Parameters  
 [in] `pProp`  
 Pointer to a property.  
  
 [in] `bRedraw`  
 `TRUE` to redraw the property grid control; otherwise, `FALSE`. The default value is `TRUE`.  
  
 [in] `bAdjustLayout`  
 `TRUE` to recalculate how to draw all the text, images, and items in the property grid control, and then draw the control; otherwise, `FALSE`. The default value is `TRUE`.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise, `FALSE`.  
  
## Remarks  
 Use this method to delete a property, and any sub-items, from the property grid control.  
  
## Requirements  
 **Header:** afxPropertyGridCtrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)