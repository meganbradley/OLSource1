---
title: "CStringRefElementTraits::CompareElementsOrdered"
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
  - "CStringRefElementTraits::CompareElementsOrdered"
  - "ATL::CStringRefElementTraits::CompareElementsOrdered"
  - "ATL.CStringRefElementTraits.CompareElementsOrdered"
  - "CompareElementsOrdered"
  - "CStringRefElementTraits.CompareElementsOrdered"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElementsOrdered function"
ms.assetid: ad7cdea7-3b41-4d18-ab9f-3256aa0991a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringRefElementTraits::CompareElementsOrdered
Call this static function to compare two string elements.  
  
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
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CStringRefElementTraits Class](../vs140/cstringrefelementtraits-class.md)   
 [CStringRefElementTraits::CompareElements](../vs140/cstringrefelementtraits--compareelements.md)