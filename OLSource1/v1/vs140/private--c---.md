---
title: "private (C++)"
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
  - "private_cpp"
  - "private"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "private keyword [C++]"
ms.assetid: 94e99983-46a5-4e21-800c-28f8a7c6a8ff
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# private (C++)
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When preceding a list of class members, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword specifies that those members are accessible only from member functions and friends of the class. This applies to all members declared up to the next access specifier or the end of the class.  
  
 When preceding the name of a base class, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword specifies that the public and protected members of the base class are private members of the derived class.  
  
 Default access of members in a class is private. Default access of members in a structure or union is public.  
  
 Default access of a base class is private for classes and public for structures. Unions cannot have base classes.  
  
 For related information, see [friend](../vs140/friend--c---.md), [public](../vs140/public--c---.md), [protected](../vs140/protected--c---.md), and the member-access table in [Controlling Access to Class Members](../vs140/controlling-access-to-class-members.md).  
  
## /clr Specific  
 In CLR types, the C++ access specifier keywords (**public**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) can affect the visibility of types and methods with regard to assemblies. For more information, see [Type and Member Visibility](../vs140/type-and-member-visibility.md).  
  
> [!NOTE]
>  Files compiled with [/LN](../vs140/-ln--create-msil-module-.md) are not affected by this behavior. In this case, all managed classes (either public or private) will be visible.  
  
## END /clr Specific  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Controlling Access to Class Members](../vs140/controlling-access-to-class-members.md)   
 [Keywords](../vs140/keywords--c---.md)