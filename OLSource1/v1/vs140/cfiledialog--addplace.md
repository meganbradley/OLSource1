---
title: "CFileDialog::AddPlace"
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
  - "AddPlace"
  - "afxdlgs/CFileDialog::AddPlace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddPlace"
ms.assetid: 0adf4878-ee15-4344-b1aa-a19c6054fa37
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::AddPlace
Adds a folder to the list of places available for the user to open or save items.  
  
## Syntax  
  
```  
void AddPlace(  
   LPCWSTR lpszFolder,  
   FDAP fdap = FDAP_TOP  
) throw();  
void AddPlace(  
   IShellItem* psi,  
   FDAP fdap = FDAP_TOP  
) throw();  
```  
  
#### Parameters  
 `lpszFolder`  
 A path to the folder to be made available to the user. This can only be a folder.  
  
 `fdap`  
 Specifies where the folder is placed within the list.  
  
 `psi`  
 A pointer to an IShellItem that represents the folder to be made available to the user. This can only be a folder.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)