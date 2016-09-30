---
title: "Advantages of Templates"
ms.custom: na
ms.date: "09/21/2016"
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
  - "templates, advantages"
ms.assetid: 7a280702-bf36-4df5-8189-f0d443ba5202
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Advantages of Templates
You can use templates to:  
  
-   Create a typesafe collection class (for example, a stack) that can operate on data of any type.  
  
-   Add extra type checking for functions that would otherwise take <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointers.  
  
-   Encapsulate groups of operator overrides to modify type behavior (such as smart pointers).  
  
 Most of these uses can be implemented without templates; however, templates offer several advantages:  
  
-   Templates are easier to write. You create only one generic version of your class or function instead of manually creating specializations.  
  
-   Templates can be easier to understand, since they can provide a straightforward way of abstracting type information.  
  
-   Templates are typesafe. Because the types that templates act upon are known at compile time, the compiler can perform type checking before errors occur.  
  
 For more information, see:  
  
-   [Templates and Macros](#_core_When_Should_You_Use_Templates.3fAnchor1)  
  
-   [Templates and Void Pointers](#_core_When_Should_You_Use_Templates.3fAnchor2)  
  
-   [Templates and Smart Pointers](#_core_When_Should_You_Use_Templates.3fAnchor4)  
  
-   [Templates and Collection Classes](#_core_When_Should_You_Use_Templates.3fAnchor3)  
  
##  \<a name="_core_When_Should_You_Use_Templates.3fAnchor1">\</a> Templates and Macros  
 In many ways, templates work like preprocessor macros, replacing the templated variable with the given type. However, there are many differences between a macro like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 and a template:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Here are some problems with the macro:  
  
-   There is no way for the compiler to verify that the macro parameters are of compatible types. The macro is expanded without any special type checking.  
  
-   The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameters are evaluated twice. For example, if either parameter has a postincremented variable, the increment is performed two times.  
  
-   Because macros are expanded by the preprocessor, compiler error messages will refer to the expanded macro, rather than the macro definition itself. Also, the macro will show up in expanded form during debugging.  
  
##  \<a name="_core_When_Should_You_Use_Templates.3fAnchor2">\</a> Templates and Void Pointers  
 Many functions that are now implemented with void pointers can be implemented with templates. Void pointers are often used to allow functions to operate on data of an unknown type. When using void pointers, the compiler cannot distinguish types, so it cannot perform type checking or type-specific behavior such as using type-specific operators, operator overloading, or constructors and destructors.  
  
 With templates, you can create functions and classes that operate on typed data. The type looks abstracted in the template definition. However, at compile time the compiler creates a separate version of the function for each specified type. This enables the compiler to treat class and function templates as if they acted on specific types. Templates can also improve coding clarity, because you do not need to create special cases for complex types such as structures.  
  
##  \<a name="_core_When_Should_You_Use_Templates.3fAnchor4">\</a> Templates and Smart Pointers  
 C++ allows you to create smart pointer classes that encapsulate pointers and override pointer operators to add new functionality to pointer operations. Templates allow you to create generic wrappers to encapsulate pointers of almost any type.  
  
 The following code outlines a simple reference count garbage collector. The template class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> implements a garbage collecting pointer to any class derived from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Classes <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> together provide a simple garbage collection solution for any class that can afford the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> per instance overhead to inherit from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Note that the primary benefit of using a parametric class like <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instead of a more generic class like <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is that the former is completely typesafe. The preceding code ensures that a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can be used almost anywhere a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is used; in contrast, a generic <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> would only provide implicit conversions to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 For example, consider a class used to create and manipulate garbage collected files, symbols, strings, and so forth. From the class template <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the compiler will create template classes <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and so on, and their member functions: <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and so on.  
  
###  \<a name="_core_When_Should_You_Use_Templates.3fAnchor3">\</a> Templates and Collection Classes  
 Templates are a good way of implementing collection classes.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Comments  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> collection is a simple implementation of a stack. The two template parameters, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, specify the type of elements in the stack and the maximum number of that item in the stack. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> member functions add and remove items on the stack, with the stack growing from the bottom.