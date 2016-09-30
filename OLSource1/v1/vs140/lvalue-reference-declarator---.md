---
title: "Lvalue Reference Declarator: &amp;"
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
  - "&"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference operator"
  - "& operator, reference operator"
ms.assetid: edf0513d-3dcc-4663-b276-1269795dda51
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lvalue Reference Declarator: &amp;
Holds the address of an object but behaves syntactically like an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can think of an lvalue reference as another name for an object. An lvalue reference declaration consists of an optional list of specifiers followed by a reference declarator. A reference must be initialized and cannot be changed.  
  
 Any object whose address can be converted to a given pointer type can also be converted to the similar reference type. For example, any object whose address can be converted to type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can also be converted to type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Do not confuse reference declarations with use of the [address-of operator](../vs140/address-of-operator---.md). When the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>*identifier* is preceded by a type, such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, *identifier* is declared as a reference to the type. When <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>*identifier* is not preceded by a type, the usage is that of the address-of operator.  
  
## Example  
 The following example demonstrates the reference declarator by declaring a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object and a reference to that object. Because <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a reference to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, updating either variable changes the same object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Bill is 40**   
## See Also  
 [References (C++)](../vs140/references--c---.md)   
 [Reference-Type Function Arguments](../vs140/reference-type-function-arguments.md)   
 [Reference-Type Function Returns](../vs140/reference-type-function-returns.md)   
 [References to Pointers](../vs140/references-to-pointers.md)