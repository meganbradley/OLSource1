---
title: "basic_ostream::swap"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "basic_ostream::swap"
  - "std::basic_ostream::swap"
  - "std.basic_ostream.swap"
  - "ostream/std::basic_ostream::swap"
  - "basic_ostream.swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 55b9beba-7ae1-4966-99b5-af8e4515794b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostream::swap
Exchanges the values of this `basic_ostream` object for the values of the provided `basic_ostream`.  
  
## Syntax  
  
```  
void swap(  
    basic_ostream& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 A reference to a `basic_ostream` object.  
  
## Remarks  
 The member function calls [swap](../vs140/basic_ios--swap.md)`(``_Right``)` to exchange the contents of this object for the contents of `_Right`.  
  
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [\<ostream>](../vs140/-ostream-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)