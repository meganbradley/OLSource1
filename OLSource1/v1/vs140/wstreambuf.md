---
title: "wstreambuf"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - wstreambuf
  - std.wstreambuf
  - iosfwd/std::wstreambuf
  - std::wstreambuf
dev_langs: 
  - C++
helpviewer_keywords: 
  - wstreambuf function
  - wstreambuf typedef
ms.assetid: b9f1b7bb-63e4-46d2-baaf-bf41b747da8b
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# wstreambuf
A specialization of `basic_streambuf` that uses `wchar_t` as the template parameters.  
  
## Syntax  
  
```  
  
typedef basic  
_  
streambuf<wchar  
_  
t, char  
_  
traits<wchar  
_  
t> > wstreambuf;  
  
```  
  
## Remarks  
 The type is a synonym for the template class [basic_streambuf](../vs140/basic_streambuf-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)