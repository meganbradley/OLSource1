---
title: "CComPolyObject::Release"
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
  - ATL::CComPolyObject::Release
  - ATL.CComPolyObject<contained>.Release
  - CComPolyObject::Release
  - CComPolyObject.Release
  - CComPolyObject<contained>::Release
  - ATL::CComPolyObject<contained>::Release
  - ATL.CComPolyObject.Release
dev_langs: 
  - C++
helpviewer_keywords: 
  - Release method
ms.assetid: 1b240681-fb3b-45e3-ba84-42c0a1338151
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComPolyObject::Release
Decrements the reference count on the object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
  
```  
  
## Return Value  
 In debug builds, **Release** returns a value that may be useful for diagnostics or testing. In nondebug builds, **Release** always returns 0.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [CComPolyObject::AddRef](../vs140/ccompolyobject--addref.md)