---
title: "&lt;istream&gt; swap"
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
  - "std.swap"
  - "std:swap"
  - "istream/std::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: d7e5f416-e5d0-43ac-9c5f-b04d0b9d8381
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# &lt;istream&gt; swap
Exchanges the elements of two stream objects.  
  
## Syntax  
  
```  
template<class Elem, class Tr>  
    void swap(  
        basic_istream<Elem, Tr>& _Left,  
        basic_istream<Elem, Tr>& _Right  
    );  
template<class Elem, class Tr>  
    void swap(  
        basic_iostream<Elem, Tr>& _Left,  
        basic_iostream<Elem, Tr>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 A stream.  
  
 `_Right`  
 A stream.  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [\<istream>](../vs140/-istream-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)