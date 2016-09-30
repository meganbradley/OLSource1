---
title: "class (C++)"
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
  - "class_cpp"
  - "class"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "class types, class statements"
  - "class keyword [C++]"
ms.assetid: dd23c09f-6598-4069-8bff-69c7f2518b9f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# class (C++)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword declares a class type or defines an object of a class type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional template specifications. For more information, refer to [Template Specifications](../vs140/template-specifications.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional storage-class specification. For more information, refer to the [__declspec](../vs140/__declspec.md) keyword.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type name given to the class. The tag becomes a reserved word within the scope of the class. The tag is optional. If omitted, an anonymous class is defined. For more information, see [Anonymous Class Types](../vs140/anonymous-class-types.md).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Optional list of classes or structures this class will derive its members from. See [Base Classes](../vs140/base-classes.md) for more information. Each base class or structure name can be preceded by an access specifier ([public](../vs140/public--c---.md), [private](../vs140/private--c---.md), [protected](../vs140/protected--c---.md)) and the [virtual](../vs140/virtual--c---.md) keyword. See the member-access table in [Controlling Access to Class Members](../vs140/controlling-access-to-class-members.md) for more information.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 List of class members. Refer to [Class Members](../vs140/class-member-overview.md) for more information.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Declarator list specifying the names of one or more instances of the class type. Declarators may include initializer lists if all data members of the class are <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. This is more common in structures, whose data members are <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> by default, than in classes. See [Overview of Declarators](../vs140/overview-of-declarators.md) for more information.  
  
## Remarks  
 For more information on classes in general, refer to one of the following topics:  
  
-   [struct](../vs140/struct--c---.md)  
  
-   [union](../vs140/unions.md)  
  
-   [__multiple_inheritance](../vs140/inheritance-keywords.md)  
  
-   [__single_inheritance](../vs140/inheritance-keywords.md)  
  
-   [__virtual_inheritance](../vs140/inheritance-keywords.md)  
  
 For information on managed classes and structs, see [Classes and Structs](../vs140/classes-and-structs---c---component-extensions-.md)  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Classes and Structs](../vs140/classes-and-structs--c---.md)