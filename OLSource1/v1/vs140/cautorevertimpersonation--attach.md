---
title: "CAutoRevertImpersonation::Attach"
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
  - CAutoRevertImpersonation::Attach
  - ATL::CAutoRevertImpersonation::Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method [ATL]
ms.assetid: 57944c5b-5394-43ee-83cb-8743e9b01141
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAutoRevertImpersonation::Attach
Automates the impersonation reversion of an access token.  
  
## Syntax  
  
```  
  
      void Attach(   
   const CAccessToken* pAT   
) throw( );  
```  
  
#### Parameters  
 `pAT`  
 The address of the [CAccessToken](../vs140/caccesstoken-class.md) object to be reverted automatically  
  
## Remarks  
 This method should only be used if the [CAutoRevertImpersonation](../vs140/cautorevertimpersonation-class.md) object was created with a NULL `CAccessToken` pointer, or if [Detach](../vs140/cautorevertimpersonation--detach.md) was called previously. For simple cases, it is not necessary to use this method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md)   
 [CAccessToken Class](../vs140/caccesstoken-class.md)