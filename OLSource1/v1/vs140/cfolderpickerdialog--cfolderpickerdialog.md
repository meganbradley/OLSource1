---
title: "CFolderPickerDialog::CFolderPickerDialog"
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
  - afxdlgs/CFolderPickerDialog::CFolderPickerDialog
  - CFolderPickerDialog
dev_langs: 
  - C++
helpviewer_keywords: 
  - CFolderPickerDialog, constructor
ms.assetid: e6781636-ba38-40d2-bfb5-28835eb3fedf
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFolderPickerDialog::CFolderPickerDialog
Constructor.  
  
## Syntax  
  
```  
explicit CFolderPickerDialog(  
   LPCTSTR lpszFolder = NULL,  
   DWORD dwFlags = 0,  
   CWnd* pParentWnd = NULL,  
   DWORD dwSize = 0  
);  
```  
  
#### Parameters  
 `lpszFolder`  
 Initial folder.  
  
 `dwFlags`  
 A combination of one or more flags that allow you to customize the dialog box.  
  
 `pParentWnd`  
 A pointer to the dialog box object's parent or owner window.  
  
 `dwSize`  
 The size of the OPENFILENAME structure.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFolderPickerDialog Class](../vs140/cfolderpickerdialog-class.md)