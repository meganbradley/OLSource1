---
title: "CMFCToolBarsCustomizeDialog::AddToolBar"
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
  - "CMFCToolBarsCustomizeDialog::AddToolBar"
  - "AddToolBar"
  - "CMFCToolBarsCustomizeDialog.AddToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToolBar method"
ms.assetid: cb2c9879-bc43-4d08-9aac-4a153eaa8e2e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::AddToolBar
Loads a toolbar from the resources. Then, for each command in the menu calls the [CMFCToolBarsCustomizeDialog::AddButton](../vs140/cmfctoolbarscustomizedialog--addbutton.md) method to insert a button in the list of commands on the **Commands** page under the specified category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the resource ID of the category to add the toolbar to.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the resource ID of a toolbar whose commands are inserted into the list of commands.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the name of the category to which to add the toolbar.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#11](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog--addtoolbar_1.cpp)]  
  
## Remarks  
 The control that is used to represent each command is a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object. After you add the toolbar, you can replace the button with a control of a derived type by calling [CMFCToolBarsCustomizeDialog::ReplaceButton](../vs140/cmfctoolbarscustomizedialog--replacebutton.md).  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)