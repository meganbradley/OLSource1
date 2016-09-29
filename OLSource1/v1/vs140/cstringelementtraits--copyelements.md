---
title: "CStringElementTraits::CopyElements"
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
  - "ATL::CStringElementTraits<T>::CopyElements"
  - "CStringElementTraits::CopyElements"
  - "ATL.CStringElementTraits.CopyElements"
  - "CStringElementTraits.CopyElements"
  - "ATL::CStringElementTraits::CopyElements"
  - "CStringElementTraits<T>::CopyElements"
  - "CopyElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyElements function"
ms.assetid: e92a0321-bcba-4c77-898d-aeae95918d34
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraits::CopyElements
Call this static function to copy `CString` elements stored in a collection class object.  
  
## Syntax  
  
```  
  
      static void CopyElements(  
   T* pDest,  
   const T* pSrc,  
   size_t nElements   
);  
```  
  
#### Parameters  
 `pDest`  
 Pointer to the first element that will receive the copied data.  
  
 `pSrc`  
 Pointer to the first element to copy.  
  
 `nElements`  
 The number of elements to copy.  
  
## Remarks  
 The source and destination elements should not overlap.  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringElementTraits Class](../vs140/cstringelementtraits-class.md)   
 [CStringElementTraits::RelocateElements](../vs140/cstringelementtraits--relocateelements.md)