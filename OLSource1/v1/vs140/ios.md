---
title: "ios"
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
  - "ios"
  - "std.ios"
  - "std::ios"
  - "iosfwd/std::ios"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ios typedef"
ms.assetid: 8c4b76e4-ce2f-45fa-80d8-70217efd2c00
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios
Supports the ios class from the old iostream library.  
  
## Syntax  
  
```  
  
typedef basic  
_  
ios<char, char  
_  
traits<char> > ios;  
  
```  
  
## Remarks  
 The type is a synonym for template class [basic_ios](../vs140/basic_ios-class.md), specialized for elements of type `char` with default character traits.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)