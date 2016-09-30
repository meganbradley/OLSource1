---
title: "Nothing (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "Nothing"
  - "vb.Nothing"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Nothing keyword"
  - "Nothing keyword, syntax"
ms.assetid: 06176e2d-bbf7-4a37-afaa-a86ad21ee99f
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nothing (Visual Basic)
Represents the default value of any data type. For reference types, the default value is the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> reference. For value types, the default value depends on whether the value type is nullable.  
  
> [!NOTE]
>  For non-nullable value types, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in Visual Basic differs from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in C#. In Visual Basic, if you set a variable of a non-nullable value type to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the variable is set to the default value for its declared type. In C#, if you assign a variable of a non-nullable value type to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, a compile-time error occurs.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> represents the default value of a data type. The default value depends on whether the variable is of a value type or of a reference type.  
  
 A variable of a *value type* directly contains its value. Value types include all numeric data types, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, all structures, and all enumerations. A variable of a *reference type* stores a reference to an instance of the object in memory. Reference types include classes, arrays, delegates, and strings. For more information, see [Value Types and Reference Types](../vs140/value-types-and-reference-types.md).  
  
 If a variable is of a value type, the behavior of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> depends on whether the variable is of a nullable data type. To represent a nullable value type, add a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> modifier to the type name. Assigning <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to a nullable variable sets the value to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. For more information and examples, see [Nullable Value Types (Visual Basic)](../vs140/nullable-value-types--visual-basic-.md).  
  
 If a variable is of a value type that is not nullable, assigning <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to it sets it to the default value for its declared type. If that type contains variable members, they are all set to their default values. The following example illustrates this for scalar types.  
  
 [!code[VbVbalrKeywords#7](../vs140/codesnippet/VisualBasic/nothing--visual-basic-_1.vb)]  
  
 If a variable is of a reference type, assigning <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to the variable sets it to a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> reference of the variable's type. A variable that is set to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> reference is not associated with any object. The following example demonstrates this.  
  
 [!code[VbVbalrKeywords#8](../vs140/codesnippet/VisualBasic/nothing--visual-basic-_2.vb)]  
  
 When checking whether a reference (or nullable value type) variable is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, do not use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Always use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 For strings in Visual Basic, the empty string equals <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Therefore, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is true.  
  
 The following example shows comparisons that use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> operators.  
  
 [!code[VbVbalrKeywords#9](../vs140/codesnippet/VisualBasic/nothing--visual-basic-_3.vb)]  
  
 If you declare a variable without using an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clause and set it to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, the variable has a type of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. An example of this is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. A compile-time error occurs in this case when <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is on and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is off.  
  
 When you assign <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to an object variable, it no longer refers to any object instance. If the variable had previously referred to an instance, setting it to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> does not terminate the instance itself. The instance is terminated, and the memory and system resources associated with it are released, only after the garbage collector (GC) detects that there are no active references remaining.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> differs from the \<xref:System.DBNull*> object, which represents an uninitialized variant or a nonexistent database column.  
  
## See Also  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [Object Lifetime: How Objects Are Created and Destroyed](../vs140/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md)   
 [Lifetime in Visual Basic](../vs140/lifetime-in-visual-basic.md)   
 [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md)   
 [IsNot Operator](../vs140/isnot-operator--visual-basic-.md)   
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)