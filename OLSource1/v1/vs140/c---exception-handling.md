---
title: "C++ Exception Handling"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C++ exception handling"
  - "Visual C++, exception handling"
ms.assetid: 65f80b44-9d0f-4d17-b910-07205a5c5c40
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C++ Exception Handling
The C++ language provides built-in support for throwing and catching exceptions. When programming in C++, you should almost always use the built-in C++ exception support as described in this section.  
  
 To enable C++ exception handling in your code, use [/EHsc](../vs140/-eh--exception-handling-model-.md).  
  
## In This Section  
 This discussion on C++ exception handling includes:  
  
-   [The try, catch, and throw Statements](../vs140/try--throw--and-catch-statements--c---.md)  
  
-   [How Catch Blocks are Evaluated](../vs140/how-catch-blocks-are-evaluated--c---.md)  
  
-   [Exceptions and Stack Unwinding](../vs140/exceptions-and-stack-unwinding-in-c--.md)  
  
-   [Exception Specifications](../vs140/exception-specifications--throw---c---.md)  
  
-   [noexcept](../vs140/noexcept--c---.md)  
  
-   [Unhandled C++ Exceptions](../vs140/unhandled-c---exceptions.md)  
  
-   [Mixing C (Structured) and C++ Exceptions](../vs140/mixing-c--structured--and-c---exceptions.md)  
  
## Support for Earlier MFC Exceptions  
 As of version 4.0, MFC began using the C++ exception handling mechanism. Although you are encouraged to use C++ exception handling in new code, MFC version 4.0 and later retains the macros from previous versions of MFC so that old code will not be broken. The macros and the new mechanism can be combined as well. For information on mixing macros and C++ exception handling and on converting old code to use the new mechanism, see the articles [Exceptions: Using MFC Macros and C++ Exceptions](../vs140/exceptions--using-mfc-macros-and-c---exceptions.md) and [Exceptions: Converting from MFC Exception Macros](../vs140/exceptions--converting-from-mfc-exception-macros.md). The older MFC exception macros, if you still use them, evaluate to C++ exception keywords. See [Exceptions: Changes to Exception Macros in Version 3.0](../vs140/exceptions--changes-to-exception-macros-in-version-3.0.md).  
  
## See Also  
 [Exception Handling](../vs140/exception-handling-in-visual-c--.md)