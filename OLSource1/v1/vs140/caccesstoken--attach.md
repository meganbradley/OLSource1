---
title: "CAccessToken::Attach"
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
  - ATL::CAccessToken::Attach
  - CAccessToken::Attach
  - CAccessToken.Attach
  - ATL.CAccessToken.Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method [ATL]
ms.assetid: 440fcf21-6751-4b5d-b3a8-5c68b3bcaff1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::Attach
Call this method to take ownership of the given access token handle.  
  
## Syntax  
  
```  
  
      void Attach(  
   HANDLE hToken  
) throw( );  
```  
  
#### Parameters  
 *hToken*  
 A handle to the access token.  
  
## Remarks  
 In debug builds, an assertion error will occur if the `CAccessToken` object already has ownership of an access token.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::Detach](../vs140/caccesstoken--detach.md)