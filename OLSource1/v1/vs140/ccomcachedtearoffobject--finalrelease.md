---
title: "CComCachedTearOffObject::FinalRelease"
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
  - "CComCachedTearOffObject::FinalRelease"
  - "ATL::CComCachedTearOffObject::FinalRelease"
  - "FinalRelease"
  - "CComCachedTearOffObject.FinalRelease"
  - "ATL::CComCachedTearOffObject<contained>::FinalRelease"
  - "ATL.CComCachedTearOffObject.FinalRelease"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FinalRelease method"
ms.assetid: 7ed286b0-18cf-4e1a-aab0-c2f6da366ae4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCachedTearOffObject::FinalRelease
Calls **m_contained::FinalRelease** to free `m_contained`, the `CComContainedObject`<`contained`> object.  
  
## Syntax  
  
```  
  
void FinalRelease( );  
```  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCachedTearOffObject Class](../vs140/ccomcachedtearoffobject-class.md)   
 [CComCachedTearOffObject::FinalConstruct](../vs140/ccomcachedtearoffobject--finalconstruct.md)