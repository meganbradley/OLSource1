---
title: "Lifetime in Visual Basic"
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
  - "static variables, lifetime"
  - "static variables, Visual Basic"
  - "declared elements, lifetime"
  - "Shared variable lifetime"
  - "lifetime, declared elements"
  - "lifetime, Visual Basic"
  - "lifetime"
ms.assetid: bd91e390-690a-469a-9946-8dca70bc14e7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lifetime in Visual Basic
The *lifetime* of a declared element is the period of time during which it is available for use. Variables are the only elements that have lifetime. For this purpose, the compiler treats procedure parameters and function returns as special cases of variables. The lifetime of a variable represents the period of time during which it can hold a value. Its value can change over its lifetime, but it always holds some value.  
  
## Different Lifetimes  
 A *member variable* (declared at module level, outside any procedure) typically has the same lifetime as the element in which it is declared. A nonshared variable declared in a class or structure exists as a separate copy for each instance of the class or structure in which it is declared. Each such variable has the same lifetime as its instance. However, a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> variable has only a single lifetime, which lasts for the entire time your application is running.  
  
 A *local variable* (declared inside a procedure) exists only while the procedure in which it is declared is running. This applies also to that procedure's parameters and to any function return. However, if that procedure calls other procedures, the local variables retain their values while the called procedures are running.  
  
## Beginning of Lifetime  
 A local variable's lifetime begins when control enters the procedure in which it is declared. Every local variable is initialized to the default value for its data type as soon as the procedure begins running. When the procedure encounters a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement that specifies initial values, it sets those variables to those values, even if your code had already assigned other values to them.  
  
 Each member of a structure variable is initialized as if it were a separate variable. Similarly, each element of an array variable is initialized individually.  
  
 Variables declared within a block inside a procedure (such as a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loop) are initialized on entry to the procedure. These initializations take effect whether or not your code ever executes the block.  
  
## End of Lifetime  
 When a procedure terminates, the values of its local variables are not preserved, and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] reclaims their memory. The next time you call the procedure, all its local variables are created afresh and reinitialized.  
  
 When an instance of a class or structure terminates, its nonshared variables lose their memory and their values. Each new instance of the class or structure creates and reinitializes its nonshared variables. However, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variables are preserved until your application stops running.  
  
## Extension of Lifetime  
 If you declare a local variable with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword, its lifetime is longer than the execution time of its procedure. The following table shows how the procedure declaration determines how long a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable exists.  
  
|Procedure location and sharing|Static variable lifetime begins|Static variable lifetime ends|  
|------------------------------------|-------------------------------------|-----------------------------------|  
|In a module (shared by default)|The first time the procedure is called|When your application stops running|  
|In a class, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (procedure is not an instance member)|The first time the procedure is called either on a specific instance or on the class or structure name itself|When your application stops running|  
|In an instance of a class, not <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (procedure is an instance member)|The first time the procedure is called on the specific instance|When the instance is released for garbage collection (GC)|  
  
## Static Variables of the Same Name  
 You can declare static variables with the same name in more than one procedure. If you do this, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler considers each such variable to be a separate element. The initialization of one of these variables does not affect the values of the others. The same applies if you define a procedure with a set of overloads and declare a static variable with the same name in each overload.  
  
## Containing Elements for Static Variables  
 You can declare a static local variable within a class, that is, inside a procedure in that class. However, you cannot declare a static local variable within a structure, either as a structure member or as a local variable of a procedure within that structure.  
  
## Example  
  
### Description  
 The following example declares a variable with the [Static (Visual Basic)](../vs140/static--visual-basic-.md) keyword. (Note that you do not need the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword when the [Dim Statement](../vs140/dim-statement--visual-basic-.md) uses a modifier such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.)  
  
### Code  
 [!code[VbVbalrKeywords#13](../vs140/codesnippet/VisualBasic/lifetime-in-visual-basic_1.vb)]  
  
### Comments  
 In the preceding example, the variable <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> continues to exist after the procedure <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns to the calling code. The next time <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is called, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> retains its previously calculated value.  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> had been declared without using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the previous accumulated values would not be preserved across calls to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The next time <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> was called, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> would have been recreated and initialized to 0, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> would have simply returned the same value with which it was called.  
  
### Compiling the Code  
 You can initialize the value of a static local variable as part of its declaration. If you declare an array to be <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, you can initialize its rank (number of dimensions), the length of each dimension, and the values of the individual elements.  
  
### Security  
 In the preceding example, you can produce the same lifetime by declaring <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> at module level. If you changed the scope of a variable this way, however, the procedure would no longer have exclusive access to it. Because other procedures could access <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and change its value, the running total could be unreliable and the code could be more difficult to maintain.  
  
## See Also  
 [Shared](../vs140/shared--visual-basic-.md)   
 [Nothing](../vs140/nothing--visual-basic-.md)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)   
 [Scope in Visual Basic](../vs140/scope-in-visual-basic.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Variables](../vs140/variables-in-visual-basic.md)   
 [Variable Declaration](../vs140/variable-declaration-in-visual-basic.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [Static (Visual Basic)](../vs140/static--visual-basic-.md)