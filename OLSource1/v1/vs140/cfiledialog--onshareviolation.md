---
title: "CFileDialog::OnShareViolation"
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
  - CFileDialog.OnShareViolation
  - OnShareViolation
  - CFileDialog::OnShareViolation
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnShareViolation method
  - CFileDialog class, protected operations
ms.assetid: 21039c0a-c03f-4008-b691-35f0a9ddbc09
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileDialog::OnShareViolation
Override this function to provide custom handling of share violations.  
  
## Syntax  
  
```  
  
      virtual UINT OnShareViolation(  
   LPCTSTR lpszPathName   
);  
```  
  
#### Parameters  
 `lpszPathName`  
 The path of the file on which the share violation occurred.  
  
## Return Value  
 One of the following values:  
  
-   **OFN_SHAREFALLTHROUGH** The filename is returned from the dialog box.  
  
-   **OFN_SHARENOWARN** No further action needs to be taken.  
  
-   **OFN_SHAREWARN** The user receives the standard warning message for this error.  
  
## Remarks  
 Normally, you do not need to use this function because the framework provides default checking of share violations and displays a message box if a share violation occurs.  
  
 If you want to disable share violation checking, use the bitwise OR operator to combine the flag **OFN_SHAREAWARE** with `m_ofn.Flags`.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::OnFileNameOK](../vs140/cfiledialog--onfilenameok.md)