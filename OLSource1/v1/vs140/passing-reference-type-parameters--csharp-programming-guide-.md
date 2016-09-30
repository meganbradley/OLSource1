---
title: "Passing Reference-Type Parameters (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "method parameters [C#], reference types"
  - "parameters [C#], reference"
ms.assetid: 9e6eb65c-942e-48ab-920a-b7ba9df4ea20
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Passing Reference-Type Parameters (C# Programming Guide)
A variable of a [reference type](../vs140/reference-types--csharp-reference-.md) does not contain its data directly; it contains a reference to its data. When you pass a reference-type parameter by value, it is possible to change the data pointed to by the reference, such as the value of a class member. However, you cannot change the value of the reference itself; that is, you cannot use the same reference to allocate memory for a new class and have it persist outside the block. To do that, pass the parameter using the [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) keyword. For simplicity, the following examples use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
## Passing Reference Types by Value  
 The following example demonstrates passing a reference-type parameter, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, by value, to a method, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Because the parameter is a reference to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, it is possible to change the values of the array elements. However, the attempt to reassign the parameter to a different memory location only works inside the method and does not affect the original variable, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [!code[csProgGuideParameters#7](../vs140/codesnippet/CSharp/passing-reference-type-parameters--csharp-programming-guide-_1.cs)]  
  
 In the preceding example, the array, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which is a reference type, is passed to the method without the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter. In such a case, a copy of the reference, which points to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, is passed to the method. The output shows that it is possible for the method to change the contents of an array element, in this case from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. However, allocating a new portion of memory by using the [new](../vs140/new--csharp-reference-.md) operator inside the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method makes the variable <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> reference a new array. Thus, any changes after that will not affect the original array, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which is created inside <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. In fact, two arrays are created in this example, one inside <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and one inside the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method.  
  
## Passing Reference Types by Reference  
 The following example is the same as the previous example, except that the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword is added to the method header and call. Any changes that take place in the method affect the original variable in the calling program.  
  
 [!code[csProgGuideParameters#8](../vs140/codesnippet/CSharp/passing-reference-type-parameters--csharp-programming-guide-_2.cs)]  
  
 All of the changes that take place inside the method affect the original array in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. In fact, the original array is reallocated using the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> operator. Thus, after calling the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method, any reference to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> points to the five-element array, which is created in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method.  
  
## Swapping Two Strings  
 Swapping strings is a good example of passing reference-type parameters by reference. In the example, two strings, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, are initialized in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and passed to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method as parameters modified by the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> keyword. The two strings are swapped inside the method and inside <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as well.  
  
 [!code[csProgGuideParameters#9](../vs140/codesnippet/CSharp/passing-reference-type-parameters--csharp-programming-guide-_3.cs)]  
  
 In this example, the parameters need to be passed by reference to affect the variables in the calling program. If you remove the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> keyword from both the method header and the method call, no changes will take place in the calling program.  
  
 For more information about strings, see [string](../vs140/string--csharp-reference-.md).  
  
## See Also  
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Passing Parameters (C#)](../vs140/passing-parameters--csharp-programming-guide-.md)   
 [Passing Arrays Using ref and out (C# Programmer's Reference)](../vs140/passing-arrays-using-ref-and-out--csharp-programming-guide-.md)   
 [ref (C# keyword)](../vs140/ref--csharp-reference-.md)   
 [Reference Types (C# Reference)](../vs140/reference-types--csharp-reference-.md)