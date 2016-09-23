---
title: "CComSafeArray::Detach"
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
  - CComSafeArray.Detach
  - ATL.CComSafeArray.Detach
  - CComSafeArray::Detach
  - ATL::CComSafeArray::Detach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Detach method
ms.assetid: ccccfc37-8d23-4851-946d-11dcf6490cbe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComSafeArray::Detach
Detaches a **SAFEARRAY** from a `CComSafeArray` object.  
  
## Syntax  
  
```  
  
LPSAFEARRAY Detach( );  
  
```  
  
## Return Value  
 Returns a pointer to a **SAFEARRAY** object.  
  
## Remarks  
 This method detaches the **SAFEARRAY** object from the `CComSafeArray` object.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::Attach](../vs140/ccomsafearray--attach.md)