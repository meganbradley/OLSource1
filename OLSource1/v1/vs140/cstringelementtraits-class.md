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
This class provides static functions used by collection classes storing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CStringElementTraits::INARGTYPE](../vs140/cstringelementtraits--inargtype.md)|The data type to use for adding elements to the collection class object.|  
|[CStringElementTraits::OUTARGTYPE](../vs140/cstringelementtraits--outargtype.md)|The data type to use for retrieving elements from the collection class object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CStringElementTraits::CompareElements](../vs140/cstringelementtraits--compareelements.md)|(Static) Call this function to compare two string elements for equality.|  
|[CStringElementTraits::CompareElementsOrdered](../vs140/cstringelementtraits--compareelementsordered.md)|(Static) Call this function to compare two string elements.|  
|[CStringElementTraits::CopyElements](../vs140/cstringelementtraits--copyelements.md)|(Static) Call this function to copy <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> elements stored in a collection class object.|  
|[CStringElementTraits::Hash](../vs140/cstringelementtraits--hash.md)|(Static) Call this function to calculate a hash value for the given string element.|  
|[CStringElementTraits::RelocateElements](../vs140/cstringelementtraits--relocateelements.md)|(Static) Call this function to relocate <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> elements stored in a collection class object.|  
  
## Remarks  
 This class provides static functions for copying, moving, and comparing strings and for creating a hash value. These functions are useful when using a collection class to store string-based data. Use [CStringElementTraitsI](../vs140/cstringelementtraitsi-class.md) when case-insensitive comparisons are required. Use [CStringRefElementTraits](../vs140/cstringrefelementtraits-class.md) when the string objects are to be dealt with as references.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** cstringt.h  
  
##  \<a name="cstringelementtraits__compareelements">\</a>  CStringElementTraits::CompareElements  
 Call this static function to compare two string elements for equality.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The first string element.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The second string element.  
  
### Return Value  
 Returns true if the elements are equal, false otherwise.  
  
##  \<a name="cstringelementtraits__compareelementsordered">\</a>  CStringElementTraits::CompareElementsOrdered  
 Call this static function to compare two string elements.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The first string element.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The second string element.  
  
### Return Value  
 Zero if the strings are identical, < 0 if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or > 0 if <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The [CStringT::Compare](../vs140/cstringt--compare.md) method is used to perform the comparisons.  
  
##  \<a name="cstringelementtraits__copyelements">\</a>  CStringElementTraits::CopyElements  
 Call this static function to copy <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> elements stored in a collection class object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Pointer to the first element that will receive the copied data.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Pointer to the first element to copy.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The number of elements to copy.  
  
### Remarks  
 The source and destination elements should not overlap.  
  
##  \<a name="cstringelementtraits__hash">\</a>  CStringElementTraits::Hash  
 Call this static function to calculate a hash value for the given string element.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The string element.  
  
### Return Value  
 Returns a hash value, calculated using the string's contents.  
  
##  \<a name="cstringelementtraits__inargtype">\</a>  CStringElementTraits::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cstringelementtraits__outargtype">\</a>  CStringElementTraits::OUTARGTYPE  
 The data type to use for retrieving elements from the collection class object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="cstringelementtraits__relocateelements">\</a>  CStringElementTraits::RelocateElements  
 Call this static function to relocate <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> elements stored in a collection class object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Pointer to the first element that will receive the relocated data.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Pointer to the first element to relocate.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The number of elements to relocate.  
  
### Remarks  
 This static function calls [memmove](../vs140/memmove--wmemmove.md), which is sufficient for most data types. If the objects being moved contain pointers to their own members, this static function will need to be overridden.  
  
## See Also  
 [CElementTraitsBase Class](../vs140/celementtraitsbase-class.md)   
 [CStringElementTraitsI Class](../vs140/cstringelementtraitsi-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)