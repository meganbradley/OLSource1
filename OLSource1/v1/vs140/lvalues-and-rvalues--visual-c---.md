---
title: "Lvalues and Rvalues (Visual C++)"
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
  - "R-values"
  - "L-values"
ms.assetid: a8843344-cccc-40be-b701-b71f7b5cdcaf
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lvalues and Rvalues (Visual C++)
Every C++ expression is either an lvalue or an rvalue. An lvalue refers to an object that persists beyond a single expression. You can think of an lvalue as an object that has a name. All variables, including nonmodifiable (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) variables, are lvalues. An rvalue is a temporary value that does not persist beyond the expression that uses it. To better understand the difference between lvalues and rvalues, consider the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an lvalue because it persists beyond the expression that defines it. The expression <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an rvalue because it evaluates to a temporary value that does not persist beyond the expression that defines it.  
  
 The following example demonstrates several correct and incorrect usages of lvalues and rvalues:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  The examples in this topic illustrate correct and incorrect usage when operators are not overloaded. By overloading operators, you can make an expression such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> an lvalue.  
  
 The terms *lvalue* and *rvalue* are often used when you refer to object references. For more information about references, see [Lvalue Reference Declarator: &](../vs140/lvalue-reference-declarator---.md) and [Rvalue Reference Declarator: &&](../vs140/rvalue-reference-declarator----.md).  
  
## See Also  
 [Basic Concepts](../vs140/basic-concepts---c---.md)   
 [Lvalue Reference Declarator: &](../vs140/lvalue-reference-declarator---.md)   
 [Rvalue Reference Declarator: &&](../vs140/rvalue-reference-declarator----.md)