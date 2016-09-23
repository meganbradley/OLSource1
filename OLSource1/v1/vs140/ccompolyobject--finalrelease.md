---
title: "CComPolyObject::FinalRelease"
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
  - CComPolyObject<contained>::FinalRelease
  - ATL::CComPolyObject::FinalRelease
  - CComPolyObject.FinalRelease
  - CComPolyObject::FinalRelease
  - ATL.CComPolyObject.FinalRelease
  - ATL::CComPolyObject<contained>::FinalRelease
dev_langs: 
  - C++
helpviewer_keywords: 
  - FinalRelease method
ms.assetid: 14618d7e-895c-4229-ad77-e8c73f00bed1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComPolyObject::FinalRelease
Called during object destruction, this method frees the [m_contained](../vs140/ccompolyobject--m_contained.md) data member.  
  
## Syntax  
  
```  
  
void FinalRelease( );  
  
```  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [CComObjectRootEx::FinalRelease](../vs140/ccomobjectrootex--finalrelease.md)   
 [CComPolyObject::FinalConstruct](../vs140/ccompolyobject--finalconstruct.md)