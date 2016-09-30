---
title: "CDefaultCompareTraits::CompareElements"
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
  - "CDefaultCompareTraits::CompareElements"
  - "CDefaultCompareTraits.CompareElements"
  - "CompareElements"
  - "ATL.CDefaultCompareTraits.CompareElements"
  - "ATL::CDefaultCompareTraits<T>::CompareElements"
  - "ATL::CDefaultCompareTraits::CompareElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareElements function"
ms.assetid: 43852805-c07f-4a88-8307-e2295cf9e733
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDefaultCompareTraits::CompareElements
Call this function to compare two elements for equality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first element.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second element.  
  
## Return Value  
 Returns true if the elements are equal, false otherwise.  
  
## Remarks  
 The default implementation of this function is the equality (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) operator. For objects other than simple data types, this function may need to be overridden.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CDefaultCompareTraits Class](../vs140/cdefaultcomparetraits-class.md)   
 [CDefaultCompareTraits::CompareElementsOrdered](../vs140/cdefaultcomparetraits--compareelementsordered.md)