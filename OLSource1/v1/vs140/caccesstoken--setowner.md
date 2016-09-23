---
title: "CAccessToken::SetOwner"
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
  - ATL.CAccessToken.SetOwner
  - ATL::CAccessToken::SetOwner
  - CAccessToken.SetOwner
  - CAccessToken::SetOwner
  - SetOwner
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetOwner method
ms.assetid: 339d4b26-5476-4664-a832-37843d3c2de1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::SetOwner
Call this method to set the owner of the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool SetOwner(  
   const CSid& rSid  
) throw(...);  
```  
  
#### Parameters  
 `rSid`  
 The [CSid Class](../vs140/csid-class.md) object containing the owner information.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The owner is the default owner that is used for new objects created while this access token is in effect.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::GetOwner](../vs140/caccesstoken--getowner.md)