---
title: "Boxing and Unboxing (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "cs.boxing"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "C# language, boxing"
  - "C# language, unboxing"
  - "unboxing [C#]"
  - "boxing [C#]"
ms.assetid: 8da9bbf4-bce9-4b08-b2e5-f64c11c56514
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Boxing and Unboxing (C# Programming Guide)
Boxing is the process of converting a [value type](../vs140/value-types--csharp-reference-.md) to the type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or to any interface type implemented by this value type. When the CLR boxes a value type, it wraps the value inside a System.Object and stores it on the managed heap. Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit. The concept of boxing and unboxing underlies the C# unified view of the type system in which a value of any type can be treated as an object.  
  
 In the following example, the integer variable <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is *boxed* and assigned to object <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [!code[csProgGuideTypes#14](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_1.cs)]  
  
 The object <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can then be unboxed and assigned to integer variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>:  
  
 [!code[csProgGuideTypes#15](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_2.cs)]  
  
 The following examples illustrate how boxing is used in C#.  
  
 [!code[csProgGuideTypes#47](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_3.cs)]  
  
## Performance  
 In relation to simple assignments, boxing and unboxing are computationally expensive processes. When a value type is boxed, a new object must be allocated and constructed. To a lesser degree, the cast required for unboxing is also expensive computationally. For more information, see [Performance](assetId:///ae275793-857d-4102-9095-b4c2a02d57f4).  
  
## Boxing  
 Boxing is used to store value types in the garbage-collected heap. Boxing is an implicit conversion of a [value type](../vs140/value-types--csharp-reference-.md) to the type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or to any interface type implemented by this value type. Boxing a value type allocates an object instance on the heap and copies the value into the new object.  
  
 Consider the following declaration of a value-type variable:  
  
 [!code[csProgGuideTypes#17](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_4.cs)]  
  
 The following statement implicitly applies the boxing operation on the variable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
  
 [!code[csProgGuideTypes#18](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_5.cs)]  
  
 The result of this statement is creating an object reference <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, on the stack, that references a value of the type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, on the heap. This value is a copy of the value-type value assigned to the variable <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The difference between the two variables, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, is illustrated in the following figure.  
  
 ![BoxingConversion graphic](../vs140/media/vcboxingconversion.gif "vcBoxingConversion")  
Boxing Conversion  
  
 It is also possible to perform the boxing explicitly as in the following example, but explicit boxing is never required:  
  
 [!code[csProgGuideTypes#19](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_6.cs)]  
  
## Description  
 This example converts an integer variable <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to an object <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> by using boxing. Then, the value stored in the variable <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is changed from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The example shows that the original value type and the boxed object use separate memory locations, and therefore can store different values.  
  
## Example  
 [!code[csProgGuideTypes#16](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_7.cs)]  
  
## Unboxing  
 Unboxing is an explicit conversion from the type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to a [value type](../vs140/value-types--csharp-reference-.md) or from an interface type to a value type that implements the interface. An unboxing operation consists of:  
  
-   Checking the object instance to make sure that it is a boxed value of the given value type.  
  
-   Copying the value from the instance into the value-type variable.  
  
 The following statements demonstrate both boxing and unboxing operations:  
  
 [!code[csProgGuideTypes#21](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_8.cs)]  
  
 The following figure demonstrates the result of the previous statements.  
  
 ![UnBoxing Conversion graphic](../vs140/media/vcunboxingconversion.gif "vcUnBoxingConversion")  
Unboxing Conversion  
  
 For the unboxing of value types to succeed at run time, the item being unboxed must be a reference to an object that was previously created by boxing an instance of that value type. Attempting to unbox <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> causes a \<xref:System.NullReferenceException*>. Attempting to unbox a reference to an incompatible value type causes an \<xref:System.InvalidCastException*>.  
  
## Example  
 The following example demonstrates a case of invalid unboxing and the resulting <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Using <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, an error message is displayed when the error occurs.  
  
 [!code[csProgGuideTypes#20](../vs140/codesnippet/CSharp/boxing-and-unboxing--csharp-programming-guide-_9.cs)]  
  
 This program outputs:  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 If you change the statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 to:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 the conversion will be performed, and you will get the output:  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## Related Sections  
 For more information:  
  
-   [Reference Types](../vs140/reference-types--csharp-reference-.md)  
  
-   [Value Types](../vs140/value-types--csharp-reference-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)