---
title: "CMFCToolBarsCustomizeDialog::RenameCategory"
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
  - CMFCToolBarsCustomizeDialog::RenameCategory
  - RenameCategory
  - CMFCToolBarsCustomizeDialog.RenameCategory
dev_langs: 
  - C++
helpviewer_keywords: 
  - RenameCategory method
ms.assetid: dad565ef-62a6-433e-a8b9-a76c4a1e00b3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarsCustomizeDialog::RenameCategory
Renames a category in the list box of categories on the **Commands** page.  
  
## Syntax  
  
```  
BOOL RenameCategory(  
   LPCTSTR lpszCategoryOld,  
   LPCTSTR lpszCategoryNew   
);  
```  
  
#### Parameters  
 [in] `lpszCategoryOld`  
 The category name to change.  
  
 [in] `lpszCategoryNew`  
 The new category name.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise `FALSE`.  
  
## Remarks  
 The category name must be unique.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)