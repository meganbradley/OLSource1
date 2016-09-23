---
title: "CAccessToken::GetOwner"
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
  - CAccessToken::GetOwner
  - CAccessToken.GetOwner
  - ATL::CAccessToken::GetOwner
  - ATL.CAccessToken.GetOwner
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetOwner method
ms.assetid: 8cd9630f-9cbf-4f16-af73-8839d179a7eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::GetOwner
Call this method to get the owner associated with the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool GetOwner(  
   CSid* pSid  
) const throw(...);  
```  
  
#### Parameters  
 `pSid`  
 Pointer to a [CSid Class](../vs140/csid-class.md) object.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The owner is set by default on any objects created while this access token is in effect.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::SetOwner](../vs140/caccesstoken--setowner.md)