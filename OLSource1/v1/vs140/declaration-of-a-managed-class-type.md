---
title: "Declaration of a Managed Class Type"
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
  - "__gc types"
  - "classes [C++], managed"
  - "class keyword [C++], CLR"
  - "__value keyword"
  - "value types, declaring"
  - "value keyword [C++]"
  - "managed classes"
  - "interface class keyword"
  - "ref keyword [C++]"
ms.assetid: 16de9c94-91d7-492f-8ac7-f0729cc627e9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Declaration of a Managed Class Type
The way to declare a reference class type changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 In Managed Extensions, a reference class type is prefaced with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword. In the new syntax, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword is replaced by one of two spaced keywords: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The choice of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> indicates the public (for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) or private (for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) default access level of its members declared in an initial unlabeled section of the body of the type.  
  
 Similarly, in Managed Extensions, a value class type is prefaced with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword. In the new syntax, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keyword is replaced by one of two spaced keywords: <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 An interface type, in Managed Extensions, was indicated with the keyword <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. In the new syntax, this is replaced with <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 For example, the following class declarations in Managed Extensions:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Under the new syntax these are equivalently declared as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Specifying the Class as Abstract  
 Under Managed Extensions, you put the keyword <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> before the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> keyword (either before or after the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) to indicate that the class is incomplete and that objects of the class cannot be created within the program:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Under the new syntax, you specify the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> contextual keyword following the class name and before either the class body, base class derivation list, or semicolon.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Of course, the semantic meaning is unchanged.  
  
## Specifying the Class as Sealed  
 Under Managed Extensions, you put the keyword <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> before the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> keyword (either before or after <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) to indicate that objects of the class cannot be inherited from:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Under the new syntax, you specify the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> contextual keyword following the class name and before either the class body, base class derivation list, or semicolon.  
  
 You can both derive a class and seal it. For example, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class is implicitly derived from <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. The benefit of sealing a class is that it supports the static resolution (that is, at compile-time) of all virtual function calls through the sealed reference class object. This is because the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> specifier guarantees that the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> tracking handle cannot refer to a subsequently derived class that might provide an overriding instance of the virtual method being invoked. Here is an example of a sealed class in new syntax:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 One can also specify a class as both abstract and sealed – this is a special condition that indicates a static class. This is described in the CLR documentation as follows:  
  
 "A type that is both <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> should have only static members, and serves as what some languages call a namespace."  
  
 For example, here is a declaration of an abstract sealed class using the Managed Extensions syntax:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 and here is this declaration translated into the new syntax:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## CLR Inheritance: Specifying the Base Class  
 Under the CLR object model, only public single inheritance is supported. However, Managed Extensions retained the ISO-C++ default interpretation of a base class without an access keyword as specifying a private derivation. This meant that each CLR inheritance declaration had to provide the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> keyword to override the default interpretation.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 In the new syntax definition, the absence of an access keyword indicates a public derivation in a CLR inheritance definition. Thus, the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> access keyword is now optional. While this does not require any modification of Managed Extensions for C++ code, I list this change here for completeness.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## See Also  
 [The Managed Types](../vs140/managed-types--c---cl-.md)   
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)   
 [abstract (C++)](../vs140/abstract---c---component-extensions-.md)   
 [sealed](../vs140/sealed---c---component-extensions-.md)