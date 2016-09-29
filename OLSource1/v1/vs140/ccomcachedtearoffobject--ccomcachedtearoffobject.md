---
title: "CComCachedTearOffObject::CComCachedTearOffObject"
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
  - "CComCachedTearOffObject.CComCachedTearOffObject"
  - "ATL::CComCachedTearOffObject::CComCachedTearOffObject"
  - "CComCachedTearOffObject::CComCachedTearOffObject"
  - "ATL.CComCachedTearOffObject.CComCachedTearOffObject"
  - "CComCachedTearOffObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComCachedTearOffObject constructor"
  - "CComCachedTearOffObject class, constructor"
ms.assetid: ee80eb8e-7983-4d48-bd33-b097cb232265
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCachedTearOffObject::CComCachedTearOffObject
The constructor.  
  
## Syntax  
  
```  
  
      CComCachedTearOffObject(  
   void* pv   
);  
```  
  
#### Parameters  
 `pv`  
 [in] Pointer to the **IUnknown** of the `CComCachedTearOffObject`.  
  
## Remarks  
 Initializes the `CComContainedObject` member, [m_contained](../vs140/ccomcachedtearoffobject--m_contained.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCachedTearOffObject Class](../vs140/ccomcachedtearoffobject-class.md)   
 [CComTearOffObject Class](../vs140/ccomtearoffobject-class.md)