---
title: "const (C++)"
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
  - "const_cpp"
  - "const"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const keyword [C++]"
ms.assetid: b21c0271-1ad0-40a0-b21c-5e812bba0318
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# const (C++)
When modifying a data declaration, the **const** keyword specifies that the object or variable is not modifiable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## const values  
 The **const** keyword specifies that a variable's value is constant and tells the compiler to prevent the programmer from modifying it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In C++, you can use the **const** keyword instead of the [#define](../vs140/sharpdefine-directive--c-c---.md) preprocessor directive to define constant values. Values defined with **const** are subject to type checking, and can be used in place of constant expressions. In C++, you can specify the size of an array with a **const** variable as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In C, constant values default to external linkage, so they can appear only in source files. In C++, constant values default to internal linkage, which allows them to appear in header files.  
  
 The **const** keyword can also be used in pointer declarations.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a variable declared as **const** can be assigned only to a pointer that is also declared as **const**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 You can use pointers to constant data as function parameters to prevent the function from modifying a parameter passed through a pointer.  
  
 For objects that are declared as **const**, you can only call [constant member functions](../vs140/constant-member-functions.md). This ensures that the constant object is never modified.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 You can call either constant or nonconstant member functions for a nonconstant object. You can also overload a member function using the **const** keyword; this allows a different version of the function to be called for constant and nonconstant objects.  
  
 You cannot declare constructors or destructors with the **const** keyword.  
  
## const member functions  
 Declaring a member function with the **const** keyword specifies that the function is a "read-only" function that does not modify the object for which it is called. A constant member function cannot modify any non-static data members or call any member functions that aren't constant.To declare a constant member function, place the **const** keyword after the closing parenthesis of the argument list. The **const** keyword is required in both the declaration and the definition.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## C and C++ const Differences  
 When you declare a variable as **const** in a C source code file, you do so as:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 You can then use this variable in another module as follows:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 But to get the same behavior in C++, you must declare your **const** variable as:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 If you wish to declare an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable in a C++ source code file for use in a C source code file, use:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 to prevent name mangling by the C++ compiler.  
  
## Remarks  
 When following a member function's parameter list, the **const** keyword specifies that the function does not modify the object for which it is invoked.  
  
 For more information on **const**, see the following topics:  
  
-   [Constant Values](../vs140/constant-values.md)  
  
-   [Constant Member Functions](../vs140/constant-member-functions.md)  
  
-   [const and volatile Pointers](../vs140/const-and-volatile-pointers.md)  
  
-   [Type Qualifiers (C Language Reference)](../vs140/type-qualifiers.md)  
  
-   [volatile](../vs140/volatile--c---.md)  
  
-   [#define](../vs140/sharpdefine-directive--c-c---.md).  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)