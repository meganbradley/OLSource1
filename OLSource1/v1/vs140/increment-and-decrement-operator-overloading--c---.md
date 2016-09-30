---
title: "Increment and Decrement Operator Overloading (C++)"
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
  - "increment operators"
  - "increment operators, types of"
  - "decrement operators"
  - "decrement operators, types of"
ms.assetid: 5423c6ce-3999-4a77-92f6-ad540add1b1d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Increment and Decrement Operator Overloading (C++)
The increment and decrement operators fall into a special category because there are two variants of each:  
  
-   Preincrement and postincrement  
  
-   Predecrement and postdecrement  
  
 When you write overloaded operator functions, it can be useful to implement separate versions for the prefix and postfix versions of these operators. To distinguish between the two, the following rule is observed: The prefix form of the operator is declared exactly the same way as any other unary operator; the postfix form accepts an additional argument of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  When specifying an overloaded operator for the postfix form of the increment or decrement operator, the additional argument must be of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; specifying any other type generates an error.  
  
 The following example shows how to define prefix and postfix increment and decrement operators for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The same operators can be defined in file scope (globally) using the following function heads:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The argument of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that denotes the postfix form of the increment or decrement operator is not commonly used to pass arguments. It usually contains the value 0. However, it can be used as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 There is no syntax for using the increment or decrement operators to pass these values other than explicit invocation, as shown in the preceding code. A more straightforward way to implement this functionality is to overload the addition/assignment operator (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## See Also  
 [Operator Overloading](../vs140/operator-overloading.md)