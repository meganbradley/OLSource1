---
title: "CMFCPropertyGridProperty::AddSubItem"
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
  - "CMFCPropertyGridProperty::AddSubItem"
  - "CMFCPropertyGridProperty.AddSubItem"
  - "AddSubItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddSubItem method"
ms.assetid: f9d38897-5098-4f3e-8061-13519fbc5e9c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::AddSubItem
Adds a child item to a property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a property to add.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the specified property is successfully added as a child property. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the property is not added because it already occurs in the parent property.  
  
## Remarks  
 Use this method to create a hierarchical list of parent and child properties. After a child property is added, the parent property automatically displays an expand box control that is designated by a plus sign (+). When the user clicks the plus sign, the parent property expands and displays any child property items.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)