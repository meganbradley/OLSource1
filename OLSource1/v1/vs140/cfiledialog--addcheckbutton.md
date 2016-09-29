---
title: "CFileDialog::AddCheckButton"
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
  - "afxdlgs/CFileDialog::AddCheckButton"
  - "AddCheckButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCheckButton"
ms.assetid: 40493071-505c-41c9-b057-80d3cf27ea81
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::AddCheckButton
Adds a check button to the dialog.  
  
## Syntax  
  
```  
HRESULT AddCheckButton(  
   DWORD dwIDCtl,  
   const CString& strLabel,  
   BOOL bChecked  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the check button to add.  
  
 `strLabel`  
 The check button name.  
  
 `bChecked`  
 A Boolean indicating the current state of the check button. `TRUE` if checked; `FALSE` otherwise  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)