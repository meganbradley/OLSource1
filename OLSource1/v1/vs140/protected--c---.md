---
title: "protected (C++)"
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
  - "protected"
  - "protected_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "protected keyword [C++], member access"
  - "protected keyword [C++]"
ms.assetid: 863d299f-fc0d-45d5-a1a7-bd24b7778a93
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# protected (C++)
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword specifies access to class members in the *member-list* up to the next access specifier (**public** or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) or the end of the class definition. Class members declared as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be used only by the following:  
  
-   Member functions of the class that originally declared these members.  
  
-   Friends of the class that originally declared these members.  
  
-   Classes derived with public or protected access from the class that originally declared these members.  
  
-   Direct privately derived classes that also have private access to protected members.  
  
 When preceding the name of a base class, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword specifies that the public and protected members of the base class are protected members of its derived classes.  
  
 Protected members are not as private as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> members, which are accessible only to members of the class in which they are declared, but they are not as public as **public** members, which are accessible in any function.  
  
 Protected members that are also declared as **static** are accessible to any friend or member function of a derived class. Protected members that are not declared as **static** are accessible to friends and member functions in a derived class only through a pointer to, reference to, or object of the derived class.  
  
 For related information, see [friend](../vs140/friend--c---.md), [public](../vs140/public--c---.md), [private](../vs140/private--c---.md), and the member-access table in [Controlling Access to Class Members](../vs140/controlling-access-to-class-members.md).  
  
## /clr Specific  
 In CLR types, the C++ access specifier keywords (**public**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) can affect the visibility of types and methods with regard to assemblies. For more information, see [Type and Member Visibility](../vs140/type-and-member-visibility.md).  
  
> [!NOTE]
>  Files compiled with [/LN](../vs140/-ln--create-msil-module-.md) are not affected by this behavior. In this case, all managed classes (either public or private) will be visible.  
  
## END /clr Specific  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Controlling Access to Class Members](../vs140/controlling-access-to-class-members.md)   
 [Keywords](../vs140/keywords--c---.md)