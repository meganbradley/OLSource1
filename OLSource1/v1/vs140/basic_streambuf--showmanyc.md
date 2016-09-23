---
title: "basic_streambuf::showmanyc"
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
  - streambuf/std::basic_streambuf::showmanyc
  - showmanyc
  - std.basic_streambuf.showmanyc
  - std::basic_streambuf::showmanyc
  - basic_streambuf::showmanyc
  - basic_streambuf.showmanyc
dev_langs: 
  - C++
helpviewer_keywords: 
  - showmanyc method
ms.assetid: d88e39bc-ecb5-472f-9790-dd8dc59a8f61
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_streambuf::showmanyc
A protected virtual member function that returns a count of the number of characters that can be extracted from the input stream and ensure that the program will not be subject to an indefinite wait.  
  
## Syntax  
  
```  
  
virtual streamsize showmanyc( );  
  
```  
  
## Return Value  
 The default behavior is to return zero.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)