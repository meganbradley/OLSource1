---
title: "CAccessToken::CreatePrimaryToken"
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
  - "CAccessToken.CreatePrimaryToken"
  - "CAccessToken::CreatePrimaryToken"
  - "ATL.CAccessToken.CreatePrimaryToken"
  - "ATL::CAccessToken::CreatePrimaryToken"
  - "CreatePrimaryToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePrimaryToken method"
ms.assetid: daa8f39e-9262-46f5-bdb2-72aa0b680e4a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::CreatePrimaryToken
Call this method to create a new primary token.  
  
## Syntax  
  
```  
  
      bool CreatePrimaryToken(  
   CAccessToken* pPri,  
   DWORD dwDesiredAccess = MAXIMUM_ALLOWED,  
   const CSecurityAttributes* pTokenAttributes = NULL  
) const throw(...);  
```  
  
#### Parameters  
 *pPri*  
 Pointer to the new `CAccessToken` object.  
  
 `dwDesiredAccess`  
 Specifies the requested access rights for the new token. The default, MAXIMUM_ALLOWED, requests all access rights that are valid for the caller. See [Access Rights and Access Masks](http://msdn.microsoft.com/library/windows/desktop/aa374902) for more on access rights.  
  
 *pTokenAttributes*  
 Pointer to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that specifies a security descriptor for the new token and determines whether child processes can inherit the token. If *pTokenAttributes* is NULL, the token gets a default security descriptor and the handle cannot be inherited.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 `CreatePrimaryToken` calls [DuplicateTokenEx](http://msdn.microsoft.com/library/windows/desktop/aa446617) to create a new primary token.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::CreateImpersonationToken](../vs140/caccesstoken--createimpersonationtoken.md)   
 [CAccessToken::CreateRestrictedToken](../vs140/caccesstoken--createrestrictedtoken.md)