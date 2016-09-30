---
title: "CComSafeArray::CComSafeArray"
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
  - "ATL.CComSafeArray.CComSafeArray"
  - "CComSafeArray::CComSafeArray"
  - "ATL::CComSafeArray::CComSafeArray"
  - "CComSafeArray.CComSafeArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComSafeArray class, constructor"
  - "CComSafeArray constructor"
ms.assetid: 1e509c71-2263-45d2-88e2-7b863fd476a7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::CComSafeArray
The constructor.  
  
## Syntax  
  
```  
  
      CComSafeArray( );   
CComSafeArray(  
   const SAFEARRAYBOUND& bound   
);  
CComSafeArray(  
   ULONG ulCount,  
   LONG lLBound = 0   
);  
CComSafeArray(  
   const SAFEARRAYBOUND * pBound,  
   UINT uDims = 1   
);  
CComSafeArray(  
   const CComSafeArray& saSrc   
);  
CComSafeArray(  
   const SAFEARRAY& saSrc   
);  
CComSafeArray(  
   const SAFEARRAY * psaSrc   
);  
```  
  
#### Parameters  
 `bound`  
 A **SAFEARRAYBOUND** structure.  
  
 `ulCount`  
 The number of elements in the array.  
  
 `lLBound`  
 The lower bound value; that is, the index of the first element in the array.  
  
 `pBound`  
 A pointer to a **SAFEARRAYBOUND** structure.  
  
 `uDims`  
 The count of dimensions in the array.  
  
 `saSrc`  
 A reference to a **SAFEARRAY** structure or `CComSafeArray` object. In either case the constructor uses this reference to make a copy of the array, so the array is not referenced after construction.  
  
 `psaSrc`  
 A pointer to a **SAFEARRAY** structure. The constructor uses this address to make a copy of the array, so the array is not referenced after construction.  
  
## Remarks  
 Creates a `CComSafeArray` object.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::~CComSafeArray](../vs140/ccomsafearray--~ccomsafearray.md)