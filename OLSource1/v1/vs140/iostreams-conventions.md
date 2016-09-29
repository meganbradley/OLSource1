---
title: "iostreams Conventions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iostream header"
  - "Standard C++ Library, iostreams"
ms.assetid: 9fe5ded0-37a1-48d1-9671-c81ffc4760ad
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iostreams Conventions
The iostreams headers support conversions between text and encoded forms, and input and output to external files:  
  
|||  
|-|-|  
|[<fstream\>](../vs140/-fstream-.md)|[<iomanip\>](../vs140/-iomanip-.md)|  
|[<ios\>](../vs140/-ios-.md)|[<iosfwd\>](../vs140/-iosfwd-.md)|  
|[<iostream\>](../vs140/-iostream-.md)|[<istream\>](../vs140/-istream-.md)|  
|[<ostream\>](../vs140/-ostream-.md)|[<sstream\>](../vs140/-sstream-.md)|  
|[<streambuf\>](../vs140/-streambuf-.md)|[<strstream\>](../vs140/-strstream-.md)|  
  
 The simplest use of iostreams requires only that you include the header [<iostream\>](../vs140/-iostream-.md). You can then extract values from [cin](../vs140/cin.md) or [wcin](../vs140/wcin.md) to read the standard input. The rules for doing so are outlined in the description of the class [basic_istream Class](../vs140/basic_istream-class.md). You can also insert values to [cout](../vs140/cout.md) or [wcout](../vs140/wcout.md) to write the standard output. The rules for doing so are outlined in the description of the class [basic_ostream Class](../vs140/basic_ostream-class.md). Format control common to both extractors and insertors is managed by the class [basic_ios Class](../vs140/basic_ios-class.md). Manipulating this format information in the guise of extracting and inserting objects is the province of several manipulators.  
  
 You can perform the same iostreams operations on files that you open by name, using the classes declared in [<fstream\>](../vs140/-fstream-.md). To convert between iostreams and objects of class [basic_string Class](../vs140/basic_string-class.md), use the classes declared in [<sstream\>](../vs140/-sstream-.md). To do the same with C strings, use the classes declared in [<strstream\>](../vs140/-strstream-.md).  
  
 The remaining headers provide support services, typically of direct interest to only the most advanced users of the iostreams classes.  
  
## See Also  
 [STL Overview](../vs140/c---standard-library-overview.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)