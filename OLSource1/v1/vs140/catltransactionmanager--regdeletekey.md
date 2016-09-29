---
title: "CAtlTransactionManager::RegDeleteKey"
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
  - "RegDeleteKeyEx"
  - "atltransactionmanager/CAtlTransactionManager::RegDeleteKeyEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegDeleteKeyEx"
ms.assetid: dd040152-9d2f-4b5b-892d-d5de99b18974
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::RegDeleteKey
Deletes a subkey and its values from the specified platform-specific view of the registry as a transacted operation.  
  
## Syntax  
  
```  
inline LSTATUS CAtlTransactionManager::RegDeleteKeyEx(  
   HKEY hKey,  
   LPCTSTR lpSubKey  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`hKey`|A handle to an open registry key.|  
|`lpSubKey`|The name of the key to be deleted.|  
  
## Return Value  
 If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is a nonzero error code defined in Winerror.h.  
  
## Remarks  
 This wrapper calls the `RegDeleteKeyTransacted` function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)