---
title: "CStringElementTraitsI::Hash"
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
  - "CStringElementTraitsI::Hash"
  - "ATL::CStringElementTraitsI::Hash"
  - "CStringElementTraitsI.Hash"
  - "ATL.CStringElementTraitsI.Hash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash function"
ms.assetid: d38c73a5-031f-405b-959c-f4fec581b5f2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringElementTraitsI::Hash
Call this static function to calculate a hash value for the given string element.  
  
## Syntax  
  
```  
  
      static ULONG Hash(  
   INARGTYPE str   
) throw( );  
```  
  
#### Parameters  
 `str`  
 The string element.  
  
## Return Value  
 Returns a hash value, calculated using the string's contents.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CStringElementTraitsI Class](../vs140/cstringelementtraitsi-class.md)   
 [CStringElementTraits::Hash](../vs140/cstringelementtraits--hash.md)