---
title: "CStringElementTraits::CompareElements"
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
  - "ATL.CStringElementTraits.CompareElements"
  - "CStringElementTraits.CompareElements"
  - "CStringElementTraits::CompareElements"
  - "ATL::CStringElementTraits::CompareElements"
  - "CompareElements"
  - "ATL::CStringElementTraits<T>::CompareElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElements function"
ms.assetid: c47b5a5e-8729-4e2a-a104-0d06d1f7c98f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraits::CompareElements
Call this static function to compare two string elements for equality.  
  
## Syntax  
  
```  
  
      static bool CompareElements(  
   INARGTYPE str1,  
   INARGTYPE str2   
);  
```  
  
#### Parameters  
 `str1`  
 The first string element.  
  
 `str2`  
 The second string element.  
  
## Return Value  
 Returns true if the elements are equal, false otherwise.  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringElementTraits Class](../vs140/cstringelementtraits-class.md)   
 [CStringElementTraits::CompareElementsOrdered](../vs140/cstringelementtraits--compareelementsordered.md)   
 [CStringElementTraitsI::CompareElements](../vs140/cstringelementtraitsi--compareelements.md)