---
title: "Structure and Union Members"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "member-selection operators"
  - "structure members, referencing"
  - "-> operator, structure and union members"
  - "dot operator (.)"
  - "referencing structure members"
  - ". operator"
  - "operators [C], member selection"
  - "structure member selection"
ms.assetid: bb1fe304-af49-4f98-808d-afdc99b3e319
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Structure and Union Members
A "member-selection expression" refers to members of structures and unions. Such an expression has the value and type of the selected member.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This list describes the two forms of the member-selection expressions:  
  
1.  In the first form, *postfix-expression* represents a value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or **union** type, and *identifier* names a member of the specified structure or union. The value of the operation is that of *identifier* and is an l-value if *postfix-expression* is an l-value. See [L-Value and R-Value Expressions](../vs140/l-value-and-r-value-expressions.md) for more information.  
  
2.  In the second form, *postfix-expression* represents a pointer to a structure or union, and *identifier* names a member of the specified structure or union. The value is that of *identifier* and is an l-value.  
  
 The two forms of member-selection expressions have similar effects.  
  
 In fact, an expression involving the member-selection operator (**–>**) is a shorthand version of an expression using the period (**.**) if the expression before the period consists of the indirection operator (**\***) applied to a pointer value. Therefore,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 is equivalent to  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 when *expression* is a pointer value.  
  
## Examples  
 The following examples refer to this structure declaration. For information about the indirection operator (**\***) used in these examples, see [Indirection and Address-of Operators](../vs140/indirection-and-address-of-operators.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A member-selection expression for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure looks like this:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In the example above, the address of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure is assigned to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member of the structure. This means that <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> contains a pointer to itself.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In this example, the pointer expression <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is used with the member-selection operator (**–>**) to assign a value to the member <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This statement shows how to select an individual structure member from an array of structures.  
  
## See Also  
 [Member Access Operators: . and ->](../vs140/member-access-operators--.-and---.md)