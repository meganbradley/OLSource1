---
title: "CStringElementTraits Class"
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
  - "ATL.CStringElementTraits<T>"
  - "ATL::CStringElementTraits<T>"
  - "CStringElementTraits"
  - "ATL.CStringElementTraits"
  - "ATL::CStringElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStringElementTraits class"
ms.assetid: 74d7134b-099d-4455-bf91-3e68ccbf95bc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraits Class
This class provides static functions used by collection classes storing `CString` objects.  
  
## Syntax  
  
```  
  
template<  
      typename  T>  
   class CStringElementTraits  
  
```  
  
#### Parameters  
 `T`  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CStringElementTraits::INARGTYPE](../Topic/CStringElementTraits::INARGTYPE.md)|The data type to use for adding elements to the collection class object.|  
|[CStringElementTraits::OUTARGTYPE](../Topic/CStringElementTraits::OUTARGTYPE.md)|The data type to use for retrieving elements from the collection class object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CStringElementTraits::CompareElements](../Topic/CStringElementTraits::CompareElements.md)|(Static) Call this function to compare two string elements for equality.|  
|[CStringElementTraits::CompareElementsOrdered](../Topic/CStringElementTraits::CompareElementsOrdered.md)|(Static) Call this function to compare two string elements.|  
|[CStringElementTraits::CopyElements](../Topic/CStringElementTraits::CopyElements.md)|(Static) Call this function to copy `CString` elements stored in a collection class object.|  
|[CStringElementTraits::Hash](../Topic/CStringElementTraits::Hash.md)|(Static) Call this function to calculate a hash value for the given string element.|  
|[CStringElementTraits::RelocateElements](../Topic/CStringElementTraits::RelocateElements.md)|(Static) Call this function to relocate `CString` elements stored in a collection class object.|  
  
## Remarks  
 This class provides static functions for copying, moving, and comparing strings and for creating a hash value. These functions are useful when using a collection class to store string-based data. Use [CStringElementTraitsI](../VS_csharp/cstringelementtraitsi-class.md) when case-insensitive comparisons are required. Use [CStringRefElementTraits](../VS_csharp/cstringrefelementtraits-class.md) when the string objects are to be dealt with as references.  
  
 For more information, see [ATL Collection Classes](../VS_csharp/atl-collection-classes.md).  
  
## Requirements  
 **Header:** cstringt.h  
  
##  <a name="cstringelementtraits__compareelements"></a>  CStringElementTraits::CompareElements  
 Call this static function to compare two string elements for equality.  
  
```  
  
static bool CompareElements(  
      INARGTYPE  str1,  
      INARGTYPE  str2  
   );  
  
```  
  
### Parameters  
 `str1`  
 The first string element.  
  
 `str2`  
 The second string element.  
  
### Return Value  
 Returns true if the elements are equal, false otherwise.  
  
##  <a name="cstringelementtraits__compareelementsordered"></a>  CStringElementTraits::CompareElementsOrdered  
 Call this static function to compare two string elements.  
  
```  
  
static int CompareElementsOrdered(  
      INARGTYPE  str1,  
      INARGTYPE  str2  
   );  
  
```  
  
### Parameters  
 `str1`  
 The first string element.  
  
 `str2`  
 The second string element.  
  
### Return Value  
 Zero if the strings are identical, < 0 if `str1` is less than `str2`, or > 0 if `str1` is greater than `str2`. The [CStringT::Compare](../Topic/CStringT::Compare.md) method is used to perform the comparisons.  
  
##  <a name="cstringelementtraits__copyelements"></a>  CStringElementTraits::CopyElements  
 Call this static function to copy `CString` elements stored in a collection class object.  
  
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
  
##  <a name="cstringelementtraits__hash"></a>  CStringElementTraits::Hash  
 Call this static function to calculate a hash value for the given string element.  
  
```  
  
static ULONG Hash(  
      INARGTYPE  str  
   );  
  
```  
  
### Parameters  
 `str`  
 The string element.  
  
### Return Value  
 Returns a hash value, calculated using the string's contents.  
  
##  <a name="cstringelementtraits__inargtype"></a>  CStringElementTraits::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
```  
  
typedef T::PCXSTR INARGTYPE;  
  
```  
  
##  <a name="cstringelementtraits__outargtype"></a>  CStringElementTraits::OUTARGTYPE  
 The data type to use for retrieving elements from the collection class object.  
  
```  
  
typedef T & OUTARGTYPE;  
  
```  
  
##  <a name="cstringelementtraits__relocateelements"></a>  CStringElementTraits::RelocateElements  
 Call this static function to relocate `CString` elements stored in a collection class object.  
  
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
 This static function calls [memmove](../VS_csharp/memmove--wmemmove.md), which is sufficient for most data types. If the objects being moved contain pointers to their own members, this static function will need to be overridden.  
  
## See Also  
 [CElementTraitsBase Class](../VS_csharp/celementtraitsbase-class.md)   
 [CStringElementTraitsI Class](../VS_csharp/cstringelementtraitsi-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)