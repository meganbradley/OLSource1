---
title: "CMFCPropertySheet::RemoveCategory"
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
  - CMFCPropertySheet::RemoveCategory
  - CMFCPropertySheet.RemoveCategory
  - RemoveCategory
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveCategory method
ms.assetid: 9cccd605-a4b2-4bb6-93d5-231853d192f6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPropertySheet::RemoveCategory
Removes a node from the tree control.  
  
## Syntax  
  
```  
void RemoveCategory(  
   CMFCPropertySheetCategoryInfo* pCategory   
);  
```  
  
#### Parameters  
 [in] `pCategory`  
 Pointer to a category (node) to remove.  
  
## Remarks  
 Use this method to remove a node, which is also referred to as a category, from a tree control. Use the [CMFCPropertySheet::AddTreeCategory](../vs140/cmfcpropertysheet--addtreecategory.md) method to add a node to a tree control.  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertySheet::AddTreeCategory](../vs140/cmfcpropertysheet--addtreecategory.md)