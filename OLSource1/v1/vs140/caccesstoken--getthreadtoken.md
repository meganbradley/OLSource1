---
title: "CAccessToken::GetThreadToken"
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
  - "ATL::CAccessToken::GetThreadToken"
  - "ATL.CAccessToken.GetThreadToken"
  - "GetThreadToken"
  - "CAccessToken::GetThreadToken"
  - "CAccessToken.GetThreadToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetThreadToken method"
ms.assetid: 90c02ec1-748b-42be-96ab-e89839beb65b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::GetThreadToken
Call this method to initialize the `CAccessToken` with the token from the given thread.  
  
## Syntax  
  
```  
  
      bool GetThreadToken(  
   DWORD dwDesiredAccess,  
   HANDLE hThread = NULL,  
   bool bOpenAsSelf = true   
) throw( );  
```  
  
#### Parameters  
 `dwDesiredAccess`  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 `hThread`  
 Handle to the thread whose access token is opened.  
  
 `bOpenAsSelf`  
 Indicates whether the access check is to be made against the security context of the thread calling the `GetThreadToken` method or against the security context of the process for the calling thread.  
  
 If this parameter is false, the access check is performed using the security context for the calling thread. If the thread is impersonating a client, this security context can be that of a client process. If this parameter is true, the access check is made using the security context of the process for the calling thread.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [OpenThreadToken](http://msdn.microsoft.com/library/windows/desktop/aa379296)