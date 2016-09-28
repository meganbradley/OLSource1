---
title: "CComObjectRootEx::m_dwRef"
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
  - "CComObjectRootEx.m_dwRef"
  - "CComObjectRootEx::m_dwRef"
  - "m_dwRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwRef"
ms.assetid: b26657e5-f806-475d-b8e4-f533bfcfadb2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::m_dwRef
Part of a union that accesses four bytes of memory.  
  
## Syntax  
  
```  
  
long m_dwRef;  
```  
  
## Remarks  
 With `m_pOuterUnknown`, part of a union:  
  
 `union`  
  
 `{`  
  
 `long m_dwRef;`  
  
 `IUnknown* m_pOuterUnknown;`  
  
 `};`  
  
 If the object is not aggregated, the reference count accessed by `AddRef` and **Release** is stored in `m_dwRef`. If the object is aggregated, the pointer to the outer unknown is stored in [m_pOuterUnknown](../vs140/ccomobjectrootex--m_pouterunknown.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)