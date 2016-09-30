---
title: "CStringElementTraits::RelocateElements"
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
  - "CStringElementTraits.RelocateElements"
  - "CStringElementTraits::RelocateElements"
  - "RelocateElements"
  - "ATL.CStringElementTraits.RelocateElements"
  - "ATL::CStringElementTraits<T>::RelocateElements"
  - "ATL::CStringElementTraits::RelocateElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RelocateElements function"
ms.assetid: 63b2bac1-511d-4d00-9077-8e80170cb65f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraits::RelocateElements
Call this static function to relocate <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> elements stored in a collection class object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the first element that will receive the relocated data.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the first element to relocate.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of elements to relocate.  
  
## Remarks  
 This static function calls [memmove](../vs140/memmove--wmemmove.md), which is sufficient for most data types. If the objects being moved contain pointers to their own members, this static function will need to be overridden.  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringElementTraits Class](../vs140/cstringelementtraits-class.md)   
 [CStringElementTraits::CopyElements](../vs140/cstringelementtraits--copyelements.md)