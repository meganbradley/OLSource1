---
title: "Using extern to Specify Linkage"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "extern"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extern keyword [C++], linkage to non-C++ functions"
  - "declarations, external"
  - "external linkage, extern modifier"
ms.assetid: 1e2f0ae3-ae98-4410-85b5-222d6abc865a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using extern to Specify Linkage
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword declares a variable or function and specifies that it has external linkage (its name is visible from files other than the one in which it's defined). When modifying a variable, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> specifies that the variable has static duration (it is allocated when the program begins and deallocated when the program ends). The variable or function may be defined in another source file, or later in the same file. Declarations of variables and functions at file scope are external by default.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In C++, when used with a string, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> specifies that the linkage conventions of another language are being used for the declarator(s). C functions and data can be accessed only if they are previously declared as having C linkage. However, they must be defined in a separately compiled translation unit.  
  
 Microsoft C++ supports the strings **"C"** and **"C++"** in the *string-literal* field. All of the standard include files use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> "C" syntax to allow the run-time library functions to be used in C++ programs.  
  
## Example  
 The following example shows alternative ways to declare names that have C linkage:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If a function has more than one linkage specification, they must agree; it is an error to declare functions as having both C and C++ linkage. Furthermore, if two declarations for a function occur in a program — one with a linkage specification and one without — the declaration with the linkage specification must be first. Any redundant declarations of functions that already have linkage specification are given the linkage specified in the first declaration. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Functions and objects explicitly declared as **static** within the body of a compound linkage specifier (**{ }**) are treated as static functions or objects; the linkage specifier is ignored. Other functions and objects behave as if declared using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword. (See [Using extern to Specify Linkage](../vs140/using-extern-to-specify-linkage.md) for details about the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword.)  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [(NOTINBUILD)Linkage Specifications](assetId:///d2b0cff1-7798-4c38-9ac8-61c3bfe2bfb9)   
 [extern Storage-Class Specifier](../vs140/extern-storage-class-specifier.md)   
 [Behavior of Identifiers](../vs140/behavior-of-identifiers.md)   
 [Linkage](../vs140/linkage.md)