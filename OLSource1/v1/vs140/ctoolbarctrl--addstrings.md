---
title: "CToolBarCtrl::AddStrings"
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
  - "AddStrings"
  - "CToolBarCtrl.AddStrings"
  - "CToolBarCtrl::AddStrings"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddStrings method"
ms.assetid: c23992a2-8fdf-4a5f-8b86-2bed94b3cd68
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::AddStrings
Adds a new string or strings to the list of strings available for a toolbar control.  
  
## Syntax  
  
```  
  
      int AddStrings(  
   LPCTSTR lpszStrings   
);  
```  
  
#### Parameters  
 *lpszStrings*  
 Address of a buffer that contains one or more null-terminated strings to add to the toolbar's string list. The last string must be terminated with two null characters.  
  
## Return Value  
 The zero-based index of the first new string added if successful; otherwise –1.  
  
## Remarks  
 Strings in the buffer must be separated by a null character. You must ensure that the last string has two null terminators. To properly format a constant string, you might write it as:  
  
 [!code[NVC_MFCControlLadenDialog#72](../vs140/codesnippet/CPP/ctoolbarctrl--addstrings_1.cpp)]  
  
 or:  
  
 [!code[NVC_MFCControlLadenDialog#73](../vs140/codesnippet/CPP/ctoolbarctrl--addstrings_2.cpp)]  
  
 You should not pass a `CString` object to this function since it is not possible to have more than one null character in a `CString`.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::AddString](../vs140/ctoolbarctrl--addstring.md)   
 [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md)   
 [CToolBarCtrl::InsertButton](../vs140/ctoolbarctrl--insertbutton.md)   
 [CToolBarCtrl::AddBitmap](../vs140/ctoolbarctrl--addbitmap.md)