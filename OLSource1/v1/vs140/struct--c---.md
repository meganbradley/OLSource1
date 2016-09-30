---
title: "struct (C++)"
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
  - "struct"
  - "struct_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "struct constructors"
ms.assetid: 3c6ba273-e248-4ff1-8c69-d2abcf1263c6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# struct (C++)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword defines a structure type and/or a variable of a structure type.  
  
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
 The type name given to the structure. The tag becomes a reserved word within the scope of the structure. The tag is optional. If omitted, an anonymous structure is defined. For more information, see [Anonymous Class Types](../vs140/anonymous-class-types.md).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Optional list of classes or structures this structure will derive its members from. See [Base Classes](../vs140/base-classes.md) for more information. Each base class or structure name can be preceded by an access specifier ([public](../vs140/public--c---.md), [private](../vs140/private--c---.md), [protected](../vs140/protected--c---.md)) and the [virtual](../vs140/virtual--c---.md) keyword. See the member-access table in [Controlling Access to Class Members](../vs140/controlling-access-to-class-members.md) for more information.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 List of structure members. Refer to [Class Members](../vs140/class-member-overview.md) for more information. The only difference here is that <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is used in place of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Declarator list specifying the names of the class. Declarator lists declare one or more instances of the structure type. Declarators may include initializer lists if all data members of the class are <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Initializer lists are common in structures because data members are <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> by default.  See [Overview of Declarators](../vs140/overview-of-declarators.md) for more information.  
  
## Remarks  
 A structure type is a user-defined composite type. It is composed of fields or members that can have different types.  
  
 In C++, a structure is the same as a class except that its members are <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> by default.  
  
 For information on managed classes and structs, see [Classes and Structs](../vs140/classes-and-structs---c---component-extensions-.md).  
  
## Using a Structure  
 In C, you must explicitly use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword to declare a structure. In C++, you do not need to use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword after the type has been defined.  
  
 You have the option of declaring variables when the structure type is defined by placing one or more comma-separated variable names between the closing brace and the semicolon.  
  
 Structure variables can be initialized. The initialization for each variable must be enclosed in braces.  
  
 For related information, see [class](../vs140/class--c---.md), [union](../vs140/unions.md), and [enum](../vs140/enumerations--c---.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [(NOTINBUILD) Defining Class Types](assetId:///e8c65425-0f3a-4dca-afc2-418c3b1e57da)