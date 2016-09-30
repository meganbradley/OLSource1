---
title: "CAccessToken::CreateImpersonationToken"
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
  - "CreateImpersonationToken"
  - "ATL.CAccessToken.CreateImpersonationToken"
  - "CAccessToken::CreateImpersonationToken"
  - "CAccessToken.CreateImpersonationToken"
  - "ATL::CAccessToken::CreateImpersonationToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateImpersonationToken method"
ms.assetid: 235f1c1c-50c1-49ba-8b0b-c5b46f5de27b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::CreateImpersonationToken
Call this method to create an impersonation access token.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the new <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies a [SECURITY_IMPERSONATION_LEVEL](http://msdn.microsoft.com/library/windows/desktop/aa379572) enumerated type that supplies the impersonation level of the new token.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> calls [DuplicateToken](http://msdn.microsoft.com/library/windows/desktop/aa446616) to create a new impersonation token.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::CreatePrimaryToken](../vs140/caccesstoken--createprimarytoken.md)   
 [CAccessToken::CreateRestrictedToken](../vs140/caccesstoken--createrestrictedtoken.md)   
 [CAccessToken::Revert](../vs140/caccesstoken--revert.md)