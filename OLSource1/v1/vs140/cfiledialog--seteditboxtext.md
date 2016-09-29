---
title: "CFileDialog::SetEditBoxText"
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
  - "SetEditBoxText"
  - "afxdlgs/CFileDialog::SetEditBoxText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetEditBoxText"
ms.assetid: b23c1917-afc9-4f0f-9d60-50e0ad1050a0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::SetEditBoxText
Sets the current text in an edit box control.  
  
## Syntax  
  
```  
HRESULT SetEditBoxText(  
   DWORD dwIDCtl,  
   const CString& strText  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the edit box.  
  
 `strText`  
 The text value.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)