---
title: "CStringElementTraitsI Class"
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
  - "ATL::CStringElementTraitsI"
  - "CStringElementTraitsI"
  - "ATL.CStringElementTraitsI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStringElementTraitsI class"
ms.assetid: c23f92b1-91e5-400f-96ed-258b02622b7a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraitsI Class
This class provides static functions related to strings stored in collection class objects. It is similar to [CStringElementTraits](../VS_csharp/cstringelementtraits-class.md), but performs case-insensitive comparisons.  
  
## Syntax  
  
```  
  
template<  
      typename  T,  
      class CharTraits = CDefaultCharTraits<  T  
   ::XCHAR >>  
   class CStringElementTraitsI : public CElementTraitsBase<  T  
    >  
  
```  
  
#### Parameters  
 `T`  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CStringElementTraitsI::INARGTYPE](../Topic/CStringElementTraitsI::INARGTYPE.md)|The data type to use for adding elements to the collection class object.|  
|[CStringElementTraitsI::OUTARGTYPE](../Topic/CStringElementTraitsI::OUTARGTYPE.md)|The data type to use for retrieving elements from the collection class object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CStringElementTraitsI::CompareElements](../Topic/CStringElementTraitsI::CompareElements.md)|Call this static function to compare two string elements for equality, ignoring differences in case.|  
|[CStringElementTraitsI::CompareElementsOrdered](../Topic/CStringElementTraitsI::CompareElementsOrdered.md)|Call this static function to compare two string elements, ignoring differences in case.|  
|[CStringElementTraitsI::Hash](../Topic/CStringElementTraitsI::Hash.md)|Call this static function to calculate a hash value for the given string element.|  
  
## Remarks  
 This class provides static functions for comparing strings and for creating a hash value. These functions are useful when using a collection class to store string-based data. Use [CStringRefElementTraits](../VS_csharp/cstringrefelementtraits-class.md) when the string objects are to be with dealt with as references.  
  
 For more information, see [ATL Collection Classes](../VS_csharp/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 [CElementTraitsBase](../VS_csharp/celementtraitsbase-class.md)  
  
 `CStringElementTraitsI`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="cstringelementtraitsi__compareelements"></a>  CStringElementTraitsI::CompareElements  
 Call this static function to compare two string elements for equality, ignoring differences in case.  
  
```  
  
static bool CompareElements(  
      INARGTYPE  str1,  
      INARGTYPE  str2  
   ) throw( );  
  
```  
  
### Parameters  
 `str1`  
 The first string element.  
  
 `str2`  
 The second string element.  
  
### Return Value  
 Returns true if the elements are equal, false otherwise.  
  
### Remarks  
 Comparisons are case insensitive.  
  
##  <a name="cstringelementtraitsi__compareelementsordered"></a>  CStringElementTraitsI::CompareElementsOrdered  
 Call this static function to compare two string elements, ignoring differences in case.  
  
```  
  
static int CompareElementsOrdered(  
      INARGTYPE  str1,  
      INARGTYPE  str2  
   ) throw( );  
  
```  
  
### Parameters  
 `str1`  
 The first string element.  
  
 `str2`  
 The second string element.  
  
### Return Value  
 Zero if the strings are identical, < 0 if `str1` is less than `str2`, or > 0 if `str1` is greater than `str2`. The [CStringT::Compare](../Topic/CStringT::Compare.md) method is used to perform the comparisons.  
  
### Remarks  
 Comparisons are case insensitive.  
  
##  <a name="cstringelementtraitsi__hash"></a>  CStringElementTraitsI::Hash  
 Call this static function to calculate a hash value for the given string element.  
  
```  
  
static ULONG Hash(  
      INARGTYPE  str  
   ) throw( );  
  
```  
  
### Parameters  
 `str`  
 The string element.  
  
### Return Value  
 Returns a hash value, calculated using the string's contents.  
  
##  <a name="cstringelementtraitsi__inargtype"></a>  CStringElementTraitsI::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
```  
  
typedef T::PCXSTR INARGTYPE;  
  
```  
  
##  <a name="cstringelementtraitsi__outargtype"></a>  CStringElementTraitsI::OUTARGTYPE  
 The data type to use for retrieving elements from the collection class object.  
  
```  
  
typedef T & OUTARGTYPE;  
  
```  
  
## See Also  
 [CElementTraitsBase Class](../VS_csharp/celementtraitsbase-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [CStringElementTraits Class](../VS_csharp/cstringelementtraits-class.md)