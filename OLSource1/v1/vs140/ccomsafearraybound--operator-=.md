---
title: "CComSafeArrayBound::operator ="
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
  - "CComSafeArrayBound.operator="
  - "CComSafeArrayBound::operator="
  - "ATL::CComSafeArrayBound::operator="
  - "ATL.CComSafeArrayBound.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, arrays"
  - "operator=, arrays"
ms.assetid: 1218486b-ea83-4c8a-80de-94f819386ded
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArrayBound::operator =
Sets the `CComSafeArrayBound` to a new value.  
  
## Syntax  
  
```  
  
      CComSafeArrayBound & operator =(  
   const CComSafeArrayBound & bound   
) throw( );  
CComSafeArrayBound & operator =(  
   ULONG ulCount   
) throw( );  
```  
  
#### Parameters  
 `bound`  
 A `CComSafeArrayBound` object.  
  
 `ulCount`  
 The number of elements.  
  
## Return Value  
 Returns a pointer to the `CComSafeArrayBound` object.  
  
## Remarks  
 The `CComSafeArrayBound` object can be assigned using an existing `CComSafeArrayBound`, or by supplying the number of elements, in which case the lower bound is set to 0 by default.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArrayBound Class](../vs140/ccomsafearraybound-class.md)