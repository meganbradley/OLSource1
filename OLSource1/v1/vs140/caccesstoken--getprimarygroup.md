---
title: "CAccessToken::GetPrimaryGroup"
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
  - GetPrimaryGroup
  - CAccessToken.GetPrimaryGroup
  - CAccessToken::GetPrimaryGroup
  - ATL::CAccessToken::GetPrimaryGroup
  - ATL.CAccessToken.GetPrimaryGroup
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPrimaryGroup method
ms.assetid: ea7cdadf-0092-4abe-a078-3f7ca50fc7a6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::GetPrimaryGroup
Call this method to get the primary group associated with the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool GetPrimaryGroup(  
   CSid* pSid  
) const throw(...);  
```  
  
#### Parameters  
 `pSid`  
 Pointer to a [CSid Class](../vs140/csid-class.md) object.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The group is set by default on any objects created while this access token is in effect.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::SetPrimaryGroup](../vs140/caccesstoken--setprimarygroup.md)