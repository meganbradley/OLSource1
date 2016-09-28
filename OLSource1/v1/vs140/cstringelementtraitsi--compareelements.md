---
title: "CStringElementTraitsI::CompareElements"
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
  - "CStringElementTraitsI.CompareElements"
  - "CompareElements"
  - "CStringElementTraitsI::CompareElements"
  - "ATL::CStringElementTraitsI::CompareElements"
  - "ATL.CStringElementTraitsI.CompareElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElements function"
ms.assetid: d1fbdcec-74d8-4c32-a11b-1b3985850fe8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraitsI::CompareElements
Call this static function to compare two string elements for equality, ignoring differences in case.  
  
## Syntax  
  
```  
  
      static bool CompareElements(  
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
 Returns true if the elements are equal, false otherwise.  
  
## Remarks  
 Comparisons are case insensitive.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CStringElementTraitsI Class](../vs140/cstringelementtraitsi-class.md)   
 [CStringElementTraitsI::CompareElementsOrdered](../vs140/cstringelementtraitsi--compareelementsordered.md)   
 [CStringElementTraits::CompareElements](../vs140/cstringelementtraits--compareelements.md)