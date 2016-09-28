---
title: "CFileDialog::StartVisualGroup"
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
  - "StartVisualGroup"
  - "afxdlgs/CFileDialog::StartVisualGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StartVisualGroup"
ms.assetid: e5298c0b-0951-4de5-924d-e7533336f754
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::StartVisualGroup
Declares a visual group in the dialog. Subsequent calls to any "add" method add those elements to this group.  
  
## Syntax  
  
```  
HRESULT StartVisualGroup(  
   DWORD dwIDCtl,  
   const CString& strLabel  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the visual group.  
  
 `strLabel`  
 The group name.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)