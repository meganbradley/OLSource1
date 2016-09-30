---
title: "Generic Functions (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Generic Functions (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "functions [C++], generic"
  - "generic methods"
  - "generics [C++], functions"
  - "methods [C++], generic"
  - "generic functions"
ms.assetid: 8e409364-58f9-4360-b486-e7d555e0c218
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Functions (C++-CLI)
A generic function is a function that is declared with type parameters. When called, actual types are used instead of the type parameters.  
  
## All Platforms  
 **Remarks**  
  
 This feature does not apply to all platforms.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 **Remarks**  
  
 This feature is not supported in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 A generic function is a function that is declared with type parameters. When called, actual types are used instead of the type parameters.  
  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *attributes* (Optional)  
 Additional declarative information. For more information on attributes and attribute classes, see attributes.  
  
 *modifiers* (Optional)  
 A modifier for the function, such as static.  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not allowed since virtual methods may not be generic.  
  
 *return-type*  
 The type returned by the method. If the return type is void, no return value is required.  
  
 *identifier*  
 The function name.  
  
 *type-parameter identifier(s)*  
 Comma-separated identifiers list.  
  
 *formal-parameters* (Optional)  
 Parameter list.  
  
 *type-parameter-constraints-clauses*  
 This specifies restrictions on the types that may be used as type arguments, and takes the form specified in [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md).  
  
 *function-body*  
 The body of the method, which may refer to the type parameter identifiers.  
  
 **Remarks**  
  
 Generic functions are functions declared with a generic type parameter. They may be methods in a class or struct, or standalone functions. A single generic declaration implicitly declares a family of functions that differ only in the substitution of a different actual type for the generic type parameter.  
  
 In [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)], class or struct constructors may not be declared with generic type parameters.  
  
 When called, the generic type parameter is replaced by an actual type. The actual type may be explicitly specified in angled brackets using syntax similar to a template function call. If called without the type parameters, the compiler will attempt to deduce the actual type from the parameters supplied in the function call. If the intended type argument cannot be deduced from the parameters used, the compiler will report an error.  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code sample demonstrates a generic function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Example**  
  
 Generic functions can be overloaded based on signature or arity, the number of type parameters on a function. Also, generic functions can be overloaded with non-generic functions of the same name, as long as the functions differ in some type parameters. For example, the following functions can be overloaded:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Example**  
  
 The following example uses a generic function to find the first element in an array. It declares <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which inherits from the base class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> contains a generic function, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which calls another generic function, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, within the base class. In **main**, the generic function, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, is called using different type arguments.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **My function returned an int: 2003**   
**My function returned a string: Hello generic functions!**   
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)   
 [Generics (C++)](../vs140/generics---c---component-extensions-.md)