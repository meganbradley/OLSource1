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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the category ID into which to insert the button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the button to insert.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the zero-based index of a toolbar button before which the button is inserted.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the category string to insert the button.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method ignores buttons that have the standard command IDs (such as ID_FILE_MRU_FILE1), commands that are not permitted (see [CMFCToolBar::IsCommandPermitted](../vs140/cmfctoolbar--iscommandpermitted.md)) and dummy buttons.  
  
 This method creates a new object of the same type as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (usually a [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)) by using the runtime class of the button. It then calls [CMFCToolBarButton::CopyFrom](../vs140/cmfctoolbarbutton--copyfrom.md) to copy the data members of button, and inserts the copy into the specified category.  
  
 When the new button is inserted, it receives the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> notification.  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is -1, the button is appended to the list of categories; otherwise it is inserted before the item with the specified index.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class. This code snippet is part of the [Slider sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_Slider#1](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog--addbutton_1.cpp)]  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)