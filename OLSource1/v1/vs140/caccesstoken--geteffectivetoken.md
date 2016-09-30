---
title: "CAccessToken::GetEffectiveToken"
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
  - "CAccessToken::GetEffectiveToken"
  - "GetEffectiveToken"
  - "CAccessToken.GetEffectiveToken"
  - "ATL::CAccessToken::GetEffectiveToken"
  - "ATL.CAccessToken.GetEffectiveToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEffectiveToken method"
ms.assetid: 2b60e4c7-e97b-4078-a545-02db90717291
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::GetEffectiveToken
Call this method to get the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object equal to the access token in effect for the current thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)