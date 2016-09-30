---
title: "String and I-O Formatting (Modern C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "String and I/O Formatting (Modern C++)"
dev_langs: 
  - "C++"
ms.assetid: 3954e8de-a59b-4175-89c9-4ee842ab89ed
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String and I-O Formatting (Modern C++)
C++ [iostreams](../vs140/-iostream-.md) are capable of formatted string I/O. For example, the following code shows how to set cout to format an integer to output in hexadecimal, first saving off the current state and re-setting afterwards, because once state formatting is passed to cout, it stays that way until changed, not just for the one line of code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This can be entirely too cumbersome in many cases. As an alternative, you can use Boost.Format from the Boost C++ libraries, even though it’s nonstandard. You can download any Boost library from the [Boost](http://www.boost.org/) website.  
  
 Some advantages of Boost.Format are:  
  
-   Safe: Type-safe, and throws an exception for errors—for example, the specification of too few or too many items.  
  
-   Extensible: Works for any type that can be streamed.  
  
-   Convenient: Standard Posix and similar format strings.  
  
 Although Boost.Format is built on C++ [iostreams](../vs140/iostream-programming.md), which are safe and extensible, they aren't performance-optimized. When you require performance optimization, consider C [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md) and [sprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md), which are fast and easy to use. However, they are not extensible or safe from vulnerabilities. (Safe versions exist, but they incur a slight performance penalty. For more information, see [printf_s](../vs140/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md) and [sprintf_s](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md)).  
  
 The following code demonstrates some of the Boost formatting features.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Welcome Back to C++](../vs140/welcome-back-to-c----modern-c---.md)   
 [C++ Language Reference](../vs140/c---language-reference.md)   
 [Standard C++ Library](../vs140/c---standard-library-reference.md)   
 [iostream](../vs140/-iostream-.md)   
 [limits](../vs140/-limits-.md)   
 [iomanip](../vs140/-iomanip-.md)