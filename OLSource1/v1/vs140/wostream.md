---
title: "wostream"
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
  - std::wostream
  - wostream
  - std.wostream
  - iosfwd/std::wostream
dev_langs: 
  - C++
helpviewer_keywords: 
  - wostream typedef
  - wostream function
ms.assetid: 304ced2a-322b-4175-9395-793ded75f6c2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# wostream
Creates a type from basic_ostream that is specialized on `wchar_t` and `char_traits` specialized on `wchar_t`.  
  
## Syntax  
  
```  
  
typedef basic  
_  
ostream<wchar  
_  
t, char  
_  
traits<wchar  
_  
t> > wostream;  
  
```  
  
## Remarks  
 The type is a synonym for template class [basic_ostream](../vs140/basic_ostream-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
## Requirements  
 **Header:** <ostream\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)