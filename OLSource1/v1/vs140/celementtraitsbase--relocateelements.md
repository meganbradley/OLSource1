---
title: "CElementTraitsBase::RelocateElements"
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
  - CElementTraitsBase.RelocateElements
  - ATL.CElementTraitsBase.RelocateElements
  - RelocateElements
  - ATL::CElementTraitsBase::RelocateElements
  - CElementTraitsBase::RelocateElements
  - ATL::CElementTraitsBase<T>::RelocateElements
dev_langs: 
  - C++
helpviewer_keywords: 
  - RelocateElements method
ms.assetid: b3270301-9642-4a8d-a6b8-f2557091c13d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CElementTraitsBase::RelocateElements
Call this method to relocate elements stored in a collection class object.  
  
## Syntax  
  
```  
  
      static void RelocateElements(  
   T* pDest,  
   T* pSrc,  
   size_t nElements   
);  
```  
  
#### Parameters  
 `pDest`  
 Pointer to the first element that will receive the relocated data.  
  
 `pSrc`  
 Pointer to the first element to relocate.  
  
 `nElements`  
 The number of elements to relocate.  
  
## Remarks  
 This method calls [memmove](../vs140/memmove--wmemmove.md), which is sufficient for most data types. If the objects being moved contain pointers to their own members, this method will need to be overridden.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CElementTraitsBase Class](../vs140/celementtraitsbase-class.md)   
 [CElementTraitsBase::CopyElements](../vs140/celementtraitsbase--copyelements.md)