---
title: "&lt;sstream&gt; swap"
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
  - "std::swap"
  - "sstream/std::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: b20acf4b-aa75-4cc1-a941-1c40d9d23407
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;sstream&gt; swap
Exchanges the values between two `sstream` objects.  
  
## Syntax  
  
```  
template<class Elem, class Tr, class Alloc>  
    void swap(  
        basic_stringbuf<Elem, Tr, Alloc>& _Left,  
        basic_stringbuf<Elem, Tr, Alloc>& _Right  
    );  
template<class Elem, class Tr, class Alloc>  
    void swap(  
        basic_istringstream<Elem, Tr, Alloc>& _Left,  
        basic_istringstream<Elem, Tr, Alloc>& _Right  
    );  
template<class Elem, class Tr, class Alloc>  
    void swap(  
        basic_ostringstream<Elem, Tr, Alloc>& _Left,  
        basic_ostringstream<Elem, Tr, Alloc>& _Right  
    );  
template<class Elem, class Tr, class Alloc>  
    void swap(  
        basic_stringstream<Elem, Tr, Alloc>& _Left,  
        basic_stringstream<Elem, Tr, Alloc>& _Right  
    );  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|Reference to an `sstream` object.|  
|`_Right`|Reference to an `sstream` object.|  
  
## Remarks  
 The template function executes `_Left``.swap(``_Right``)`.  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [\<sstream>](../vs140/-sstream-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)