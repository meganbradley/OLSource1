---
title: "basic_streambuf::basic_streambuf"
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
  - "std.basic_streambuf.basic_streambuf"
  - "basic_streambuf"
  - "basic_streambuf::basic_streambuf"
  - "std::basic_streambuf::basic_streambuf"
  - "streambuf/std::basic_streambuf::basic_streambuf"
  - "basic_streambuf.basic_streambuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_streambuf class, constructor"
  - "basic_streambuf method"
ms.assetid: 3d698d34-d9c6-49e2-8e37-246dff22af04
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::basic_streambuf
Constructs an object of type `basic_streambuf`.  
  
## Syntax  
  
```  
basic_streambuf( );  
basic_streambuf(const basic_streambuf& _Right);  
```  
  
#### Parameters  
 `_Right`  
 An lvalue reference to the `basic_streambuf` object that is used to set the values for this `basic_streambuf` object.  
  
## Remarks  
 The first protected constructor stores a null pointer in all pointers controlling the input buffer and the output buffer. It also stores `locale::classic` in the locale object. For more information, see [locale::classic](../vs140/locale--classic.md).  
  
 The second protected constructor copies the pointers and locale from `_Right`.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)