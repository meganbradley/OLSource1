---
title: "CComAggObject::Release"
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
  - CComAggObject<contained>::Release
  - ATL::CComAggObject<contained>::Release
  - ATL.CComAggObject<contained>.Release
  - CComAggObject::Release
  - CComAggObject<contained>.Release
  - CComAggObject.Release
  - ATL.CComAggObject.Release
  - ATL::CComAggObject::Release
dev_langs: 
  - C++
helpviewer_keywords: 
  - Release method
ms.assetid: 5da82a10-55b0-4f60-baea-69b6d7819fc8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComAggObject::Release
Decrements the reference count on the aggregated object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
  
```  
  
## Return Value  
 In debug builds, **Release** returns a value that may be useful for diagnostics or testing. In non-debug builds, **Release** always returns 0.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComAggObject::AddRef](../vs140/ccomaggobject--addref.md)