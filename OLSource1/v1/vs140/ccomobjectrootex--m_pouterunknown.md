---
title: "CComObjectRootEx::m_pOuterUnknown"
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
  - "m_pOuterUnknown"
  - "CComObjectRootEx::m_pOuterUnknown"
  - "CComObjectRootEx.m_pOuterUnknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pOuterUnknown"
ms.assetid: 3b924765-e280-44dc-87a3-937864d0060c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::m_pOuterUnknown
Part of a union that accesses four bytes of memory.  
  
## Syntax  
  
```  
  
IUnknown* m_pOuterUnknown;  
```  
  
## Remarks  
 With `m_dwRef`, part of a union:  
  
 `union`  
  
 `{`  
  
 `long m_dwRef;`  
  
 `IUnknown* m_pOuterUnknown;`  
  
 `};`  
  
 If the object is aggregated, the pointer to the outer unknown is stored in `m_pOuterUnknown`. If the object is not aggregated, the reference count accessed by `AddRef` and **Release** is stored in [m_dwRef](../vs140/ccomobjectrootex--m_dwref.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)