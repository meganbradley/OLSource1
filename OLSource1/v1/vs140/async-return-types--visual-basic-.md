---
title: "Async Return Types (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 07890291-ee72-42d3-932a-fa4d312f2c60
caps.latest.revision: 5
---
# Async Return Types (Visual Basic)
Async methods have three possible return types: <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1*> return type is used for an async method that contains a [Return](../vs140/return-statement--visual-basic-.md) statement in which the operand has type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 In the following example, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> async method contains a return statement that returns an integer. Therefore, the method declaration must specify a return type of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is called from within an await expression, the await expression retrieves the integer value (the value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) that's stored in the task that's returned by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information about await expressions, see [Await Operator (Visual Basic)](../vs140/await-operator--visual-basic-.md).  
  
 The following code calls and awaits method <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The result is assigned to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> variable.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can better understand how this happens by separating the call to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> from the application of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, as the following code shows. A call to method <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> that isn't immediately awaited returns a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, as you would expect from the declaration of the method. The task is assigned to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> variable in the example. Because <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>1.Result> property of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. In this case, TResult represents an integer type. When <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is applied to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the await expression evaluates to the contents of the <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>integerTask<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>result2<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>1.Result*> property is a blocking property. If you try to access it before its task is finished, the thread that's currently active is blocked until the task completes and the value is available. In most cases, you should access the value by using <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> instead of accessing the property directly.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The display statements in the following code verify that the values of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> variable, the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> variable, and the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> property are the same. Remember that the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> property is a blocking property and shouldn't be accessed before its task has been awaited.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="BKMK_TaskReturnType">\</a> Task Return Type  
 Async methods that don't contain a return statement or that contain a return statement that doesn't return an operand usually have a return type of \<xref:System.Threading.Tasks.Task>. Such methods would be [Sub](../vs140/sub-procedures--visual-basic-.md) procedures if they were written to run synchronously. If you use a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> return type for an async method, a calling method can use an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> operator to suspend the caller's completion until the called async method has finished.  
  
 In the following example, async method <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> doesn't contain a return statement. Therefore, you specify a return type of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> for the method, which enables <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to be awaited. The definition of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> type doesn't include a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> property to store a return value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is called and awaited by using an await statement instead of an await expression, similar to the calling statement for a synchronous <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or void-returning method. The application of an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> operator in this case doesn't produce a value.  
  
 The following code calls and awaits method <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 As in the previous <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>Task_MethodAsync<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>Result<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>Task_MethodAsync<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>Task_MethodAsync<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>Sub<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>1>, the exception is stored in the returned task, and rethrown when the task is awaited. Therefore, make sure that any async method that can produce an exception has a return type of \<xref:System.Threading.Tasks.Task*> or <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>AsyncReturnTypes` as the name of the project, and then choose the **OK** button.  
  
     The new project appears in **Solution Explorer**.  
  
5.  In the Visual Studio Code Editor, choose the **MainWindow.xaml** tab.  
  
     If the tab is not visible, open the shortcut menu for MainWindow.xaml in **Solution Explorer**, and then choose **Open**.  
  
6.  In the **XAML** window of MainWindow.xaml, replace the code with the following code.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     A simple window that contains a text box and a button appears in the **Design** window of MainWindow.xaml.  
  
7.  In **Solution Explorer**, open the shortcut menu for MainWindow.xaml.vb, and then choose **View Code**.  
  
8.  Replace the code in MainWindow.xaml.vb with the following code.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
9. Choose the F5 key to run the program, and then choose the **Start** button.  
  
     The following output should appear.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Threading.Tasks.Task.FromResult*>   
 [Walkthrough: Accessing the Web by Using Async and Await (Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--visual-basic-.md)   
 [Control Flow in Async Programs (Visual Basic)](../vs140/control-flow-in-async-programs--visual-basic-.md)   
 [Async (Visual Basic)](../vs140/async--visual-basic-.md)   
 [Await Operator (Visual Basic)](../vs140/await-operator--visual-basic-.md)