---
title: "CAccessToken::GetPrivileges"
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
  - "CAccessToken::GetPrivileges"
  - "GetPrivileges"
  - "ATL.CAccessToken.GetPrivileges"
  - "CAccessToken.GetPrivileges"
  - "ATL::CAccessToken::GetPrivileges"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPrivileges method"
ms.assetid: b94ae26a-2545-4d28-9eec-a81daf182b61
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::GetPrivileges
Call this method to get the privileges associated with the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool GetPrivileges(  
   CTokenPrivileges* pPrivileges  
) const throw(...);  
```  
  
#### Parameters  
 `pPrivileges`  
 Pointer to a [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md) object which will receive the privileges.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)