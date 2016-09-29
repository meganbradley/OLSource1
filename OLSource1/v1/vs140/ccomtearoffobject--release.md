---
title: "CComTearOffObject::Release"
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
  - "CComTearOffObject::Release"
  - "CComTearOffObject.Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
ms.assetid: 92865da4-07e1-4235-9616-117fe0d3cd9d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComTearOffObject::Release
Decrements the reference count by one and, if the reference count is zero, deletes the `CComTearOffObject`.  
  
## Syntax  
  
```  
  
STDMETHOD_ULONG Release( );  
```  
  
## Return Value  
 In non-debug builds, always returns zero. In debug builds, returns a value that may be useful for diagnostics or testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComTearOffObject Class](../vs140/ccomtearoffobject-class.md)   
 [CComTearOffObject::AddRef](../vs140/ccomtearoffobject--addref.md)