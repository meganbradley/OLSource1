---
title: "Function Call (C++)"
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
  - "function calls, C++ functions"
  - "functions [C++], calling"
  - "operator overloading, function calls"
  - "function overloading, function-call operator"
  - "function calls, operator"
  - "operators [C++], overloading"
  - "operator overloading, examples"
  - "function call operator ( )"
ms.assetid: 5094254a-045b-46f7-8653-69bc91e80dce
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function Call (C++)
The function-call operator, invoked using parentheses, is a binary operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In this context, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the first operand, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, a possibly empty list of arguments, is the second operand. The function-call operator is used for operations that require a number of parameters. This works because <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a list instead of a single operand. The function-call operator must be a nonstatic member function.  
  
 The function-call operator, when overloaded, does not modify how functions are called; rather, it modifies how the operator is to be interpreted when applied to objects of a given class type. For example, the following code would usually be meaningless:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Given an appropriate overloaded function-call operator, however, this syntax can be used to offset the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> coordinate 3 units and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> coordinate 2 units. The following code shows such a definition:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Note that the function-call operator is applied to the name of an object, not the name of a function.  
  
 You can also overload the function call operator using a pointer to a function (rather than the function itself).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Operator Overloading](../vs140/operator-overloading.md)