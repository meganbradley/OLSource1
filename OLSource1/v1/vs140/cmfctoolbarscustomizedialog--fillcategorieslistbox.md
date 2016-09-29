---
title: "CMFCToolBarsCustomizeDialog::FillCategoriesListBox"
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
  - "CMFCToolBarsCustomizeDialog.FillCategoriesListBox"
  - "CMFCToolBarsCustomizeDialog::FillCategoriesListBox"
  - "FillCategoriesListBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillCategoriesListBox method"
ms.assetid: 7d2a476c-fbe2-4e68-8e31-7c397a9fc616
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::FillCategoriesListBox
Populates the provided `CListBox` object with the name of each command category in the **Customize** dialog box.  
  
## Syntax  
  
```  
void FillCategoriesListBox(  
   CListBox& wndCategory,  
   BOOL bAddEmpty = TRUE  
) const;  
```  
  
#### Parameters  
 [out] `wndCategory`  
 A reference to the `CListBox` object to populate.  
  
 [in] `bAddEmpty`  
 A Boolean value that specifies whether to add categories to the list box that do not have commands. If this parameter is `TRUE`, empty categories are added to the list box. Otherwise, empty categories are not added.  
  
## Remarks  
 This method is like the [CMFCToolBarsCustomizeDialog::FillCategoriesComboBox](../vs140/cmfctoolbarscustomizedialog--fillcategoriescombobox.md) method except that this method works with a `CListBox` object.  
  
 This method does not clear the contents of the `CListBox` object before populating it. It guarantees that the **All Commands** category is the final item in the list box.  
  
 You can add new command categories by using the [CMFCToolBarsCustomizeDialog::AddButton](../vs140/cmfctoolbarscustomizedialog--addbutton.md) method. You can change the name of an existing category by using the [CMFCToolBarsCustomizeDialog::RenameCategory](../vs140/cmfctoolbarscustomizedialog--renamecategory.md) method.  
  
 The `CMFCToolBarsCommandsPropertyPage` class uses this method to show the list of commands that is associated with each command category.  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CListBox Class](../vs140/clistbox-class.md)   
 [CMFCToolBarsCustomizeDialog::FillCategoriesComboBox](../vs140/cmfctoolbarscustomizedialog--fillcategoriescombobox.md)   
 [CMFCToolBarsCustomizeDialog::AddButton](../vs140/cmfctoolbarscustomizedialog--addbutton.md)   
 [CMFCToolBarsCustomizeDialog::RenameCategory](../vs140/cmfctoolbarscustomizedialog--renamecategory.md)