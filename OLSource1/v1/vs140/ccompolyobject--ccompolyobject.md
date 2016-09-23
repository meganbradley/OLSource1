---
title: "CComPolyObject::CComPolyObject"
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
  - ATL::CComPolyObject<contained>::CComPolyObject
  - ATL.CComPolyObject.CComPolyObject
  - ATL::CComPolyObject::CComPolyObject
  - CComPolyObject<contained>::CComPolyObject
  - CComPolyObject.CComPolyObject
  - CComPolyObject::CComPolyObject
dev_langs: 
  - C++
helpviewer_keywords: 
  - CComPolyObject class, constructor
  - CComPolyObject constructor
ms.assetid: f9241802-dbc8-42db-a1be-a357cd158481
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComPolyObject::CComPolyObject
The constructor.  
  
## Syntax  
  
```  
  
      CComPolyObject(  
   void* pv   
);  
```  
  
#### Parameters  
 `pv`  
 [in] A pointer to the outer unknown if the object is to be aggregated, or **NULL** if the object if the object is not aggregated.  
  
## Remarks  
 Initializes the `CComContainedObject` data member, [m_contained](../vs140/ccompolyobject--m_contained.md), and increments the module lock count.  
  
 The destructor decrements the module lock count.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [CComPolyObject::FinalConstruct](../vs140/ccompolyobject--finalconstruct.md)   
 [CComPolyObject::FinalRelease](../vs140/ccompolyobject--finalrelease.md)