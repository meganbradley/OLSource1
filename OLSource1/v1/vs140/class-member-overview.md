---
title: "Class Member Overview"
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
  - "members, types of class members"
  - "members"
  - "class members, types of"
  - "class members"
ms.assetid: 8802cfa9-705d-4f37-acde-245d6838010c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class Member Overview
A class or struct consists of its members. The work that a class does is performed by its member functions. The state that it maintains is stored in its data members. Initialization of members is done by constructors, and cleanup work such as freeing of memory and releasing of resources is done by constructors. In C++11 and later, data members can (and usually should) be initialized at the point of declaration.  
  
## Kinds of class members  
 The full list of member categories is as follows:  
  
-   Special Member functions.  
  
-   [Member functions](../vs140/member-functions--c---.md).  
  
-   [Data members](../vs140/static-members--c---.md) including built-in types and other user defined types.  
  
-   Operators  
  
-   [Nested Class Declarations](../vs140/nested-class-declarations.md) and.)  
  
-   [Unions](../vs140/unions.md)  
  
-   [Enumerations](../vs140/enumerations--c---.md).  
  
-   [Bit fields](../vs140/c---bit-fields.md).  
  
-   [Friends](../vs140/friend--c---.md).  
  
-   [Aliases and typedefs](../vs140/aliases-and-typedefs--c---.md).  
  
    > [!NOTE]
    >  Friends are included in the preceding list because they are contained in the class declaration. However, they are not true class members, because they are not in the scope of the class.  
  
## Example class declaration  
 The following example shows a simple class declaration:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Member accessibility  
 The members of a class are declared in the member list. The member list of a class may be divided into any number of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and **public** sections using keywords known as access specifiers.  A colon **:** must follow the access specifier.  These sections need not be contiguous, that is, any of these keywords may appear several times in the member list.  The keyword designates the access of all members up until the next access specifier or the closing brace. For more information, see [Member Access Control (C++)](../vs140/member-access-control--c---.md).  
  
## Static members  
 A data member may be declared as static, which means all objects of the class have access to the same copy of it. A member function may be declared as static, in which case it can only access static data members of the class (and has no *this* pointer). For more information, see [Static Data Members](../vs140/static-members--c---.md).  
  
## Special member functions  
 Special member functions are functions that are automatically provided by the compiler if you do not specify them in your source code.  
  
1.  Default constructor  
  
2.  Copy constructor  
  
3.  **(C++11)** Move constructor  
  
4.  Copy assignment operator  
  
5.  **(C++11)** Move assignment operator  
  
6.  Destructor  
  
## Memberwise initialization  
 In C++11 and later, non-static member declarators can contain initializers.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If a member is assigned a value in a constructor, that value overwrites the value with which the member was initialized at the point of declaration.  
  
 There is only one shared copy of static data members for all objects of a given class type. Static data members must be defined and can be initialized at file scope. (For more information about static data members, see [Static Data Members](../vs140/static-members--c---.md).) The following example shows how to perform these initializations:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
> [!NOTE]
>  The class name, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, must precede <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to specify that the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> being defined is a member of class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## See Also  
 [Classes and Structs](../vs140/classes-and-structs--c---.md)