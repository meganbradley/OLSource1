---
title: "CAccessToken::GetImpersonationLevel"
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
  - GetImpersonationLevel
  - ATL::CAccessToken::GetImpersonationLevel
  - CAccessToken.GetImpersonationLevel
  - CAccessToken::GetImpersonationLevel
  - ATL.CAccessToken.GetImpersonationLevel
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetImpersonationLevel method
ms.assetid: fb80a522-cee2-4855-9a17-3e92a05ab026
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::GetImpersonationLevel
Call this method to get the impersonation level from the access token.  
  
## Syntax  
  
```  
  
      bool GetImpersonationLevel(  
   SECURITY_IMPERSONATION_LEVEL* pImpersonationLevel  
) const throw(...);  
```  
  
#### Parameters  
 *pImpersonationLevel*  
 Pointer to a [SECURITY_IMPERSONATION_LEVEL](http://msdn.microsoft.com/library/windows/desktop/aa379572) enumeration type which will receive the impersonation level information.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)