---
title: "CAccessToken::GetTokenId"
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
  - CAccessToken.GetTokenId
  - GetTokenId
  - CAccessToken::GetTokenId
  - ATL.CAccessToken.GetTokenId
  - ATL::CAccessToken::GetTokenId
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTokenId method
ms.assetid: 74b03368-f720-4e15-8e0d-c7b6090f0cf8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::GetTokenId
Call this method to get the Token ID associated with the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool GetTokenId(  
   LUID* pluid  
) const throw(...);  
```  
  
#### Parameters  
 `pluid`  
 Pointer to a [LUID](http://msdn.microsoft.com/library/windows/desktop/aa379261) which will receive the Token ID.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)