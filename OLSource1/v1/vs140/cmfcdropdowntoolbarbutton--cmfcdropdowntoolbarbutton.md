---
title: "CMFCDropDownToolbarButton::CMFCDropDownToolbarButton"
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
  - "CMFCDropDownToolbarButton"
  - "CMFCDropDownToolbarButton::CMFCDropDownToolbarButton"
  - "CMFCDropDownToolbarButton.CMFCDropDownToolbarButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCDropDownToolbarButton class, constructor"
ms.assetid: bd35b044-b003-4e4e-b4f1-5a1231612d30
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownToolbarButton::CMFCDropDownToolbarButton
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The default text of the button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that is displayed when the user presses the button.  
  
## Remarks  
 The second overload of the constructor copies to the drop-down button the first button from the toolbar that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> specifies.  
  
 Typically, a drop-down toolbar button uses the text from the most recently used button in the toolbar that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> specifies. It uses the text specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> when the button is converted to a menu button or is displayed in the **Commands** tab of the **Customize** dialog box. For more information about the **Customize** dialog box, see [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md).  
  
## Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#31](../vs140/codesnippet/CPP/cmfcdropdowntoolbarbutton--cmfcdropdowntoolbarbutton_1.cpp)]  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCDropDownToolBar Class](../vs140/cmfcdropdowntoolbar-class.md)   
 [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md)