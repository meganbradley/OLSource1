---
title: "CMFCToolBarsCustomizeDialog::FillCategoriesComboBox"
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
  - "CMFCToolBarsCustomizeDialog.FillCategoriesComboBox"
  - "CMFCToolBarsCustomizeDialog::FillCategoriesComboBox"
  - "FillCategoriesComboBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillCategoriesComboBox method"
ms.assetid: 2b40e59d-a51a-49cf-9d52-289a43d28be5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::FillCategoriesComboBox
Populates the provided <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object with the name of each command category in the **Customize** dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to populate.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to add categories to the combo box that do not have commands. If this parameter is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, empty categories are added to the combo box. Otherwise, empty categories are not added.  
  
## Remarks  
 This method is like the [CMFCToolBarsCustomizeDialog::FillCategoriesListBox](../vs140/cmfctoolbarscustomizedialog--fillcategorieslistbox.md) method except that this method works with a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 This method does not clear the contents of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object before populating it. It guarantees that the **All Commands** category is the final item in the combo box.  
  
 You can add new command categories by using the [CMFCToolBarsCustomizeDialog::AddButton](../vs140/cmfctoolbarscustomizedialog--addbutton.md) method. You can change the name of an existing category by using the [CMFCToolBarsCustomizeDialog::RenameCategory](../vs140/cmfctoolbarscustomizedialog--renamecategory.md) method.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> classes use this method to categorize keyboard mappings.  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [CMFCToolBarsCustomizeDialog::FillCategoriesListBox](../vs140/cmfctoolbarscustomizedialog--fillcategorieslistbox.md)   
 [CMFCToolBarsCustomizeDialog::AddButton](../vs140/cmfctoolbarscustomizedialog--addbutton.md)   
 [CMFCToolBarsCustomizeDialog::RenameCategory](../vs140/cmfctoolbarscustomizedialog--renamecategory.md)   
 [CMFCKeyMapDialog Class](../vs140/cmfckeymapdialog-class.md)