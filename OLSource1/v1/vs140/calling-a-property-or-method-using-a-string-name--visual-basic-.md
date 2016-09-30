---
title: "Calling a Property or Method Using a String Name (Visual Basic)"
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
  - "passing operators"
  - "strings [Visual Basic], passing new operators as"
  - "objects [Visual Basic], setting properties"
  - "setting properties, object properties at run time"
  - "method calls, strings"
  - "methods [Visual Basic], calling with string names"
  - "calling methods, string names"
  - "properties [Visual Basic], setting at run time"
  - "CallByName function"
ms.assetid: 79a7b8b4-b8c7-4ad8-aca8-12a9a2b32f03
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Calling a Property or Method Using a String Name (Visual Basic)
In most cases, you can discover the properties and methods of an object at design time, and write code to handle them. However, in some cases you may not know about an object's properties and methods in advance, or you may just want the flexibility of enabling an end user to specify properties or execute methods at run time.  
  
## CallByName Function  
 Consider, for example, a client application that evaluates expressions entered by the user by passing an operator to a COM component. Suppose you are constantly adding new functions to the component that require new operators. When you use standard object access techniques, you must recompile and redistribute the client application before it could use the new operators. To avoid this, you can use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> function to pass the new operators as strings, without changing the application.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function lets you use a string to specify a property or method at run time. The signature for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function looks like this:  
  
 *Result* = <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>(*Object*, *ProcedureName*, *CallType*, *Arguments*())  
  
 The first argument, *Object*, takes the name of the object you want to act upon. The *ProcedureName* argument takes a string that contains the name of the method or property procedure to be invoked. The *CallType* argument takes a constant that represents the type of procedure to invoke: a method (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), a property read (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), or a property set (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). The *Arguments* argument, which is optional, takes an array of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that contains any arguments to the procedure.  
  
 You can use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with classes in your current solution, but it is most often used to access COM objects or objects from [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] assemblies.  
  
 Suppose you add a reference to an assembly that contains a class named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which has a new function named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, as shown in the following code:  
  
 [!code[VbVbalrOOP#53](../vs140/codesnippet/VisualBasic/calling-a-property-or-method-using-a-string-name--visual-basic-_1.vb)]  
  
 Your application could use text box controls to control which method will be called and its arguments. For example, if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> contains the expression to be evaluated, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is used to enter the name of the function, you can use the following code to invoke the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function on the expression in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>:  
  
 [!code[VbVbalrOOP#54](../vs140/codesnippet/VisualBasic/calling-a-property-or-method-using-a-string-name--visual-basic-_2.vb)]  
  
 If you enter "64" in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, "SquareRoot" in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and then call the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> procedure, the square root of the number in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is evaluated. The code in the example invokes the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function (which takes a string that contains the expression to be evaluated as a required argument) and returns "8" in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (the square root of 64). Of course, if the user enters an invalid string in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, if the string contains the name of a property instead of a method, or if the method had an additional required argument, a run-time error occurs. You have to add robust error-handling code when you use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to anticipate these or any other errors.  
  
> [!NOTE]
>  While the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function may be useful in some cases, you must weigh its usefulness against the performance implications — using <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to invoke a procedure is slightly slower than a late-bound call. If you are invoking a function that is called repeatedly, such as inside a loop, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> can have a severe effect on performance.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Interaction.CallByName*>   
 [Determining Object Type](../vs140/determining-object-type--visual-basic-.md)