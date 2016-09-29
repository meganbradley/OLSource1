---
title: "CElementTraitsBase Class"
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
  - "CElementTraitsBase"
  - "ATL::CElementTraitsBase"
  - "ATL.CElementTraitsBase<T>"
  - "ATL::CElementTraitsBase<T>"
  - "ATL.CElementTraitsBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CElementTraitsBase class"
ms.assetid: 75284caf-347e-4355-a7d8-efc708dd514a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CElementTraitsBase Class
This class provides default copy and move methods for a collection class.  
  
## Syntax  
  
```  
  
template<  
      typename  T>  
   class CElementTraitsBase  
  
```  
  
#### Parameters  
 `T`  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CElementTraitsBase::INARGTYPE](../Topic/CElementTraitsBase::INARGTYPE.md)|The data type to use for adding elements to the collection class object.|  
|[CElementTraitsBase::OUTARGTYPE](../Topic/CElementTraitsBase::OUTARGTYPE.md)|The data type to use for retrieving elements from the collection class object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CElementTraitsBase::CopyElements](../Topic/CElementTraitsBase::CopyElements.md)|Call this method to copy elements stored in a collection class object.|  
|[CElementTraitsBase::RelocateElements](../Topic/CElementTraitsBase::RelocateElements.md)|Call this method to relocate elements stored in a collection class object.|  
  
## Remarks  
 This base class defines methods for copying and relocating elements in a collection class. It is utilized by the classes [CDefaultElementTraits](../VS_csharp/cdefaultelementtraits-class.md), [CStringRefElementTraits](../VS_csharp/cstringrefelementtraits-class.md), and [CStringElementTraitsI](../VS_csharp/cstringelementtraitsi-class.md).  
  
 For more information, see [ATL Collection Classes](../VS_csharp/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="celementtraitsbase__copyelements"></a>  CElementTraitsBase::CopyElements  
 Call this method to copy elements stored in a collection class object.  
  
```  
  
static void CopyElements(  
      T*  pDest,  
      const T*  pSrc,  
      size_t  nElements  
   );  
  
```  
  
### Parameters  
 `pDest`  
 Pointer to the first element that will receive the copied data.  
  
 `pSrc`  
 Pointer to the first element to copy.  
  
 `nElements`  
 The number of elements to copy.  
  
### Remarks  
 The source and destination elements should not overlap.  
  
##  <a name="celementtraitsbase__inargtype"></a>  CElementTraitsBase::INARGTYPE  
 The data type to use for adding elements to the collection.  
  
```  
  
typedef const T& INARGTYPE;  
  
```  
  
##  <a name="celementtraitsbase__outargtype"></a>  CElementTraitsBase::OUTARGTYPE  
 The data type to use for retrieving elements from the collection.  
  
```  
  
typedef T& OUTARGTYPE;  
  
```  
  
##  <a name="celementtraitsbase__relocateelements"></a>  CElementTraitsBase::RelocateElements  
 Call this method to relocate elements stored in a collection class object.  
  
```  
  
static void RelocateElements(  
      T*  pDest,  
      T*  pSrc,  
      size_t  nElements  
   );  
  
```  
  
### Parameters  
 `pDest`  
 Pointer to the first element that will receive the relocated data.  
  
 `pSrc`  
 Pointer to the first element to relocate.  
  
 `nElements`  
 The number of elements to relocate.  
  
### Remarks  
 This method calls [memmove](../VS_csharp/memmove--wmemmove.md), which is sufficient for most data types. If the objects being moved contain pointers to their own members, this method will need to be overridden.  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)