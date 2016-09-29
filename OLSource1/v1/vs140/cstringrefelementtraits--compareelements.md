---
title: "CStringRefElementTraits::CompareElements"
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
  - "ATL::CStringRefElementTraits<T>::CompareElements"
  - "CStringRefElementTraits::CompareElements"
  - "CStringRefElementTraits.CompareElements"
  - "CompareElements"
  - "ATL::CStringRefElementTraits::CompareElements"
  - "ATL.CStringRefElementTraits.CompareElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElements function"
ms.assetid: 6a1ea281-a8d7-44af-a889-33d596dcd9a0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringRefElementTraits::CompareElements
Call this static function to compare two string elements for equality.  
  
## Syntax  
  
```  
  
      static bool CompareElements(  
   INARGTYPE element1,  
   INARGTYPE element2   
) throw( );  
```  
  
#### Parameters  
 `element1`  
 The first string element.  
  
 `element2`  
 The second string element.  
  
## Return Value  
 Returns true if the elements are equal, false otherwise.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CStringRefElementTraits Class](../vs140/cstringrefelementtraits-class.md)   
 [CStringRefElementTraits::CompareElementsOrdered](../vs140/cstringrefelementtraits--compareelementsordered.md)