---
title: "Access Control (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "private keyword [F#]"
  - "access control [F#]"
  - "internal keyword [F#]"
  - "public keyword [F#]"
ms.assetid: 25201d78-1023-405c-be3a-f8c5f42379c4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Access Control (F#)
*Access control* refers to declaring which clients can use certain program elements, such as types, methods, and functions.  
  
## Basics of Access Control  
 In F#, the access control specifiers <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can be applied to modules, types, methods, value definitions, functions, properties, and explicit fields.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> indicates that the entity can be accessed by all callers.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> indicates that the entity can be accessed only from the same assembly.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> indicates that the entity can be accessed only from the enclosing type or module.  
  
> [!NOTE]
>  The access specifier <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not used in F#, although it is acceptable if you are using types authored in languages that do support <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> access. Therefore, if you override a protected method, your method remains accessible only within the class and its descendents.  
  
 In general, the specifier is put in front of the name of the entity, except when a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specifier is used, which appear after the access control specifier.  
  
 If no access specifier is used, the default is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, except for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bindings in a type, which are always <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to the type.  
  
 Signatures in F# provide another mechanism for controlling access to F# program elements. Signatures are not required for access control. For more information, see [Signatures (F#)](../vs140/signatures--fsharp-.md).  
  
## Rules for Access Control  
 Access control is subject to the following rules:  
  
-   Inheritance declarations (that is, the use of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to specify a base class for a class), interface declarations (that is, specifying that a class implements an interface), and abstract members always have the same accessibility as the enclosing type. Therefore, an access control specifier cannot be used on these constructs.  
  
-   Individual cases in a discriminated union cannot have their own access control modifiers separate from the union type.  
  
-   Individual fields of a record type cannot have their own access control modifiers separate from the record type.  
  
## Example  
 The following code illustrates the use of access control specifiers. There are two files in the project, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Each file is implicitly a module. Therefore, there are two modules, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. A private type and an internal type are defined in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The private type cannot be accessed from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, but the internal type can.  
  
 [!code[FsAccessControl#1](../vs140/codesnippet/FSharp/access-control--fsharp-_1.fs)]  
  
 The following code tests the accessibility of the types created in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 [!code[FsAccessControl#2](../vs140/codesnippet/FSharp/access-control--fsharp-_2.fs)]  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Signatures (F#)](../vs140/signatures--fsharp-.md)