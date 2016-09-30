---
title: "CStringRefElementTraits Class"
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
  - "CStringRefElementTraits"
  - "ATL.CStringRefElementTraits"
  - "ATL::CStringRefElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStringRefElementTraits class"
ms.assetid: cc15062d-5627-46cc-ac2b-1744afdc2dbd
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringRefElementTraits Class
This class provides static functions related to strings stored in collection class objects. The string objects are dealt with as references.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CStringRefElementTraits::CompareElements](../vs140/cstringrefelementtraits--compareelements.md)|Call this static function to compare two string elements for equality.|  
|[CStringRefElementTraits::CompareElementsOrdered](../vs140/cstringrefelementtraits--compareelementsordered.md)|Call this static function to compare two string elements.|  
|[CStringRefElementTraits::Hash](../vs140/cstringrefelementtraits--hash.md)|Call this static function to calculate a hash value for the given string element.|  
  
## Remarks  
 This class provides static functions for comparing strings and for creating a hash value. These functions are useful when using a collection class to store string-based data. Unlike [CStringElementTraits](../vs140/cstringelementtraits-class.md) and [CStringElementTraitsI](../vs140/cstringelementtraitsi-class.md), <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> causes the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> arguments to be passed as **const CString&** references.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 [CElementTraitsBase](../vs140/celementtraitsbase-class.md)  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="cstringrefelementtraits__compareelements">\</a>  CStringRefElementTraits::CompareElements  
 Call this static function to compare two string elements for equality.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The first string element.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The second string element.  
  
### Return Value  
 Returns true if the elements are equal, false otherwise.  
  
##  \<a name="cstringrefelementtraits__compareelementsordered">\</a>  CStringRefElementTraits::CompareElementsOrdered  
 Call this static function to compare two string elements.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The first string element.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The second string element.  
  
### Return Value  
 Zero if the strings are identical, < 0 if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or > 0 if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The [CStringT::Compare](../vs140/cstringt--compare.md) method is used to perform the comparisons.  
  
##  \<a name="cstringrefelementtraits__hash">\</a>  CStringRefElementTraits::Hash  
 Call this static function to calculate a hash value for the given string element.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The string element.  
  
### Return Value  
 Returns a hash value, calculated using the string's contents.  
  
## See Also  
 [CElementTraitsBase Class](../vs140/celementtraitsbase-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)