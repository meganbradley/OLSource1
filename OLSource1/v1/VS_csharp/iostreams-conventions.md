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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iostreams Conventions
The iostreams headers support conversions between text and encoded forms, and input and output to external files:  
  
|||  
|-|-|  
|[<fstream\>](../VS_csharp/-fstream-.md)|[<iomanip\>](../VS_csharp/-iomanip-.md)|  
|[<ios\>](../VS_csharp/-ios-.md)|[<iosfwd\>](../VS_csharp/-iosfwd-.md)|  
|[<iostream\>](../VS_csharp/-iostream-.md)|[<istream\>](../VS_csharp/-istream-.md)|  
|[<ostream\>](../VS_csharp/-ostream-.md)|[<sstream\>](../VS_csharp/-sstream-.md)|  
|[<streambuf\>](../VS_csharp/-streambuf-.md)|[<strstream\>](../VS_csharp/-strstream-.md)|  
  
 The simplest use of iostreams requires only that you include the header [<iostream\>](../VS_csharp/-iostream-.md). You can then extract values from [cin](../Topic/cin.md) or [wcin](../Topic/wcin.md) to read the standard input. The rules for doing so are outlined in the description of the class [basic_istream Class](../VS_csharp/basic_istream-class.md). You can also insert values to [cout](../Topic/cout.md) or [wcout](../Topic/wcout.md) to write the standard output. The rules for doing so are outlined in the description of the class [basic_ostream Class](../VS_csharp/basic_ostream-class.md). Format control common to both extractors and insertors is managed by the class [basic_ios Class](../VS_csharp/basic_ios-class.md). Manipulating this format information in the guise of extracting and inserting objects is the province of several manipulators.  
  
 You can perform the same iostreams operations on files that you open by name, using the classes declared in [<fstream\>](../VS_csharp/-fstream-.md). To convert between iostreams and objects of class [basic_string Class](../VS_csharp/basic_string-class.md), use the classes declared in [<sstream\>](../VS_csharp/-sstream-.md). To do the same with C strings, use the classes declared in [<strstream\>](../VS_csharp/-strstream-.md).  
  
 The remaining headers provide support services, typically of direct interest to only the most advanced users of the iostreams classes.  
  
## See Also  
 [STL Overview](../VS_csharp/c---standard-library-overview.md)   
 [iostream Programming](../VS_csharp/iostream-programming.md)   
 [Thread Safety in the C++ Standard Library](../VS_csharp/thread-safety-in-the-c---standard-library.md)