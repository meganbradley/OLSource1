---
title: "CMFCPropertySheet::AddPageToTree"
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
  - "AddPageToTree"
  - "CMFCPropertySheet::AddPageToTree"
  - "CMFCPropertySheet.AddPageToTree"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddPageToTree method"
ms.assetid: 45782f6d-cf61-47b4-9e69-5914dab29961
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertySheet::AddPageToTree
Adds a new property page to the tree control.  
  
## Syntax  
  
```  
void AddPageToTree(  
   CMFCPropertySheetCategoryInfo* pCategory,  
   CMFCPropertyPage* pPage,  
   int nIconNum=-1,  
   int nSelIconNum=-1   
);  
```  
  
#### Parameters  
 [in] `pCategory`  
 Pointer to a parent tree node, or `NULL` to associate the specified page with the top-level node. Call the [CMFCPropertySheet::AddTreeCategory](../vs140/cmfcpropertysheet--addtreecategory.md) method to obtain this pointer.  
  
 [in] `pPage`  
 Pointer to a property page object.  
  
 [in] `nIconNum`  
 Zero-based index of an icon, or -1 if no icon is used. The icon is displayed next to the tree control property page when the page is not selected. The default value is -1.  
  
 [in] `nSelIconNum`  
 Zero-based index of an icon, or -1 if no icon is used. The icon is displayed next to the tree control property page when the page is selected. The default value is -1.  
  
## Remarks  
 This method adds a property page as a leaf of a tree control. To add a property page, create a `CMFCPropertySheet` object, call the [CMFCPropertySheet::SetLook](../vs140/cmfcpropertysheet--setlook.md) method with the `look` parameter set to `CMFCPropertySheet::PropSheetLook_Tree`, and then use this method to add the property page.  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertySheet::AddTreeCategory](../vs140/cmfcpropertysheet--addtreecategory.md)