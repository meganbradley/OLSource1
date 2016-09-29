---
title: "CAccessToken::CreateRestrictedToken"
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
  - "CreateRestrictedToken"
  - "ATL.CAccessToken.CreateRestrictedToken"
  - "ATL::CAccessToken::CreateRestrictedToken"
  - "CAccessToken::CreateRestrictedToken"
  - "CAccessToken.CreateRestrictedToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateRestrictedToken method"
ms.assetid: 7339344e-70de-4904-b9a3-ce77c0e3de95
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::CreateRestrictedToken
Call this method to create a new, restricted `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool CreateRestrictedToken(  
   CAccessToken* pRestrictedToken,  
   const CTokenGroups& SidsToDisable,  
   const CTokenGroups& SidsToRestrict,  
   const CTokenPrivileges& PrivilegesToDelete = CTokenPrivileges( )  
) const throw(...);  
```  
  
#### Parameters  
 *pRestrictedToken*  
 The new, restricted `CAccessToken` object.  
  
 `SidsToDisable`  
 A `CTokenGroups` object that specifies the deny-only SIDs.  
  
 *SidsToRestrict*  
 A `CTokenGroups` object that specifies the restricting SIDs.  
  
 `PrivilegesToDelete`  
 A `CTokenPrivileges` object that specifies the privileges to delete in the restricted token. The default creates an empty object.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 `CreateRestrictedToken` uses the [CreateRestrictedToken](http://msdn.microsoft.com/library/windows/desktop/aa446583) Win32 function to create a new `CAccessToken` object, with restrictions.  
  
> [!NOTE]
>  This method is only available on Windows 2000 or later.  
  
> [!IMPORTANT]
>  When using `CreateRestrictedToken`, ensure the following: the existing token is valid (and not entered by the user) and `SidsToDisable` and `PrivilegesToDelete` are both valid (and not entered by the user). If the method returns false, deny functionality.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::CreatePrimaryToken](../vs140/caccesstoken--createprimarytoken.md)   
 [CAccessToken::CreateImpersonationToken](../vs140/caccesstoken--createimpersonationtoken.md)