---
title: "CAccessToken::OpenNamedPipeClientToken"
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
  - "CAccessToken.OpenNamedPipeClientToken"
  - "ATL::CAccessToken::OpenNamedPipeClientToken"
  - "CAccessToken::OpenNamedPipeClientToken"
  - "OpenNamedPipeClientToken"
  - "ATL.CAccessToken.OpenNamedPipeClientToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenNamedPipeClientToken method"
ms.assetid: 58e8ec1b-7673-49ea-9068-4b395eb488f4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::OpenNamedPipeClientToken
Call this method from within a server taking requests over a named pipe to initialize the `CAccessToken` with the access token from the client.  
  
## Syntax  
  
```  
  
      bool OpenNamedPipeClientToken(  
   HANDLE hPipe,  
   DWORD dwDesiredAccess,  
   bool bImpersonate = false,  
   bool bOpenAsSelf = true  
) throw(...);  
```  
  
#### Parameters  
 *hPipe*  
 Handle to a named pipe.  
  
 `dwDesiredAccess`  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 `bImpersonate`  
 If true, the current thread will impersonate the calling pipe client if this call completes successfully. If false, the access token will be opened, but the thread will not have an impersonation token when this call completes.  
  
 `bOpenAsSelf`  
 Indicates whether the access check is to be made against the security context of the thread calling the [GetThreadToken](http://msdn.microsoft.com/library/windows/desktop/ms683182) method or against the security context of the process for the calling thread.  
  
 If this parameter is false, the access check is performed using the security context for the calling thread. If the thread is impersonating a client, this security context can be that of a client process. If this parameter is true, the access check is made using the security context of the process for the calling thread.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md) can be used to automatically revert impersonated access tokens created by setting the `bImpersonate` flag to *true*.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::OpenCOMClientToken](../vs140/caccesstoken--opencomclienttoken.md)   
 [CAccessToken::OpenRPCClientToken](../vs140/caccesstoken--openrpcclienttoken.md)