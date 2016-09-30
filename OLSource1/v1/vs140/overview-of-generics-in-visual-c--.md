---
title: "Overview of Generics in Visual C++"
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
  - "generics [C++], about generics"
  - "default initializers [C++]"
  - "type parameters [C++]"
  - "constructed types"
  - "type arguments [C++]"
  - "constructed types, open [C++]"
  - "open constructed types [C++]"
  - "constructed types, closed [C++]"
ms.assetid: 21f10637-0fce-4916-b925-6c86a126d3aa
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overview of Generics in Visual C++
Generics are parameterized types supported by the common language runtime. A parameterized type is a type that is defined with an unknown type parameter that is specified when the generic is used.  
  
## Why Generics?  
 C++ supports templates and both templates and generics support parameterized types to create typed collection classes. However, templates provide compile-time parameterization. You cannot reference an assembly containing a template definition and create new specializations of the template. Once compiled, a specialized template looks like any other class or method. In contrast, generics are emitted in MSIL as a parameterized type known by the runtime to be a parameterized type; source code that references an assembly containing a generic type can create specializations of the generic type. For more information on the comparison of Visual C++ templates and generics, see [Generics and Templates](../vs140/generics-and-templates--visual-c---.md).  
  
## Generic Functions and Types  
 Class types, as long as they are managed types, may be generic. An example of this might be a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class. The type of an object in the list would be the type parameter. If you needed a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class for many different types of objects, before generics you might have used a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that takes **System::Object** as the item type. But that would allow any object (including objects of the wrong type) to be used in the list. Such a list would be called an untyped collection class. At best, you could check the type at runtime and throw an exception. Or, you might have used a template, which would lose its generic quality once compiled into an assembly. Consumers of your assembly could not create their own specializations of the template. Generics allow you to create typed collection classes, say <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (read as "List of int") and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> ("List of double") which would generate a compile-time error if you tried to put a type that the collection was not designed to accept into the typed collection. In addition, these types remain generic after they are compiled.  
  
 A description of the syntax of generic classes may be found in [Generic Classes (C++)](../vs140/generic-classes--c---cli-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> A new namespace, \<xref:System.Collections.Generic*>, introduces a set of parameterized collection types including <xref:System.Collections.Generic.Dictionary<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1*> and <xref:System.Collections.Generic.LinkedList<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>List<int><CodeContentPlaceHolder>10\</CodeContentPlaceHolder>List<T><CodeContentPlaceHolder>11\</CodeContentPlaceHolder>List<double>,<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>// generics_overview.cpp<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
##### Constraint  
 A constraint is a restriction on the types that may be used as a type parameter. For example, a given generic class could accept only classes that inherit from a specified class, or implement a specified interface. For more information, see [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md).  
  
## Reference Types and Value Types  
 Handles types and value types may be used as type arguments. In the generic definition, in which either type may be used, the syntax is that of reference types. For example, the **->** operator is used to access members of the type of the type parameter whether or not the type eventually used is a reference type or a value type. When a value type is used as the type argument, the runtime generates code that uses the value types directly without boxing the value types.  
  
 When using a reference type as a generic type argument, use the handle syntax. When using a value type as a generic type argument, use the name of the type directly.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
## Type Parameters  
 Type parameters in a generic class are treated like other identifiers. However, because the type is not known, there are restrictions on their use. For example, you cannot use members and methods of the type parameter class unless the type parameter is known to support these members. That is, to access a member through the type parameter, you must add the type that contains the member to the type parameter's constraint list.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 These restrictions apply to operators as well. An unconstrained generic type parameter may not use the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operators to compare two instances of the type parameter, in case the type does not support these operators. These checks are necessary for generics, but not for templates, because generics may be specialized at runtime with any class that satisfies the constraints, when it is too late to check for the use of invalid members.  
  
 A default instance of the type parameter may be created by using the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator. For example:  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 where <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is a type parameter in a generic class or method definition, initializes the variable to its default value. If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is a ref class it will be a null pointer; if <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is a value class, the object is initialized to zero. This is called a *default initializer*.  
  
## See Also  
 [Generics (C++)](../vs140/generics---c---component-extensions-.md)