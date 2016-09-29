---
title: "CComSafeArray::MultiDimGetAt"
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
  - "MultiDimGetAt"
  - "CComSafeArray.MultiDimGetAt"
  - "CComSafeArray::MultiDimGetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MultiDimGetAt method"
ms.assetid: 74ccb794-c2e8-4010-b615-dfef768c997a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::MultiDimGetAt
Retrieves a single element from a multidimensional array.  
  
## Syntax  
  
```  
  
      HRESULT MultiDimGetAt(  
   const LONG * alIndex,  
   T& t   
);  
```  
  
#### Parameters  
 `alIndex`  
 Pointer to a vector of indexes for each dimension in the array. The leftmost (most significant) dimension is `alIndex`[0]*.*  
  
 *t*  
 A reference to the data returned.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::GetAt](../vs140/ccomsafearray--getat.md)   
 [CComSafeArray::SetAt](../vs140/ccomsafearray--setat.md)   
 [CComSafeArray::MultiDimSetAt](../vs140/ccomsafearray--multidimsetat.md)