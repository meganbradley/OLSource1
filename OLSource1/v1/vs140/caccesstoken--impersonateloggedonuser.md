---
title: "CAccessToken::ImpersonateLoggedOnUser"
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
  - "ATL.CAccessToken.ImpersonateLoggedOnUser"
  - "ImpersonateLoggedOnUser"
  - "CAccessToken.ImpersonateLoggedOnUser"
  - "ATL::CAccessToken::ImpersonateLoggedOnUser"
  - "CAccessToken::ImpersonateLoggedOnUser"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ImpersonateLoggedOnUser method"
ms.assetid: 6517b837-1b1b-42d8-bcb2-d06899efedcd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::ImpersonateLoggedOnUser
Call this method to allow the calling thread to impersonate the security context of a logged-on user.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
  
> [!IMPORTANT]
>  If a call to an impersonation function fails for any reason, the client is not impersonated and the client request is made in the security context of the process from which the call was made. If the process is running as a highly privileged account, or as a member of an administrative group, the user might be able to perform actions he or she would otherwise be disallowed. Therefore, the return value for this function should always be confirmed.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::LoadUserProfile](../vs140/caccesstoken--loaduserprofile.md)   
 [CAccessToken::LogonUser](../vs140/caccesstoken--logonuser.md)