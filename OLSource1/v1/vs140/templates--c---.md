---
title: "Templates (C++)"
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
  - "template"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "templates, C++"
  - "templates"
ms.assetid: 90fcc14a-2092-47af-9d2e-dba26d25b872
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Templates (C++)
Templates are the basis for generic programming in C++. As a strongly-typed language, C++ requires all variables to have a specific type, either explicitly declared by the programmer or deduced by the compiler. However, many data structures and algorithms look the same no matter what type they are operating on. Templates enable you to define the operations of a class or function, and let the user specify what concrete types those operations should work on.  
  
## Defining and using templates  
 A template is a construct that generates an ordinary type or function at compile time based on arguments the user supplies for the template parameters. For example, you can define a function template like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The above code describes a template for a generic function with a single type parameter <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, whose return value and call parameters (lhs and rhs) are all of this type. You can name a type parameter anything you like, but by convention single upper case letters are most commonly used. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a template parameter; the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keyword says that this parameter is a placeholder for a type. When the function is called, the compiler will replace every instance of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> with the concrete type argument that is either specified by the user or deduced by the compiler. The process in which the compiler generates a class or function from a template is referred to as  *template instantiation*;   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is an instantiation of the template <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 Elsewhere, a user can declare an instance of the template  that is specialized for int. Assume that get_a() and get_b() are functions that return an int:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 However, because this is a function template and the compiler can deduce the type of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> from the arguments <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, you can call it just like an ordinary function:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 When the compiler encounters that last statement, it generates a new function in which every occurrence of *T* in the template is replaced with <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The rules for how the compiler performs type deduction in function templates are based on the rules for ordinary functions. For more information, see [Overload Resolution in Function Templates](../vs140/overload-resolution-of-function-template-calls.md).  
  
## Type parameters  
 In the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> template above, note that the type parameter <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is not qualified in any way until it is used in the function call parameters, where the const and reference qualifiers are added.  
  
 There is no practical limit to the number of type parameters. Separate multiple parameters by commas:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The keyword <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> in this context. You can express the previous example as:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 You can use the ellipses operator (...) to define a template that takes an arbitrary number of zero or more type parameters:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Any built-in or user-defined type can be used as a type argument. For example, you can use std::vector in the Standard Library to store ints, doubles, strings, MyClass, const MyClass*, MyClass&. The primary restriction when using templates is that a type argument must support any operations that are applied to the type parameters. For example, if we call minimum using MyClass as in this example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A compiler error will be generated because MyClass does not provide an overload for the < operator.  
  
 There is no inherent requirement that the type arguments for any particular template all belong to the same object hierarchy, although you can define a template that enforces such a restriction. You can combine object-oriented techniques with templates; for example, you can store a Derived* in a vector\<Base\*>.    Note that the arguments must be pointers  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The basic requirements that vector and other standard library containers impose on elements of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is that <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> be copy-assignable and copy-constructible.  
  
## Non-type parameters  
 Unlike generic types in other languages such as C# and Java, C++ templates support non-type parameters, also called value parameters. For example, you can provide a constant integral value to specify the length of an array, as with this example that is similar to the std::array class in the Standard Library:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Note the syntax in the template declaration. The size_t value is passed in as a template argument at compile time and must be constant or a constexpr expression. You use it like this:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Other kinds of values including pointers and references can be passed in as non-type parameters. For example, you can pass in a pointer to a function or function object to customize some operation inside the template code.  
  
## Templates as template parameters  
 A template can be a template parameter. In this example, MyClass2 has two template parameters: a typename parameter <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and a template parameter <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Because the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter itself has no body, its parameter names are not needed. In fact, it is an error to refer to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>'s typename or class parameter names from within the body of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For this reason,  <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>'s type parameter names can be omitted, as shown in this example:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## Default template arguments  
 Class and function templates can have default arguments. When a template has a default argument you can leave it unspecified when you use it. For example, the std::vector template has a default argument for the allocator:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 In most cases the default std::allocator class is acceptable, so you use a vector like this:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 But if necessary you can specify a custom allocator like this:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 For multiple template arguments, all arguments after the first default argument must have default arguments.  
  
 When using a template whose parameters are all defaulted, use empty angle brackets:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## Template specialization  
 In some cases, it isn’t possible or desirable for a template to define exactly the same code for any type. For example, you might wish to define a code path to be executed only if the type argument is a pointer, or a std::wstring, or a type derived from a particular base class.  In such cases you can define a *specialization* of the template for that particular type. When a user instantiates the template with that type, the compiler uses the specialization to generate the class, and for all other types, the compiler chooses the more general template. Specializations in which all parameters are specialized are *complete specializations*. If only some of the parameters are specialized, it is called a *partial specialization*.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A template can have any number of specializations as long as each specialized type parameter is unique.   Only class templates may be partially specialized. All complete and partial specializations of a template must be declared in the same namespace as the original template.  
  
 For more information, see [Template Specialization](../vs140/template-specialization--c---.md).