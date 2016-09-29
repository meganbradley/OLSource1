---
title: "streambuf"
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
  - "std.streambuf"
  - "std::streambuf"
  - "iosfwd/std::streambuf"
  - "streambuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "streambuf typedef"
  - "streambuf function"
ms.assetid: 77fd4dcd-a5b2-4d90-95de-75007e54185a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# streambuf
A specialization of `basic_streambuf` that uses `char` as the template parameters.  
  
## Syntax  
  
```  
  
typedef basic  
_  
streambuf<char, char  
_  
traits<char> > streambuf;  
  
```  
  
## Remarks  
 The type is a synonym for the template class [basic_streambuf](../vs140/basic_streambuf-class.md), specialized for elements of type `char` with default character traits.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)