---
title: "CComObjectRootEx::OuterAddRef"
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
  - "CComObjectRootEx::OuterAddRef"
  - "CComObjectRootEx.OuterAddRef"
  - "OuterAddRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OuterAddRef method"
ms.assetid: b9d75243-df9b-4515-9586-c0dc0840006e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::OuterAddRef
Increments the reference count of the outer unknown of an aggregation.  
  
## Syntax  
  
```  
  
ULONG OuterAddRef( );  
```  
  
## Return Value  
 A value that may be useful for diagnostics and testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComObjectRootEx::OuterRelease](../vs140/ccomobjectrootex--outerrelease.md)   
 [CComObjectRootEx::OuterQueryInterface](../vs140/ccomobjectrootex--outerqueryinterface.md)