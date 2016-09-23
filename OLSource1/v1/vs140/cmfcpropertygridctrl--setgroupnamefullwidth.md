---
title: "CMFCPropertyGridCtrl::SetGroupNameFullWidth"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SetGroupNameFullWidth
  - CMFCPropertyGridCtrl.SetGroupNameFullWidth
  - CMFCPropertyGridCtrl::SetGroupNameFullWidth
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetGroupNameFullWidth method
ms.assetid: 5eb1c67b-3949-41fd-b239-7ba10a7e2cfa
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPropertyGridCtrl::SetGroupNameFullWidth
Specifies whether to display the full width of the category name for a group of properties in the current property grid control.  
  
## Syntax  
  
```  
void SetGroupNameFullWidth(  
   BOOL bGroupNameFullWidth = TRUE,  
   BOOL bRedraw = TRUE  
);  
```  
  
#### Parameters  
 [in] `bGroupNameFullWidth`  
 `TRUE` to display the complete width of the category name regardless of the width of the property name column. `FALSE` to limit the width of the category name to the width of the property name column. The default value is `TRUE`.  
  
 [in] `bRedraw`  
 `TRUE` to update the property grid control immediately; `FALSE` to update the control when the next redraw event occurs. The default value is `TRUE`.  
  
## Remarks  
 The property grid control consists of a resizable *property name* column and a *property value* column. The end of the name column is also the start of the value column. To resize the columns, drag the border between the columns.  
  
 The terms *group name* and *category name* are used interchangeably in this method. The category name is displayed on a row that heads a set of related properties and values. This method specifies whether the width of the property name column also specifies the width of the displayed category name.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)