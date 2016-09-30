---
title: "Generic Procedures in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "generic methods, type inference"
  - "generics [Visual Basic], type inference"
  - "procedures, generic"
  - "generic procedures"
  - "type inference, generics"
  - "generic methods"
  - "type inference"
  - "generics [Visual Basic], procedures"
  - "generic procedures, type inference"
ms.assetid: 95577b28-137f-4d5c-a149-919c828600e5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Procedures in Visual Basic
A *generic procedure*, also called a *generic method*, is a procedure defined with at least one type parameter. This allows the calling code to tailor the data types to its requirements each time it calls the procedure.  
  
 A procedure is not generic simply by virtue of being defined inside a generic class or a generic structure. To be generic, the procedure must take at least one type parameter, in addition to any normal parameters it might take. A generic class or structure can contain nongeneric procedures, and a nongeneric class, structure, or module can contain generic procedures.  
  
 A generic procedure can use its type parameters in its normal parameter list, in its return type if it has one, and in its procedure code.  
  
## Type Inference  
 You can call a generic procedure without supplying any type arguments at all. If you call it this way, the compiler attempts to determine the appropriate data types to pass to the procedure's type arguments. This is called *type inference*. The following code shows a call in which the compiler infers that it should pass type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to the type parameter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrDataTypes#15](../vs140/codesnippet/VisualBasic/generic-procedures-in-visual-basic_1.vb)]  
  
 If the compiler cannot infer the type arguments from the context of your call, it reports an error. One possible cause of such an error is an array rank mismatch. For example, suppose you define a normal parameter as an array of a type parameter. If you call the generic procedure supplying an array of a different rank (number of dimensions), the mismatch causes type inference to fail. The following code shows a call in which a two-dimensional array is passed to a procedure that expects a one-dimensional array.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 You can invoke type inference only by omitting all the type arguments. If you supply one type argument, you must supply them all.  
  
 Type inference is supported only for generic procedures. You cannot invoke type inference on generic classes, structures, interfaces, or delegates.  
  
## Example  
  
### Description  
 The following example defines a generic <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> procedure to find a particular element in an array. It defines one type parameter and uses it to construct the two parameters in the parameter list.  
  
### Code  
 [!code[VbVbalrDataTypes#14](../vs140/codesnippet/VisualBasic/generic-procedures-in-visual-basic_2.vb)]  
  
### Comments  
 The preceding example requires the ability to compare <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> against each element of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. To guarantee this ability, it constrains the type parameter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to implement the <xref:System.IComparable<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>1.CompareTo*> method instead of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator, because there is no guarantee that a type argument supplied for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> supports the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operator.  
  
 You can test the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> procedure with the following code.  
  
 [!code[VbVbalrDataTypes#13](../vs140/codesnippet/VisualBasic/generic-procedures-in-visual-basic_3.vb)]  
  
 The preceding calls to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> display "0", "1", and "-1" respectively.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [How to: Define a Class That Can Provide Identical Functionality on Different Data Types](../vs140/a914adf8-e68f-4819-a6b1-200d1cf1c21c.md)   
 [How to: Use a Generic Class](../vs140/how-to--use-a-generic-class--visual-basic-.md)   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Parameter List](../vs140/parameter-list--visual-basic-.md)