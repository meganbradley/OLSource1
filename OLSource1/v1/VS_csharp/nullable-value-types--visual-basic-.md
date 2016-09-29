---
title: "Nullable Value Types (Visual Basic)"
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
  - "vb.Nullable"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "nullable types [Visual Basic]"
  - "? [Visual Basic]"
  - "types [Visual Basic], nullable"
  - "nullable types"
  - "data types [Visual Basic], nullable"
ms.assetid: 9ac3b602-6f96-4e6d-96f7-cd4e81c468a6
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable Value Types (Visual Basic)
Sometimes you work with a value type that does not have a defined value in certain circumstances. For example, a field in a database might have to distinguish between having an assigned value that is meaningful and not having an assigned value. Value types can be extended to take either their normal values or a null value. Such an extension is called a *nullable type*.  
  
 Each nullable type is constructed from the generic <xref:System.Nullable`1*> structure. Consider a database that tracks work-related activities. The following example constructs a nullable `Boolean` type and declares a variable of that type. You can write the declaration in three ways:  
  
 [!code[VbVbalrNullableValue#1](../VS_csharp/codesnippet/VisualBasic/nullable-value-types--visual-basic-_1.vb)]  
  
 The variable `ridesBusToWork` can hold a value of `True`, a value of `False`, or no value at all. Its initial default value is no value at all, which in this case could mean that the information has not yet been obtained for this person. In contrast, `False` could mean that the information has been obtained and the person does not ride the bus to work.  
  
 You can declare variables and properties with nullable types, and you can declare an array with elements of a nullable type. You can declare procedures with nullable types as parameters, and you can return a nullable type from a `Function` procedure.  
  
 You cannot construct a nullable type on a reference type such as an array, a `String`, or a class. The underlying type must be a value type. For more information, see [Value Types and Reference Types](../VS_csharp/value-types-and-reference-types.md).  
  
## Using a Nullable Type Variable  
 The most important members of a nullable type are its <xref:System.Nullable`1.HasValue*> and <xref:System.Nullable`1.Value*> properties. For a variable of a nullable type, <xref:System.Nullable`1.HasValue*> tells you whether the variable contains a defined value. If <xref:System.Nullable`1.HasValue*> is `True`, you can read the value from <xref:System.Nullable`1.Value*>. Note that both <xref:System.Nullable`1.HasValue*> and <xref:System.Nullable`1.Value*> are `ReadOnly` properties.  
  
### Default Values  
 When you declare a variable with a nullable type, its <xref:System.Nullable`1.HasValue*> property has a default value of `False`. This means that by default the variable has no defined value, instead of the default value of its underlying value type. In the following example, the variable `numberOfChildren` initially has no defined value, even though the default value of the `Integer` type is 0.  
  
 [!code[VbVbalrNullableValue#2](../VS_csharp/codesnippet/VisualBasic/nullable-value-types--visual-basic-_2.vb)]  
  
 A null value is useful to indicate an undefined or unknown value. If `numberOfChildren` had been declared as `Integer`, there would be no value that could indicate that the information is not currently available.  
  
### Storing Values  
 You store a value in a variable or property of a nullable type in the typical way. The following example assigns a value to the variable `numberOfChildren` declared in the previous example.  
  
 [!code[VbVbalrNullableValue#3](../VS_csharp/codesnippet/VisualBasic/nullable-value-types--visual-basic-_3.vb)]  
  
 If a variable or property of a nullable type contains a defined value, you can cause it to revert to its initial state of not having a value assigned. You do this by setting the variable or property to `Nothing`, as the following example shows.  
  
 [!code[VbVbalrNullableValue#4](../VS_csharp/codesnippet/VisualBasic/nullable-value-types--visual-basic-_4.vb)]  
  
> [!NOTE]
>  Although you can assign `Nothing` to a variable of a nullable type, you cannot test it for `Nothing` by using the equal sign. Comparison that uses the equal sign, `someVar = Nothing`, always evaluates to `Nothing`. You can test the variable's <xref:System.Nullable`1.HasValue*> property for `False`, or test by using the `Is` or `IsNot` operator.  
  
### Retrieving Values  
 To retrieve the value of a variable of a nullable type, you should first test its <xref:System.Nullable`1.HasValue*> property to confirm that it has a value. If you try to read the value when <xref:System.Nullable`1.HasValue*> is `False`, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] throws an <xref:System.InvalidOperationException*> exception. The following example shows the recommended way to read the variable `numberOfChildren` of the previous examples.  
  
 [!code[VbVbalrNullableValue#5](../VS_csharp/codesnippet/VisualBasic/nullable-value-types--visual-basic-_5.vb)]  
  
## Comparing Nullable Types  
 When nullable `Boolean` variables are used in Boolean expressions, the result can be `True`, `False`, or `Nothing`. The following is the truth table for `And` and `Or`. Because `b1` and `b2` now have three possible values, there are nine combinations to evaluate.  
  
|b1|b2|b1 And b2|b1 Or b2|  
|--------|--------|---------------|--------------|  
|`Nothing`|`Nothing`|`Nothing`|`Nothing`|  
|`Nothing`|`True`|`Nothing`|`True`|  
|`Nothing`|`False`|`False`|`Nothing`|  
|`True`|`Nothing`|`Nothing`|`True`|  
|`True`|`True`|`True`|`True`|  
|`True`|`False`|`False`|`True`|  
|`False`|`Nothing`|`False`|`Nothing`|  
|`False`|`True`|`False`|`True`|  
|`False`|`False`|`False`|`False`|  
  
 When the value of a Boolean variable or expression is `Nothing`, it is neither `true` nor `false`. Consider the following example.  
  
 [!code[VbVbalrNullableValue#6](../VS_csharp/codesnippet/VisualBasic/nullable-value-types--visual-basic-_6.vb)]  
  
 In this example, `b1 And b2` evaluates to `Nothing`. As a result, the `Else` clause is executed in each `If` statement, and the output is as follows:  
  
 `Expression is not true`  
  
 `Expression is not false`  
  
> [!NOTE]
>  `AndAlso` and `OrElse`, which use short-circuit evaluation, must evaluate their second operands when the first evaluates to `Nothing`.  
  
## Propagation  
 If one or both of the operands of an arithmetic, comparison, shift, or type operation is nullable, the result of the operation is also nullable. If both operands have values that are not `Nothing`, the operation is performed on the underlying values of the operands, as if neither were a nullable type. In the following example, variables `compare1` and `sum1` are implicitly typed. If you rest the mouse pointer over them, you will see that the compiler infers nullable types for both of them.  
  
 [!code[VbVbalrNullableValue#7](../VS_csharp/codesnippet/VisualBasic/nullable-value-types--visual-basic-_7.vb)]  
  
 If one or both operands have a value of `Nothing`, the result will be `Nothing`.  
  
 [!code[VbVbalrNullableValue#8](../VS_csharp/codesnippet/VisualBasic/nullable-value-types--visual-basic-_8.vb)]  
  
## Using Nullable Types with Data  
 A database is one of the most important places to use nullable types. Not all database objects currently support nullable types, but the designer-generated table adapters do. See "TableAdapter Support for Nullable Types" in [TableAdapter Overview](assetId:///a87c46a0-52ab-432a-a864-9ba55069f9eb).  
  
## See Also  
 <xref:System.InvalidOperationException*>   
 <xref:System.Nullable`1.HasValue*>   
 [Using Nullable Types (C# Programming Guide)](../VS_csharp/using-nullable-types--csharp-programming-guide-.md)   
 [Data Types in Visual Basic](../VS_csharp/data-types-in-visual-basic.md)   
 [Value Types and Reference Types](../VS_csharp/value-types-and-reference-types.md)   
 [Troubleshooting Data Types](../VS_csharp/troubleshooting-data-types--visual-basic-.md)   
 [TableAdapter Overview](assetId:///a87c46a0-52ab-432a-a864-9ba55069f9eb)   
 [If Operator](../VS_csharp/if-operator--visual-basic-.md)   
 [Local Type Inference](../VS_csharp/local-type-inference--visual-basic-.md)   
 [Is Operator (Visual Basic)](../VS_csharp/is-operator--visual-basic-.md)   
 [IsNot Operator](../VS_csharp/isnot-operator--visual-basic-.md)