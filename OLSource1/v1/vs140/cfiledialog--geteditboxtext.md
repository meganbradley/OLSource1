---
title: "CFileDialog::GetEditBoxText"
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
  - "afxdlgs/CFileDialog::GetEditBoxText"
  - "GetEditBoxText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEditBoxText"
ms.assetid: b581bd76-a461-4276-bade-c2bf6a8f6554
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::GetEditBoxText
Retrieves the current text in an edit box control.  
  
## Syntax  
  
```  
HRESULT GetEditBoxText(  
   DWORD dwIDCtl,  
   CString& strText  
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