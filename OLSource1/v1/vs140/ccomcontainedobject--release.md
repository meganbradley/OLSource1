---
title: "CComContainedObject::Release"
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
  - "CComContainedObject::Release"
  - "ATL::CComContainedObject::Release"
  - "CComContainedObject<Base>::Release"
  - "CComContainedObject.Release"
  - "ATL.CComContainedObject.Release"
  - "ATL::CComContainedObject<Base>::Release"
  - "ATL.CComContainedObject<Base>.Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
ms.assetid: 5352917d-143e-4a04-b3cd-30551975ce6e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComContainedObject::Release
Decrements the reference count on the owner object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
  
```  
  
## Return Value  
 In debug builds, **Release** returns a value that may be useful for diagnostics or testing. In non-debug builds, **Release** always returns 0.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComContainedObject Class](../vs140/ccomcontainedobject-class.md)   
 [CComContainedObject::AddRef](../vs140/ccomcontainedobject--addref.md)