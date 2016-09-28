---
title: "AfxRegisterPreviewHandler"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxRegisterPreviewHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxRegisterPreviewHandler"
ms.assetid: 9917ac6c-505d-4f43-89a7-437f9b11e8c4
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxRegisterPreviewHandler
A helper to register a preview handler.  
  
## Syntax  
  
```  
BOOL AFXAPI AfxRegisterPreviewHandler(LPCTSTR lpszCLSID, LPCTSTR lpszShortTypeName, LPCTSTR lpszFilterExt);  
```  
  
#### Parameters  
 `lpszCLSID`  
 Specifies the CLSID of handler.  
  
 `lpszShortTypeName`  
 Specifies the ProgID of handler.  
  
 `lpszFilterExt`  
 Specifies the file extension registered with this handler.  
  
## Return Value  
  
## Remarks  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)