---
title: "Generic Interfaces (Visual C++)"
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
  - "generic interfaces"
  - "interfaces, generic [C++}"
ms.assetid: f3da788a-ba83-4db7-9dcf-9b95a8fb9d1a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Interfaces (Visual C++)
The restrictions that apply to type parameters on classes are the same as those that apply to type parameters on interfaces (see [Generic Classes (C++)](../vs140/generic-classes--c---cli-.md)).  
  
 The rules that control function overloading are the same for functions within generic classes or generic interfaces.  
  
 Explicit interface member implementations work with constructed interface types in the same way as with simple interface types (see the following examples).  
  
 For more information on interfaces, see [interface class](../vs140/interface-class---c---component-extensions-.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 *attributes* (optional)  
 Additional declarative information. For more information on attributes and attribute classes, see Attributes.  
  
 *class-key*  
 **class** or **typename**  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Comma-separated identifiers list.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Takes the form specified in [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md)  
  
 *accessibility-modifiers* (optional)  
 Accessibility modifiers (e.g. **public, private**).  
  
 *identifier*  
 The interface name.  
  
 *base-list* (optional)  
 A list that contains one or more explicit base interfaces separated by commas.  
  
 *interface-body*  
 Declarations of the interface members.  
  
 *declarators* (optional)  
 Declarations of variables based on this type.  
  
## Example  
 The following example demonstrates how to declare and instantiate a generic interface. In the example, the generic interface <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is declared. It is then implemented by two generic classes, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, with different implementations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Linked List**  
**List1**  
**Array List**  
**List2**   
## Example  
 This example declares a generic interface, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and two non-generic interfaces, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, that specialize <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The two specialized interfaces are then implemented by two classes, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The example shows how to specialize generic interfaces, instantiate generic and non-generic interfaces, and call the explicitly implemented members on the interfaces.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **The integer field contains: 1234**  
**The String field contains: My string**   
## See Also  
 [Generics (C++)](../vs140/generics---c---component-extensions-.md)