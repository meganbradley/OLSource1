---
title: "CMFCPropertySheet::AddTreeCategory"
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
  - AddTreeCategory
  - CMFCPropertySheet::AddTreeCategory
  - CMFCPropertySheet.AddTreeCategory
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddTreeCategory method
ms.assetid: 05cd3006-755d-44f8-8850-ed98c34369e0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPropertySheet::AddTreeCategory
Adds a new node to the tree control.  
  
## Syntax  
  
```  
CMFCPropertySheetCategoryInfo* AddTreeCategory(  
   LPCTSTR lpszLabel,  
   int nIconNum=-1,  
   int nSelectedIconNum=-1,  
   const CMFCPropertySheetCategoryInfo* pParentCategory=NULL   
);  
```  
  
#### Parameters  
 [in] `lpszLabel`  
 The name of the node.  
  
 [in] `nIconNum`  
 Zero-based index of an icon, or -1 if no icon is used. The icon is displayed next to the tree control property page when the page is not selected. The default value is -1.  
  
 [in] `nSelectedIconNum`  
 Zero-based index of an icon, or -1 if no icon is used. The icon is displayed next to the tree control property page when the page is selected. The default value is -1.  
  
 [in] `pParentCategory`  
 Pointer to a parent tree node, or `NULL` to associate the specified page with the top-level node. Set this parameter with the [CMFCPropertySheet::AddTreeCategory](../vs140/cmfcpropertysheet--addtreecategory.md) method.  
  
## Return Value  
 A pointer to the new node in the tree control.  
  
## Remarks  
 Use this method to add a new node, which is also referred to as a category, to the tree control. To add a node, create a `CMFCPropertySheet` object, call the [CMFCPropertySheet::SetLook](../vs140/cmfcpropertysheet--setlook.md) method with the `look` parameter set to  `CMFCPropertySheet::PropSheetLook_Tree`, and then use this method to add the node.  
  
 Use the return value of this method in subsequent calls to [CMFCPropertySheet::AddPageToTree](../vs140/cmfcpropertysheet--addpagetotree.md) and [CMFCPropertySheet::AddTreeCategory](../vs140/cmfcpropertysheet--addtreecategory.md).  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)