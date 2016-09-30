---
title: "CAccessToken::LogonUser"
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
  - "LogonUser"
  - "ATL::CAccessToken::LogonUser"
  - "CAccessToken::LogonUser"
  - "CAccessToken.LogonUser"
  - "ATL.CAccessToken.LogonUser"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LogonUser method"
ms.assetid: 967680e0-934b-4586-b2ee-975745f5af68
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::LogonUser
Call this method to create a logon session for the user associated with the given credentials.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the user name. This is the name of the user account to log on to.  
  
 *pszDomain*  
 Pointer to a null-terminated string that specifies the name of the domain or server whose account database contains the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> account.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the clear-text password for the user account specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 *dwLogonType*  
 Specifies the type of logon operation to perform. See [LogonUser](http://msdn.microsoft.com/library/windows/desktop/aa378184) for more details.  
  
 *dwLogonProvider*  
 Specifies the logon provider. See [LogonUser](http://msdn.microsoft.com/library/windows/desktop/aa378184) for more details.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The access token resulting from the logon will be associated with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For this method to succeed, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object must hold SE_TCB_NAME privileges, identifying the holder as part of the trusted computer base. See [LogonUser](http://msdn.microsoft.com/library/windows/desktop/aa378184) for more information regarding the privileges required.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::ImpersonateLoggedOnUser](../vs140/caccesstoken--impersonateloggedonuser.md)