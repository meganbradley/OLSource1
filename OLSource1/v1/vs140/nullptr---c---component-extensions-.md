---
title: "nullptr  (C++ Component Extensions)"
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
  - "__nullptr keyword (C++)"
  - "nullptr keyword [C++]"
ms.assetid: 594cfbf7-06cb-4366-9ede-c0b703e1d095
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nullptr  (C++ Component Extensions)
The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword represents a *null pointer value*. Use a null pointer value to indicate that an object handle, interior pointer, or native pointer type does not point to an object.  
  
 Use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with either managed or native code. The compiler emits appropriate but different instructions for managed and native null pointer values. For information about using the ISO standard C++ version of this keyword, see [nullptr](../vs140/nullptr.md).  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword is a Microsoft-specific keyword that has the same meaning as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, but applies to only native code. If you use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with native C/C++ code and then compile with the [/clr](../vs140/-clr--common-language-runtime-compilation-.md) compiler option, the compiler cannot determine whether <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> indicates a native or managed null pointer value. To make your intention clear to the compiler, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to specify a managed value or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to specify a native value.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword is equivalent to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in Visual Basic and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in C#.  
  
## Usage  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword can be used anywhere a handle, native pointer, or function argument can be used.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keyword is not a type and is not supported for use with:  
  
-   [sizeof](../vs140/sizeof-operator.md)  
  
-   [typeid](../vs140/typeid-operator.md)  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (although <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> will work)  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> keyword can be used in the initialization of the following pointer types:  
  
-   Native pointer  
  
-   Windows Runtime handle  
  
-   Managed handle  
  
-   Managed interior pointer  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> keyword can be used to test if a pointer or handle reference is null before the reference is used.  
  
 Function calls among languages that use null pointer values for error checking should be interpreted correctly.  
  
 You cannot initialize a handle to zero; only <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> can be used. Assignment of constant 0 to an object handle produces a boxed <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and a cast to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
## Example  
 The following code example demonstrates that the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> keyword can be used wherever a handle, native pointer, or function argument can be used. And the example demonstrates that the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> keyword can be used to check a reference before it is used.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 **Example**  
  
 The following code example shows that <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and zero can be used interchangeably on native pointers.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **pMyClass == nullptr**   
 **pMyClass == 0**   
 **pMyClass == nullptr**   
 **pMyClass == 0**   
## Example  
 **Example**  
  
 The following code example shows that <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is interpreted as a handle to any type or a native pointer to any type. In case of function overloading with handles to different types, an ambiguity error will be generated. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> would have to be explicitly cast to a type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 **Example**  
  
 The following code example shows that casting <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is allowed and returns a pointer or handle to the cast type that contains the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 **Example**  
  
 The following code example shows that <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> can be used as a function parameter.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **test**   
## Example  
 **Example**  
  
 The following code example shows that when handles are declared and not explicitly initialized, they are default initialized to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 **NULL**   
## Example  
 **Example**  
  
 The following code example shows that <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> can be assigned to a native pointer when you compile with **/clr**.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Requirements  
 Compiler option: (Not required; supported by all code generation options, including **/ZW** and **/clr**)  
  
## See Also  
 [Component Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)   
 [nullptr](../vs140/nullptr.md)