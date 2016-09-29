---
title: "CMFCToolBarsCustomizeDialog::AddButton"
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
  - "CMFCToolBarsCustomizeDialog.AddButton"
  - "CMFCToolBarsCustomizeDialog::AddButton"
  - "AddButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddButton method"
ms.assetid: 3120100d-0160-45c4-91e6-73f1cdbbe6e5
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::AddButton
Inserts a toolbar button into the list of commands on the **Commands** page.  
  
## Syntax  
  
```  
void AddButton(  
   UINT uiCategoryId,  
   const CMFCToolBarButton& button,  
   int iInsertBefore=-1   
);  
void AddButton(  
   LPCTSTR lpszCategory,  
   const CMFCToolBarButton& button,  
   int iInsertBefore=-1   
);  
```  
  
#### Parameters  
 [in] `uiCategoryId`  
 Specifies the category ID into which to insert the button.  
  
 [in] `button`  
 Specifies the button to insert.  
  
 [in] `iInsertBefore`  
 Specifies the zero-based index of a toolbar button before which the button is inserted.  
  
 [in] `lpszCategory`  
 Specifies the category string to insert the button.  
  
## Remarks  
 The `AddButton` method ignores buttons that have the standard command IDs (such as ID_FILE_MRU_FILE1), commands that are not permitted (see [CMFCToolBar::IsCommandPermitted](../vs140/cmfctoolbar--iscommandpermitted.md)) and dummy buttons.  
  
 This method creates a new object of the same type as `button` (usually a [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)) by using the runtime class of the button. It then calls [CMFCToolBarButton::CopyFrom](../vs140/cmfctoolbarbutton--copyfrom.md) to copy the data members of button, and inserts the copy into the specified category.  
  
 When the new button is inserted, it receives the `OnAddToCustomizePage` notification.  
  
 If `iInsertBefore` is -1, the button is appended to the list of categories; otherwise it is inserted before the item with the specified index.  
  
## Example  
 The following example demonstrates how to use the `AddButton` method of the `CMFCToolBarsCustomizeDialog` class. This code snippet is part of the [Slider sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_Slider#1](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog--addbutton_1.cpp)]  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)