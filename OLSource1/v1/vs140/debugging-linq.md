---
title: "Debugging LINQ"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging, LINQ"
  - "LINQ, viewing results in debugger"
  - "LINQ, debugging"
  - "LINQ, stepping"
  - "LINQ, edit and continue"
ms.assetid: dbae26cb-ac5f-4312-b474-b9f29714f4c6
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging LINQ
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] supports the debugging of language integrated query (LINQ) code, with some limitations. Most debugging features work with LINQ statements, including stepping, setting breakpoints, and viewing results in debugger windows. This topic describes the major limitations of LINQ debugging.  
  
##  \<a name="BKMK_ViewingLINQResults">\</a> Viewing LINQ Results  
 You can view the result of a LINQ statement by using DataTips, the Watch window, and the QuickWatch dialog box. When you use a source window, you can pause the pointer on a query in the source window and a DataTip will appear. You can copy a LINQ variable and paste it into the Watch window or QuickWatch dialog box.  
  
 In LINQ, a query is not evaluated when it is created or declared, but only when the query is used. Therefore, the query does not have a value until it is evaluated. For a full description of query creation and evaluation, see [The Three Parts of a LINQ Query](../vs140/introduction-to-linq-queries--csharp-.md) or [Writing Your First LINQ Query (Visual Basic)](../vs140/writing-your-first-linq-query--visual-basic-.md).  
  
 To display the result of a query, the debugger must evaluate it. This implicit evaluation, which occurs when you view a LINQ query result in the debugger, has some effects you should consider:  
  
-   Each evaluation of the query takes time. Expanding the results node takes time. For some queries, repeated evaluation might result in a noticeable performance penalty.  
  
-   Evaluating a query can result in side effects, which are changes to the value of data or the state of your program. Not all queries have side effects. To determine whether a query may be safely evaluated without side effects, you must understand the code that implements the query.  
  
##  \<a name="BKMK_SteppingAndLinq">\</a> Stepping and LINQ  
 When you are debugging LINQ code, stepping has some behavioral differences you should know about.  
  
### LINQ to SQL  
 In LINQ to SQL queries, the predicate code is beyond the control of the debugger. Therefore, you cannot step into the predicate code. Any query that compiles to an expression tree produces code that is beyond the control of the debugger.  
  
### Stepping in Visual Basic  
 When you are stepping through a Visual Basic program and the debugger encounters a query declaration, it does not step into the declaration but highlights the entire declaration as a single statement. This behavior occurs because the query is not evaluated until it is called. For more information, see [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md).  
  
 If you step through the following example code, the debugger highlights the query declaration, or query creation, as a single statement.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When you step again, the debugger highlights <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. On the next step, it steps into the function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. After stepping through <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, it jumps back to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. At no point does it step through the predicate code in the query declaration, although the debugger does evaluate that code.  
  
### Replacing a Predicate with a Function to Enable Stepping (Visual Basic)  
 If you have to step through predicate code for debugging purposes, you can replace the predicate with a call to a function that contains the original predicate code. For example, suppose you have this code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can move the predicate code to a new function, called <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The revised query calls the function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on each pass through the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. You can use the debugger windows to see whether each item meets the specified condition, and you can step through the code in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The predicate in this example is fairly simple. However, if you have a more difficult predicate you have to debug, this technique can be very useful.  
  
##  \<a name="BKMK_EditandContinueNotSupportedforLINQ">\</a> Edit and Continue Not Supported for LINQ  
 Edit and Continue does not support changes to LINQ queries. If you add, remove, or change a LINQ statement during a debugging session, a dialog box appears that tells you the change is not supported by Edit and Continue. At that point, you can either undo the changes or stop the debugging session and restart a new session with the edited code.  
  
 In addition, Edit and Continue does not support changing the type or the value of a variable that is used in a LINQ statement. Again, you can either undo the changes or stop and restart the debugging session.  
  
 In C#, you cannot use Edit and Continue on any code in a method that contains a LINQ query.  
  
 In Visual Basic, you can use Edit and Continue on non-LINQ code, even in a method that contains a LINQ query. You can add or remove code before the LINQ statement, even if the changes affect the line number of the LINQ query. Your Visual Basic debugging experience for non-LINQ code remains the same as it was before LINQ was introduced. You cannot change, add, or remove a LINQ query, however, unless you want to stop debugging to apply the changes.  
  
## See Also  
 [Debugging SQL](assetId:///f27c17e6-1d90-49f2-9fc0-d02e6a27f109)   
 [Side Effects and Expressions](../vs140/side-effects-and-expressions.md)   
 [Exception Handling (Debugging)](../vs140/managing-exceptions-with-the-debugger.md)   
 [The Three Parts of a LINQ Query](../vs140/introduction-to-linq-queries--csharp-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)