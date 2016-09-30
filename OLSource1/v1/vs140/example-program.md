---
title: "Example Program"
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
  - "C"
ms.assetid: fc22ef82-9caa-425f-b201-2891bc123d1f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Example Program
The following C source program consists of two source files. It gives an overview of some of the various declarations and definitions possible in a C program. Later sections in this book describe how to write these declarations, definitions, and initializations, and how to use C keywords such as **static** and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function is declared in the C header file STDIO.H.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions are assumed to be in separate files, and execution of the program begins with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. No explicit user functions are executed before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 FILE1.C contains the prototype for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function. This kind of declaration is sometimes called a "forward declaration" because the function is declared before it is used. The definition for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function includes calls to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The lines beginning with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are preprocessor directives. These directives tell the preprocessor to replace the identifiers <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with the numbers <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, respectively, throughout FILE1.C. However, the directives do not apply to FILE2.C, which is compiled separately and then linked with FILE1.C. The line beginning with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> tells the compiler to include the file STDIO.H, which contains the prototype for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function. [Preprocessor directives](../vs140/preprocessor-directives.md) are explained in the *Preprocessor Reference*.  
  
 FILE1.C uses defining declarations to initialize the global variables <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The local variables <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are declared but not initialized. Storage is allocated for all these variables. The static and external variables, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, are automatically initialized to 0. Therefore only <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> contain meaningful values when declared because they are initialized, either explicitly or implicitly. FILE2.C contains the function definition for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. This definition satisfies the calls to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in FILE1.C.  
  
 The lifetime and visibility of identifiers are discussed in [Lifetime, Scope, Visibility, and Linkage](../vs140/lifetime--scope--visibility--and-linkage.md). For more information on functions, see [Functions](../vs140/functions--c-.md).  
  
## See Also  
 [Source Files and Source Programs](../vs140/source-files-and-source-programs.md)