---
title: "CAutoRevertImpersonation::~CAutoRevertImpersonation"
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
  - "CAutoRevertImpersonation::~CAutoRevertImpersonation"
  - "~CAutoRevertImpersonation"
  - "ATL::CAutoRevertImpersonation::~CAutoRevertImpersonation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoRevertImpersonation class, destructor"
  - "~CAutoRevertImpersonation destructor"
ms.assetid: 741b4a9f-2741-4a9b-846e-c6f4670b5d11
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoRevertImpersonation::~CAutoRevertImpersonation
Destroys the object and reverts access token impersonation.  
  
## Syntax  
  
```  
  
~CAutoRevertImpersonation() throw( );  
  
```  
  
## Remarks  
 Reverts any impersonation currently in effect for the [CAccessToken](../vs140/caccesstoken-class.md) object provided either at construction or through the [Attach](../vs140/cautorevertimpersonation--attach.md) method. If no `CAccessToken` is associated, the destructor has no effect.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md)   
 [CAccessToken Class](../vs140/caccesstoken-class.md)