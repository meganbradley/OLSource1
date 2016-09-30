---
title: "Passing Value-Type Parameters (C# Programming Guide)"
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
  - "method parameters [C#], value types"
  - "parameters [C#], value"
ms.assetid: 193ab86f-5f9b-4359-ac29-7cdf8afad3a6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Passing Value-Type Parameters (C# Programming Guide)
A [value-type](../vs140/value-types--csharp-reference-.md) variable contains its data directly as opposed to a [reference-type](../vs140/reference-types--csharp-reference-.md) variable, which contains a reference to its data. Passing a value-type variable to a method by value means passing a copy of the variable to the method. Any changes to the parameter that take place inside the method have no affect on the original data stored in the argument variable. If you want the called method to change the value of the parameter, you must pass it by reference, using the [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) keyword. For simplicity, the following examples use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
## Passing Value Types by Value  
 The following example demonstrates passing value-type parameters by value. The variable <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is passed by value to the method <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Any changes that take place inside the method have no affect on the original value of the variable.  
  
 [!code[csProgGuideParameters#3](../vs140/codesnippet/CSharp/passing-value-type-parameters--csharp-programming-guide-_1.cs)]  
  
 The variable <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a value type. It contains its data, the value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is invoked, the contents of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are copied into the parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which is squared inside the method. In <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, however, the value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the same after calling the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method as it was before. The change that takes place inside the method only affects the local variable <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Passing Value Types by Reference  
 The following example is the same as the previous example, except that the argument is passed as a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter. The value of the underlying argument, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, is changed when <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is changed in the method.  
  
 [!code[csProgGuideParameters#4](../vs140/codesnippet/CSharp/passing-value-type-parameters--csharp-programming-guide-_2.cs)]  
  
 In this example, it is not the value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that is passed; rather, a reference to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is passed. The parameter <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not an [int](../vs140/int--csharp-reference-.md); it is a reference to an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, in this case, a reference to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Therefore, when <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is squared inside the method, what actually is squared is what <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> refers to, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Swapping Value Types  
 A common example of changing the values of arguments is a swap method, where you pass two variables to the method, and the method swaps their contents. You must pass the arguments to the swap method by reference. Otherwise, you swap local copies of the parameters inside the method, and no change occurs in the calling method. The following example swaps integer values.  
  
 [!code[csProgGuideParameters#5](../vs140/codesnippet/CSharp/passing-value-type-parameters--csharp-programming-guide-_3.cs)]  
  
 When you call the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method, use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> keyword in the call, as shown in the following example.  
  
 [!code[csProgGuideParameters#6](../vs140/codesnippet/CSharp/passing-value-type-parameters--csharp-programming-guide-_4.cs)]  
  
## See Also  
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Passing Parameters (C#)](../vs140/passing-parameters--csharp-programming-guide-.md)   
 [Passing Reference-Type Parameters](../vs140/passing-reference-type-parameters--csharp-programming-guide-.md)