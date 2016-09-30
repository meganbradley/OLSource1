---
title: "Walkthrough: Using the Debugger with Async Methods"
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
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "await operator, using the debugger"
  - "async feature, using the debugger"
  - "Step Into command, at await operator"
  - "Step Over command, at await operator"
  - "Step Out command, within async method"
ms.assetid: 5adb2531-3f09-4b7e-8baa-29de80abee6e
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Using the Debugger with Async Methods
By using the Async feature, you can call into asynchronous methods without using callbacks or splitting your code across multiple methods or lambda expressions. To make synchronous code asynchronous, you call an asynchronous method instead of a synchronous method and add a few keywords to the code. For more information, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  
  
 In the Visual Studio debugger, you can use the **Step Into**, **Step Over**, and **Step Out** commands with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> feature. You can also continue to use breakpoints, particularly to view the control flow at a statement that contains an await operator. In this walkthrough, you'll complete the following tasks, which you can run in any order.  
  
-   Demonstrate the control flow at an await statement by using breakpoints.  
  
-   Understand the behavior of the **Step Into** and **Step Over** commands at statements that contain an await operator.  
  
-   Understand the behavior of the **Step Out** command when you use it from within an async method.  
  
## Breakpoints to Show Control Flow  
 If you mark a method with the [Async](../vs140/async--visual-basic-.md) (Visual Basic) or [async](../vs140/async--csharp-reference-.md) (C#) modifier, you can use the [Await](../vs140/async--visual-basic-.md) (Visual Basic) or [await](../vs140/await--csharp-reference-.md) (C#) operator in the method. To create an await expression, you associate the await operator with a task. When an await expression is called for the task, the current method exits immediately and returns a different task. When the task that's associated with the await operator finishes, execution resumes in the same method. For more information, see [Control Flow in Async Programs (C# and Visual Basic)](../vs140/control-flow-in-async-programs--csharp-and-visual-basic-.md).  
  
> [!NOTE]
>  An async method returns to the caller when either it encounters the first awaited object that’s not yet complete or it reaches the end of the async method, whichever occurs first.  
  
> [!NOTE]
>  The console apps in these examples use \<xref:System.Threading.Tasks.Task.Wait*> method to prevent the application from terminating in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. You shouldn’t use the \<xref:System.Threading.Tasks.Task.Wait*> method outside of console applications  because a deadlock situation can occur.  
  
 The following procedure sets breakpoints to demonstrate what happens when the application reaches an await statement. You can also demonstrate the control flow by adding <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statements.  
  
1.  Create a console application, and then paste the following code into it:  
  
     [!code[csAsyncDebugging#1](../vs140/codesnippet/CSharp/walkthrough--using-the-debugger-with-async-methods_1.cs)]
[!code[csAsyncDebugging#1](../vs140/codesnippet/VisualBasic/walkthrough--using-the-debugger-with-async-methods_1.vb)]  
  
2.  Set debugging breakpoints on the three lines that end with a "set breakpoint" comment.  
  
3.  Choose the F5 key, or choose **Debug**, **Start Debugging** on the menu bar to run the application.  
  
     The application goes into the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method and breaks on the line that contains the await operator.  
  
4.  Choose the F5 key again.  
  
     Because the application stopped on a statement that contains an await operator, the application immediately exits the async method and returns a task. Therefore, the application exits the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method and breaks at the breakpoint in the calling method (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
5.  Choose the F5 key again.  
  
     When the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method completes, the code resumes after the await statement in the calling method. Therefore, the application breaks at the breakpoint in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method.  
  
     When <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> was initially awaited, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method exited and returned a task. When the awaited <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method then completed, the evaluation of the await statement produced the return value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method is defined to return a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in Visual Basic or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in C#, so the value in its return statement is an integer. For more information, see [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
### Obtaining and then awaiting a task  
 In the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method, the statement <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (Visual Basic) or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (C#) is a contraction of the following two statements:  
  
 [!code[csAsyncDebugging#2](../vs140/codesnippet/CSharp/walkthrough--using-the-debugger-with-async-methods_2.cs)]
[!code[csAsyncDebugging#2](../vs140/codesnippet/VisualBasic/walkthrough--using-the-debugger-with-async-methods_2.vb)]  
  
 The first line of code calls the async method and returns a task. That task is associated with the await operator in the next line of code. The await statement exits the method (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) and returns a different task. When the task that’s associated with the await operator is complete, code resumes in the method (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) after the await statement.  
  
 When the await statement immediately returns a different task, that task is the returned argument of the async method that contains the await operator (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>). The task that’s returned by the await includes code execution that occurs after the await in the same method, which is why that task is different from the task that’s associated with the await.  
  
## Step Into and Step Over  
 The **Step Into** command steps into a method, but the **Step Over** command executes the method call and then breaks on the next line of the calling method. For more information, see [Step into, over, or out of the code](../vs140/navigating-through-code-with-the-debugger.md#BKMK_Step_into__over__or_out_of_the_code).  
  
 The following procedure shows what occurs when you choose the **Step Into** or **Step Over** commands at an await statement.  
  
1.  Replace the code in the console application with the following code.  
  
     [!code[csAsyncDebugging#3](../vs140/codesnippet/CSharp/walkthrough--using-the-debugger-with-async-methods_3.cs)]
[!code[csAsyncDebugging#3](../vs140/codesnippet/VisualBasic/walkthrough--using-the-debugger-with-async-methods_3.vb)]  
  
2.  Choose the F11 key, or choose **Debug**, **Step Into** on the menu bar to start a demonstration of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> command at a statement that contains an await operator.  
  
     The application starts and breaks on the first line, which is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> in Visual Basic or the opening curly brace of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method in C#.  
  
3.  Choose the F11 key three more times.  
  
     The application should now be at the await statement in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method.  
  
4.  Choose the F11 key.  
  
     The application goes into the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method and breaks on the first line. This behavior occurs even though, at the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement, the application immediately returns to the calling method (<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>).  
  
5.  Keep choosing the F11 key until the application returns to the await statement in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method.  
  
6.  Choose the F11 key.  
  
     The application breaks on the line that follows the await statement.  
  
7.  On the menu bar, choose **Debug**, **Stop Debugging** to stop execution of the application.  
  
     The next steps demonstrate the **Step Over** command at an await statement.  
  
8.  Choose the F11 key four times, or choose **Debug**, **Step Into** on the menu bar four times.  
  
     The application should now be at the await statement in the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method.  
  
9. Choose the F10 key, or choose **Debug**, **Step Over** on the menu bar.  
  
     Execution breaks at the line that follows the await statement. This behavior occurs even though the application returns immediately to the calling method (<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) at the await statement. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> command also steps over execution of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method, as expected.  
  
10. On the menu bar, choose **Debug**, **Stop Debugging** to stop execution of the application.  
  
     As the following steps show, the behavior of the **Step Into** and **Step Over** commands differs slightly when the await operator is on a different line from the call to the async method.  
  
11. In the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method, replace the await statement with the following code. The original await statement is a contraction of the following two statements.  
  
     [!code[csAsyncDebugging#2](../vs140/codesnippet/CSharp/walkthrough--using-the-debugger-with-async-methods_2.cs)]
[!code[csAsyncDebugging#2](../vs140/codesnippet/VisualBasic/walkthrough--using-the-debugger-with-async-methods_2.vb)]  
  
12. Choose the F11 key or choose **Debug**, **Step Into** on the menu bar multiple times to start execution and step through the code.  
  
     At the call to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, the **Step Into** command breaks in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method, while the **Step Over** command goes to the next statement, as expected. At the await statement, both commands break at the statement that follows the await.  
  
## Step Out  
 In methods that aren't async, the **Step Out** command breaks in the calling method on the code that follows the method call. For async methods, the logic for where the execution breaks in the calling method is more complex, and that logic depends on whether the **Step Out** command is on the first line of the async method.  
  
1.  Replace the code in the console application with the following code.  
  
     [!code[csAsyncDebugging#4](../vs140/codesnippet/CSharp/walkthrough--using-the-debugger-with-async-methods_4.cs)]
[!code[csAsyncDebugging#4](../vs140/codesnippet/VisualBasic/walkthrough--using-the-debugger-with-async-methods_4.vb)]  
  
2.  Set a breakpoint on the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> line in the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method.  
  
     This is to demonstrate the behavior of the **Step Out** command from a line in an async method that isn't the first line.  
  
3.  Choose the F5 key or choose **Debug**, **Start Debugging** on the menu bar to start the application.  
  
     The code breaks on <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> method.  
  
4.  Choose the Shift+F11 keys, or choose **Debug**, **Step Out** on the menu bar.  
  
     The application breaks in the calling method at the await statement for the task that’s associated with the current method. As a result, the application breaks on the await statement in the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> method. The application doesn’t break on <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> (Visual Basic) or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> (C#), which is the code that follows the call to the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method.  
  
5.  Choose **Debug**, **Stop Debugging** on the menu bar to stop execution of the application.  
  
     The next steps demonstrate what happens when you **Step Out** from the first line of an async method.  
  
6.  Remove the existing breakpoint, and add a breakpoint on the first line of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> method.  
  
     In C#, add the breakpoint on the opening curly brace of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> method. In Visual Basic, add the breakpoint on the line that contains <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
7.  Choose the F5 key to start the application.  
  
     The code breaks on the first line of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> method.  
  
8.  On the menu bar, choose **Debug**, **Windows**, **Output**.  
  
     The **Output** window opens.  
  
9. Choose the Shift+F11 keys, or choose **Debug**, **Step Out** on the menu bar.  
  
     The application resumes until the async method reaches its first await, and then the application breaks at the calling statement. As a result, the application breaks on <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> (Visual Basic) or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> (C#). The "before" message has appeared in the Output window, but the "after" message hasn't yet appeared.  
  
10. Choose the F5 key to continue to run the application.  
  
     The application continues with the statement that follows the await statement in the called async function (<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>). The "after" message appears in the Output window.  
  
## See Also  
 [Start, Break, Step, Run through Code, and Stop Debugging in Visual Studio](../vs140/navigating-through-code-with-the-debugger.md)