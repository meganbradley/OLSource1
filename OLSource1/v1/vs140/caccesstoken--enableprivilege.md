---
title: "CAccessToken::EnablePrivilege"
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
  - "CAccessToken::EnablePrivilege"
  - "CAccessToken.EnablePrivilege"
  - "EnablePrivilege"
  - "ATL::CAccessToken::EnablePrivilege"
  - "ATL.CAccessToken.EnablePrivilege"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnablePrivilege method"
ms.assetid: 40dd5620-68e8-4f70-9de6-607746424c57
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::EnablePrivilege
Call this method to enable a privilege in the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool EnablePrivilege(  
   LPCTSTR pszPrivilege,  
   CTokenPrivileges* pPreviousState = NULL  
) throw(...);  
```  
  
#### Parameters  
 `pszPrivilege`  
 Pointer to a string containing the privilege to enable in the `CAccessToken` object.  
  
 `pPreviousState`  
 Pointer to a `CTokenPrivileges` object which will contain the previous state of the privileges.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::EnablePrivileges](../vs140/caccesstoken--enableprivileges.md)   
 [CAccessToken::DisablePrivilege](../vs140/caccesstoken--disableprivilege.md)