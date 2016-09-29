---
title: "CStringElementTraitsI::CompareElementsOrdered"
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
  - "CStringElementTraitsI.CompareElementsOrdered"
  - "CompareElementsOrdered"
  - "ATL.CStringElementTraitsI.CompareElementsOrdered"
  - "CStringElementTraitsI::CompareElementsOrdered"
  - "ATL::CStringElementTraitsI::CompareElementsOrdered"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElementsOrdered function"
ms.assetid: bf576962-f504-44bc-ae86-cf5db97308c8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraitsI::CompareElementsOrdered
Call this static function to compare two string elements, ignoring differences in case.  
  
## Syntax  
  
```  
  
      static int CompareElementsOrdered(  
   INARGTYPE str1,  
   INARGTYPE str2   
) throw( );  
```  
  
#### Parameters  
 `str1`  
 The first string element.  
  
 `str2`  
 The second string element.  
  
## Return Value  
 Zero if the strings are identical, < 0 if `str1` is less than `str2`, or > 0 if `str1` is greater than `str2`. The [CStringT::Compare](../vs140/cstringt--compare.md) method is used to perform the comparisons.  
  
## Remarks  
 Comparisons are case insensitive.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CStringElementTraitsI Class](../vs140/cstringelementtraitsi-class.md)   
 [CStringElementTraitsI::CompareElements](../vs140/cstringelementtraitsi--compareelements.md)   
 [CStringElementTraits::CompareElementsOrdered](../vs140/cstringelementtraits--compareelementsordered.md)