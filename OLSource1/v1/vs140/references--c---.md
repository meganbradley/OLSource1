---
title: "References (C++)"
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
  - "objects [C++], referencing"
  - "references"
  - "references, to pointers"
  - "declarations, references"
  - "references, declaring"
  - "referencing objects, declarator syntax"
ms.assetid: 68156f7f-97a0-4b66-b26d-b25ade5e3bd8
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# References (C++)
A reference, like a pointer, stores the address of an object that is located elsewhere in memory. Unlike a pointer, a reference after it is initialized cannot be made to refer to a different object or set to null. There are two kinds of references: lvalue references which refer to a named variable and rvalue references which refer to a [temporary object](../vs140/temporary-objects.md). The & operator signifies an lvalue reference and the && operator signifies either an rvalue reference, or a universal reference (either rvalue or lvalue) depending on the context.  
  
 References may be declared using the following syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Any valid declarator specifying a reference may be used. Unless the reference is a reference to function or array type, the following simplified syntax applies:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 References are declared using the following sequence:  
  
 1. The declaration specifiers:  
  
-   An optional storage class specifier.  
  
-   Optional **const** and/or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> qualifiers.  
  
-   The type specifier: the name of a type.  
  
-   2. The declarator:  
  
-   An optional Microsoft specific modifier. For more information, see [Microsoft-Specific Modifiers](../vs140/microsoft-specific-modifiers.md).  
  
-   The & operator or && operator.  
  
-   Optional **const** and/or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> qualifers.  
  
-   The identifier.  
  
 3. An optional initializer.  
  
 The more complex declarator forms for pointers to arrays and functions also apply to references to arrays and functions, see [pointers](../vs140/pointers--c---.md) and [declarators](assetId:///8a7b9b51-92bd-4ac0-b3fe-0c4abe771838).  
  
 Multiple declarators and initializers may appear in a comma-separated list following a single declaration specifier. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 References, pointers and objects may be declared together:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference holds the address of an object, but behaves syntactically like an object.  
  
 In the following program, notice that the name of the object, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and the reference to the object, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, can be used identically in programs:  
  
## Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **3**  
**3**  
**4**  
**4**   
## Comment  
 Topics in this section:  
  
-   [Reference-Type Function Arguments](../vs140/reference-type-function-arguments.md)  
  
-   [Reference-Type Function Returns](../vs140/reference-type-function-returns.md)  
  
-   [References to Pointers](../vs140/references-to-pointers.md)  
  
## See Also  
 [Initializing References](../vs140/initializing-references.md)