---
title: "CComObject::AddRef"
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
  - "CComObject.AddRef"
  - "CComObject::AddRef"
  - "AddRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddRef method [ATL]"
  - "AddRef method [C++], object syntax"
ms.assetid: e0b3606b-fa19-49b1-9d62-4f6429f4128e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObject::AddRef
Increments the reference count on the object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
## Return Value  
 This function returns the new incremented reference count on the object. This value may be useful for diagnostics or testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObject Class](../vs140/ccomobject-class.md)   
 [CComObject::Release](../vs140/ccomobject--release.md)