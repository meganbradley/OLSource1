---
title: "wistream"
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
  - "std::wistream"
  - "istream/std::wistream"
  - "wistream"
  - "std.wistream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wistream function"
ms.assetid: f01c10e4-3f9d-43e6-8dfc-b8156c732078
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wistream
A type `basic_istream` specialized on `wchar_t`.  
  
## Syntax  
  
```  
  
typedef basic  
_  
istream<wchar  
_  
t, char  
_  
traits<wchar  
_  
t> > wistream;  
  
```  
  
## Remarks  
 The type is a synonym for template class [basic_istream](../vs140/basic_istream-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
## Requirements  
 **Header:** <istream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)