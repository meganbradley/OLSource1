---
title: "&lt;ostream&gt; swap"
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
  - "ostream/std::swap"
  - "std.swap"
  - "std::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: 041d2746-6919-4b03-b401-931633b0cf81
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;ostream&gt; swap
Exchanges the values of two `basic_ostream` objects.  
  
## Syntax  
  
```  
template<class Elem, class Tr>  
    void swap(  
        basic_ostream<Elem, Tr>& _Left,  
        basic_ostream<Elem, Tr>& _Right  
    );  
```  
  
#### Parameters  
 `_Left`  
 An lvalue reference to a `basic_ostream` object.  
  
 `_Right`  
 An lvalue reference to a `basic_ostream` object.  
  
## Remarks  
 The template function `swap` executes `_Left.swap(``_Right``)`.  
  
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [\<ostream>](../vs140/-ostream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)