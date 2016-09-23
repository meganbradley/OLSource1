---
title: "CAccessToken::HKeyCurrentUser"
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
  - CAccessToken::HKeyCurrentUser
  - ATL.CAccessToken.HKeyCurrentUser
  - HKeyCurrentUser
  - ATL::CAccessToken::HKeyCurrentUser
  - CAccessToken.HKeyCurrentUser
dev_langs: 
  - C++
helpviewer_keywords: 
  - HKeyCurrentUser method
ms.assetid: 393cd679-aa77-4f71-8dec-67bb9beb6652
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::HKeyCurrentUser
Call this method to get the handle pointing to the user profile associated with the `CAccessToken` object.  
  
## Syntax  
  
```  
  
HKEY HKeyCurrentUser( ) const throw( );  
  
```  
  
## Return Value  
 Returns a handle pointing to the user profile, or NULL if no profile exists.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::LoadUserProfile](../vs140/caccesstoken--loaduserprofile.md)