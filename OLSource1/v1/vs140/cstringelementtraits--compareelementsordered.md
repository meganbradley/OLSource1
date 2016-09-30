---
title: "CStringElementTraits::CompareElementsOrdered"
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
  - "ATL::CStringElementTraits::CompareElementsOrdered"
  - "ATL.CStringElementTraits.CompareElementsOrdered"
  - "CompareElementsOrdered"
  - "CStringElementTraits::CompareElementsOrdered"
  - "CStringElementTraits.CompareElementsOrdered"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElementsOrdered function"
ms.assetid: 07e91fc7-4133-4531-b064-7ddf473e3bbe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraits::CompareElementsOrdered
Call this static function to compare two string elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first string element.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second string element.  
  
## Return Value  
 Zero if the strings are identical, < 0 if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or > 0 if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The [CStringT::Compare](../vs140/cstringt--compare.md) method is used to perform the comparisons.  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringElementTraits Class](../vs140/cstringelementtraits-class.md)   
 [CStringElementTraits::CompareElements](../vs140/cstringelementtraits--compareelements.md)   
 [CStringElementTraitsI::CompareElementsOrdered](../vs140/cstringelementtraitsi--compareelementsordered.md)