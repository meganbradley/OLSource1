---
title: "CRT Initialization"
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
  - "CRT initialization [C++]"
ms.assetid: e7979813-1856-4848-9639-f29c86b74ad7
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRT Initialization
This topic describes how the CRT initializes global states in native code.  
  
 By default, the linker includes the CRT library, which provides its own startup code. This startup code initializes the CRT library, calls global initializers, and then calls the user-provided <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function for console applications.  
  
## Initializing a Global Object  
 Consider the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 According to the C/C++ standard, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be called before <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is executed. But who calls it?  
  
 One way to determine this is to set a breakpoint in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, debug the application, and examine the stack. This is possible because the CRT source code is included with Visual Studio.  
  
 When you browse the functions on the stack, you will find that the CRT is looping through a list of function pointers and calling each one as it encounters them. These functions are either similar to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or constructors for class instances.  
  
 The CRT obtains the list of function pointers from the Visual C++ compiler. When the compiler sees a global initializer, it generates a dynamic initializer in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section (where <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the section name and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the group name). To obtain a list of those dynamic initializers run the command **dumpbin /all main.obj**, and then search the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> section (when main.cpp is compiled as a C++ file, not a C file). It will be similar to the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The CRT defines two pointers:  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 Both groups do not have any other symbols defined except <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 Now, when the linker reads various <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> groups, it combines them in one section and orders them alphabetically. This means that the user-defined global initializers (which the Visual C++ compiler puts in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) will always come after <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and before <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The section will resemble the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 So, the CRT library uses both <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to determine the start and end of the global initializers list because of the way in which they are laid out in memory after the image is loaded.  
  
## See Also  
 [C Run-Time Libraries](../vs140/crt-library-features.md)