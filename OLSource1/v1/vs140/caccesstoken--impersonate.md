---
title: "CAccessToken::Impersonate"
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
  - "ATL.CAccessToken.Impersonate"
  - "ATL::CAccessToken::Impersonate"
  - "Impersonate"
  - "CAccessToken.Impersonate"
  - "CAccessToken::Impersonate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Impersonate method"
ms.assetid: 3b79d270-4f56-45f0-9949-afe9555bc74e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::Impersonate
Call this method to assign an impersonation <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to a thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Handle to the thread to assign the impersonation token to. This handle must have been opened with TOKEN_IMPERSONATE access rights. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is NULL, the method causes the thread to stop using an impersonation token.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 In debug builds, an assertion error will occur if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not have a valid pointer to a token.  
  
 The [CAutoRevertImpersonation class](../vs140/cautorevertimpersonation-class.md) can be used to automatically revert impersonated access tokens.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)