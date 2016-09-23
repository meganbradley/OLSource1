---
title: "CAtlTransactionManager::RegCreateKeyEx"
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
  - atltransactionmanager/CAtlTransactionManager::RegCreateKeyEx
  - RegCreateKeyEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - RegCreateKeyEx
ms.assetid: 0155c744-be9a-4dda-a22f-434c3b9dc03a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlTransactionManager::RegCreateKeyEx
Creates the specified registry key and associates it with a transaction. If the key already exists, the function opens it.  
  
## Syntax  
  
```  
inline LSTATUS CAtlTransactionManager::RegCreateKeyEx(  
   HKEY hKey,  
   LPCTSTR lpSubKey,  
   DWORD dwReserved,  
   LPTSTR lpClass,  
   DWORD dwOptions,  
   REGSAM samDesired,  
   CONST LPSECURITY_ATTRIBUTES lpSecurityAttributes,  
   PHKEY phkResult,  
   LPDWORD lpdwDisposition  
);  
```  
  
#### Parameters  
 `hKey`  
 A handle to an open registry key.  
  
 `lpSubKey`  
 The name of a subkey that this function opens or creates.  
  
 `dwReserved`  
 This parameter is reserved and must be zero.  
  
 `lpClass`  
 The user-defined class of this key. This parameter may be ignored. This parameter can be NULL.  
  
 `dwOptions`  
 This parameter can be one of the following values: REG_OPTION_BACKUP_RESTORE, REG_OPTION_NON_VOLATILE, or REG_OPTION_VOLATILE.  
  
 `samDesired`  
 A mask that specifies the access rights for the key.  
  
 `lpSecurityAttributes`  
 Pointer to a SECURITY_ATTRIBUTES structure that determines whether the returned handle can be inherited by child processes. If `lpSecurityAttributes` is `NULL`, the handle cannot be inherited.  
  
 `phkResult`  
 A pointer to a variable that receives a handle to the opened or created key. If the key is not one of the predefined registry keys, call the `RegCloseKey` function after you have finished using the handle.  
  
 `lpdwDisposition`  
 A pointer to a variable that receives one of the following disposition values: REG_CREATED_NEW_KEY or REG_OPENED_EXISTING_KEY.  
  
## Return Value  
 If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is a nonzero error code defined in Winerror.h.  
  
## Remarks  
 This wrapper calls the `RegCreateKeyTransacted` function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)