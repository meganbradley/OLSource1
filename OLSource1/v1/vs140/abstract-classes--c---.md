---
title: "Abstract Classes (C++)"
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
  - "classes [C++], abstract"
  - "base classes, abstract classes"
  - "abstract classes"
  - "derived classes, abstract classes"
ms.assetid: f0c5975b-39de-4d68-9640-6ce57f4632e6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Abstract Classes (C++)
Abstract classes act as expressions of general concepts from which more specific classes can be derived. You cannot create an object of an abstract class type; however, you can use pointers and references to abstract class types.  
  
 A class that contains at least one pure virtual function is considered an abstract class. Classes derived from the abstract class must implement the pure virtual function or they, too, are abstract classes.  
  
 A virtual function is declared as "pure" by using the *pure-specifier* syntax (described in [Class Protocol Implementation](assetId:///a319f1b3-05e8-400e-950a-1ca6eb105ab5)). Consider the example presented in [Virtual Functions](../vs140/virtual-functions.md). The intent of class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is to provide general functionality, but objects of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are too general to be useful. Therefore, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a good candidate for an abstract class:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The only difference between this declaration and the previous one is that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is declared with the pure specifier (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Restrictions on abstract classes  
 Abstract classes cannot be used for:  
  
-   Variables or member data  
  
-   Argument types  
  
-   Function return types  
  
-   Types of explicit conversions  
  
 Another restriction is that if the constructor for an abstract class calls a pure virtual function, either directly or indirectly, the result is undefined. However, constructors and destructors for abstract classes can call other member functions.  
  
 Pure virtual functions can be defined for abstract classes, but they can be called directly only by using the syntax:  
  
 *abstract-class-name* <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> *function-name***( )**  
  
 This helps when designing class hierarchies whose base class(es) include pure virtual destructors, because base class destructors are always called in the process of destroying an object. Consider the following example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When the object pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is deleted, the destructor for class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is called and then the destructor for class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is called. The empty implementation for the pure virtual function ensures that at least some implementation exists for the function.  
  
> [!NOTE]
>  In the preceding example, the pure virtual function <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is called implicitly from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. It is also possible to call pure virtual functions explicitly using a fully qualified member-function name.  
  
## See Also  
 [Inheritance](../vs140/inheritance---c---.md)