---
title: "CComCachedTearOffObject::m_contained"
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
  - "CComCachedTearOffObject.m_contained"
  - "ATL::CComCachedTearOffObject::m_contained"
  - "CComCachedTearOffObject::m_contained"
  - "ATL::CComCachedTearOffObject<contained>::m_contained"
  - "m_contained"
  - "ATL.CComCachedTearOffObject.m_contained"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_contained"
ms.assetid: 425023b3-c2f8-4cc3-ae10-9a26f169a636
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCachedTearOffObject::m_contained
A [CComContainedObject](../vs140/ccomcontainedobject-class.md) object derived from your tear-off class.  
  
## Syntax  
  
```  
  
CcomContainedObject <  
contained  
> m_contained;  
```  
  
#### Parameters  
 `contained`  
 [in] Your tear-off class, derived from `CComTearOffObjectBase` and the interfaces you want your tear-off object to support.  
  
## Remarks  
 The methods `m_contained` inherits are used to access the tear-off interface in your tear-off class through the cached tear-off object's `QueryInterface`, `FinalConstruct`, and `FinalRelease`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCachedTearOffObject Class](../vs140/ccomcachedtearoffobject-class.md)   
 [CComTearOffObject Class](../vs140/ccomtearoffobject-class.md)