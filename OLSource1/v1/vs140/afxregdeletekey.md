---
title: "AfxRegDeleteKey"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AfxRegDeleteKey
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxRegDeleteKey
ms.assetid: e3a84673-bb2e-4e42-9ec6-0825d42d416c
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxRegDeleteKey
Deletes the specified registry key.  
  
## Syntax  
  
```  
LONG AFXAPI AfxRegDeleteKey(HKEY hKey, LPCTSTR lpSubKey, CAtlTransactionManager* pTM = NULL);  
```  
  
#### Parameters  
 `hKey`  
 A handle to an open registry key.  
  
 `lpSubKey`  
 The name of the key to be deleted.  
  
 `pTM`  
 Pointer to a `CAtlTransactionManager` object.  
  
## Return Value  
 If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is a nonzero error code defined in Winerror.h.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpriv.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)