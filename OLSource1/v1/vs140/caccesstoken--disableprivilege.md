---
title: "CAccessToken::DisablePrivilege"
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
  - "CAccessToken::DisablePrivilege"
  - "ATL::CAccessToken::DisablePrivilege"
  - "CAccessToken.DisablePrivilege"
  - "DisablePrivilege"
  - "ATL.CAccessToken.DisablePrivilege"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DisablePrivilege method"
ms.assetid: d2dc3a61-dc79-423d-9a30-090065a6bdb4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::DisablePrivilege
Call this method to disable a privilege in the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool DisablePrivilege(  
   LPCTSTR pszPrivilege,  
   CTokenPrivileges* pPreviousState = NULL  
) throw(...);  
```  
  
#### Parameters  
 `pszPrivilege`  
 Pointer to a string containing the privilege to disable in the `CAccessToken` object.  
  
 `pPreviousState`  
 Pointer to a `CTokenPrivileges` object which will contain the previous state of the privileges.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::DisablePrivileges](../vs140/caccesstoken--disableprivileges.md)   
 [CAccessToken::EnablePrivilege](../vs140/caccesstoken--enableprivilege.md)