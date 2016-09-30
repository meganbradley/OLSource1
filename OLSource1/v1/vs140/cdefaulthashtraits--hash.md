---
title: "CDefaultHashTraits::Hash"
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
  - "ATL::CDefaultHashTraits<T>::Hash"
  - "ATL::CDefaultHashTraits::Hash"
  - "CDefaultHashTraits.Hash"
  - "CDefaultHashTraits::Hash"
  - "ATL.CDefaultHashTraits.Hash"
  - "CDefaultHashTraits<T>::Hash"
  - "CDefaultHashTraits<T>.Hash"
  - "ATL.CDefaultHashTraits<T>.Hash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash function"
ms.assetid: 4b587a5f-a302-4ffd-9c6c-8da284781bdc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDefaultHashTraits::Hash
Call this function to calculate a hash value for a given element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The element.  
  
## Return Value  
 Returns the hash value.  
  
## Remarks  
 The default hashing algorithm is very simple: the return value is the element number. Override this function if a more complicated algorithm is required.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CDefaultHashTraits Class](../vs140/cdefaulthashtraits-class.md)