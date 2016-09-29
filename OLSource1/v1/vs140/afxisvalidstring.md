---
title: "AfxIsValidString"
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
  - "AFX/AfxIsValidString"
  - "AfxIsValidString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxIsValidString function"
ms.assetid: 11c8b14f-0b1a-4717-882c-843efbdbf4ac
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxIsValidString
Use this function to determine whether a pointer to a string is valid.  
  
## Syntax  
  
```  
  
      BOOL AfxIsValidString(  
   LPCSTR lpsz,  
   int nLength = -1   
);   
```  
  
#### Parameters  
 `lpsz`  
 The pointer to test.  
  
 `nLength`  
 Specifies the length of the string to be tested, in bytes. A value of –1 indicates that the string will be null-terminated.  
  
## Return Value  
 In debug builds, nonzero if the specified pointer points to a string of the specified size; otherwise 0.  
  
 In non-debug builds, nonzero if `lpsz` is not NULL; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_Utilities#29](../vs140/codesnippet/CPP/afxisvalidstring_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxIsMemoryBlock](../vs140/afxismemoryblock.md)   
 [AfxIsValidAddress](../vs140/afxisvalidaddress.md)