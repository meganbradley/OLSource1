---
title: "CAtlTransactionManager::RegOpenKeyEx"
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
  - "atltransactionmanager/CAtlTransactionManager::RegOpenKeyEx"
  - "RegOpenKeyEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegOpenKeyEx"
ms.assetid: 9a82f305-1a44-42ca-9db3-2d298f59f0a7
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::RegOpenKeyEx
Opens the specified registry key and associates it with a transaction.  
  
## Syntax  
  
```  
inline LSTATUS CAtlTransactionManager::RegOpenKeyEx(  
   HKEY hKey,  
   LPCTSTR lpSubKey,  
   DWORD ulOptions,  
   REGSAM samDesired,  
   PHKEY phkResult  
);  
```  
  
#### Parameters  
 `hKey`  
 A handle to an open registry key.  
  
 `lpSubKey`  
 The name of the registry subkey to be opened.  
  
 `ulOptions`  
 This parameter is reserved and must be zero.  
  
 `samDesired`  
 A mask that specifies the access rights for the key.  
  
 `phkResult`  
 A pointer to a variable that receives a handle to the opened or created key. If the key is not one of the predefined registry keys, call the `RegCloseKey` function after you have finished using the handle.  
  
## Return Value  
 If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is a nonzero error code defined in Winerror.h  
  
## Remarks  
 This wrapper calls the `RegOpenKeyTransacted` function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)