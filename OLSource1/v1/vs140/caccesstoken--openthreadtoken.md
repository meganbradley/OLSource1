---
title: "CAccessToken::OpenThreadToken"
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
  - "CAccessToken::OpenThreadToken"
  - "CAccessToken.OpenThreadToken"
  - "ATL::CAccessToken::OpenThreadToken"
  - "OpenThreadToken"
  - "ATL.CAccessToken.OpenThreadToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenThreadToken method"
ms.assetid: 4dfbf21e-82cf-4aae-be47-570f8453e620
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::OpenThreadToken
Call this method to set the impersonation level and then initialize the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with the token from the given thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If true, the thread will be left at the requested impersonation level after this method completes. If false, the thread will revert to its original impersonation level.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Indicates whether the access check is to be made against the security context of the thread calling the [GetThreadToken](http://msdn.microsoft.com/library/windows/desktop/ms683182) method or against the security context of the process for the calling thread.  
  
 If this parameter is false, the access check is performed using the security context for the calling thread. If the thread is impersonating a client, this security context can be that of a client process. If this parameter is true, the access check is made using the security context of the process for the calling thread.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies a [SECURITY_IMPERSONATION_LEVEL](http://msdn.microsoft.com/library/windows/desktop/aa379572) enumerated type that supplies the impersonation level of the token.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is similar to [CAccessToken::GetThreadToken](../vs140/caccesstoken--getthreadtoken.md), but sets the impersonation level before initializing the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from the thread's access token.  
  
 The [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md) can be used to automatically revert impersonated access tokens created by setting the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> flag to *true*.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::GetThreadToken](../vs140/caccesstoken--getthreadtoken.md)