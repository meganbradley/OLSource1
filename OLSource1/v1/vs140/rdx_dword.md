---
title: "RDX_DWORD"
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
  - ATL.RDX_DWORD
  - ATL::RDX_DWORD
  - RDX_DWORD
dev_langs: 
  - C++
helpviewer_keywords: 
  - RDX_DWORD macro
ms.assetid: 1e7d4888-284f-4fe7-99de-5f193af19c4d
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# RDX_DWORD
Associates the specified registry entry with a specified member variable of type DWORD.  
  
## Syntax  
  
```  
  
      RDX_DWORD(   
   rootkey,   
   subkey,   
   valuename,   
   member,   
   member_size    
)  
```  
  
#### Parameters  
 `rootkey`  
 The registry key root.  
  
 `subkey`  
 The registry subkey.  
  
 `valuename`  
 The registry key.  
  
 `member`  
 The member variable to associate with the specified registry entry.  
  
 `member_size`  
 The size, in bytes, of the member variable.  
  
## Remarks  
 This macro is used in conjunction with the `BEGIN_RDX_MAP` and `END_RDX_MAP` macros to associate a member variable with a given registry entry. The global function [RegistryDataExchange](../vs140/registrydataexchange.md), or the member function of the same name created by the `BEGIN_RDX_MAP` and `END_RDX_MAP` macros, should be used to perform exchange of data between the system registry and the member variables in the RDX map.  
  
## Requirements  
 **Header:** atlplus.h  
  
## See Also  
 [Registry Data Exchange Macros](../vs140/registry-data-exchange-macros.md)