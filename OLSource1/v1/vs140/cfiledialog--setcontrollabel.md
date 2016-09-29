---
title: "CFileDialog::SetControlLabel"
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
  - "afxdlgs/CFileDialog::SetControlLabel"
  - "SetControlLabel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetControlLabel"
ms.assetid: 7811a367-8d79-4b6e-98a7-c8db22b05aac
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::SetControlLabel
Sets the text associated with a control, such as button text or an edit box label.  
  
## Syntax  
  
```  
HRESULT SetControlLabel(  
   DWORD dwIDCtl,  
   const CString& strLabel  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the control.  
  
 `strLabel`  
 The control name.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)