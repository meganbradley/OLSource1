---
title: "CToolBarCtrl::InsertButton"
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
  - "CToolBarCtrl::InsertButton"
  - "CToolBarCtrl.InsertButton"
  - "InsertButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertButton method"
ms.assetid: c5b11606-5711-4e14-a7ff-276a45f86f57
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::InsertButton
Inserts a button in a toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of a button. This function inserts the new button to the left of this button.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure containing information about the button to insert. See [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md) for a description of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The image and/or string whose index you provide must have previously been added to the toolbar control's list using [AddBitmap](../vs140/ctoolbarctrl--addbitmap.md), [AddString](../vs140/ctoolbarctrl--addstring.md), and/or [AddStrings](../vs140/ctoolbarctrl--addstrings.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md)   
 [CToolBarCtrl::DeleteButton](../vs140/ctoolbarctrl--deletebutton.md)   
 [CToolBarCtrl::AddBitmap](../vs140/ctoolbarctrl--addbitmap.md)   
 [CToolBarCtrl::AddString](../vs140/ctoolbarctrl--addstring.md)   
 [CToolBarCtrl::AddStrings](../vs140/ctoolbarctrl--addstrings.md)