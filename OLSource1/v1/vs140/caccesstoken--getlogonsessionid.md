---
title: "CAccessToken::GetLogonSessionId"
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
  - GetLogonSessionId
  - ATL.CAccessToken.GetLogonSessionId
  - CAccessToken::GetLogonSessionId
  - CAccessToken.GetLogonSessionId
  - ATL::CAccessToken::GetLogonSessionId
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetLogonSessionId method
ms.assetid: b09395b7-a734-45d2-be83-f7fcf2ca82ec
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::GetLogonSessionId
Call this method to get the Logon Session ID associated with the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool GetLogonSessionId(  
   LUID* pluid  
) const throw(...);  
```  
  
#### Parameters  
 `pluid`  
 Pointer to a [LUID](http://msdn.microsoft.com/library/windows/desktop/aa379261) which will receive the Logon Session ID.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 In debug builds, an assertion error will occur if `pluid` is an invalid value.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)