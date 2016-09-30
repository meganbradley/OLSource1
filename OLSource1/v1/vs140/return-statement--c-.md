---
title: "return Statement (C)"
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
  - "( ) parentheses in return statements"
ms.assetid: 18cd82cf-f899-4b28-83ad-4eff353ddcb4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# return Statement (C)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement terminates the execution of a function and returns control to the calling function. Execution resumes in the calling function at the point immediately following the call. A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement can also return a value to the calling function. See [Return Type](../vs140/return-type.md) for more information.  
  
## Syntax  
 *jump-statement*:  
 **return**  *expression* opt**;**  
  
 The value of *expression*, if present, is returned to the calling function. If *expression* is omitted, the return value of the function is undefined. The expression, if present, is evaluated and then converted to the type returned by the function. If the function was declared with return type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement containing an expression generates a warning and the expression is not evaluated.  
  
 If no <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement appears in a function definition, control automatically returns to the calling function after the last statement of the called function is executed. In this case, the return value of the called function is undefined. If a return value is not required, declare the function to have <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> return type; otherwise, the default return type is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Many programmers use parentheses to enclose the *expression* argument of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement. However, C does not require the parentheses.  
  
 This example demonstrates the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function calls two functions: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function returns the value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, where the return value is assigned to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The parentheses around the return expression in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are evaluated as part of the expression, and are not required by the return statement. Since the return expression is evaluated before it is converted to the return type, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> forces the expression type to be the return type with a cast to prevent a possible integer overflow, which could lead to unexpected results. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function is declared as a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function. It prints the values of its parameters and then the empty return statement ends the function and does not return a value. An attempt to assign the return value of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> would cause a diagnostic message to be issued. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function then returns the value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to the operating system.  
  
 The output of the example looks like this:  
  
 **i = 2147483647, ll = 4611686014132420609**   
## See Also  
 [Statements (C)](../vs140/statements--c-.md)