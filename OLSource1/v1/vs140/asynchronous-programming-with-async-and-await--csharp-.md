---
title: "Asynchronous Programming with async and await (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 9bcf896a-5826-4189-8c1a-3e35fa08243a
caps.latest.revision: 8
---
# Asynchronous Programming with async and await (C#)
You can avoid performance bottlenecks and enhance the overall responsiveness of your application by using asynchronous programming. However, traditional techniques for writing asynchronous applications can be complicated, making them difficult to write, debug, and maintain.  
  
 Visual Studio 2012 introduced a simplified approach, async programming, that leverages asynchronous support in the .NET Framework 4.5 and higher as well as  in the Windows Runtime. The compiler does the difficult work that the developer used to do, and your application retains a logical structure that resembles synchronous code. As a result, you get all the advantages of asynchronous programming with a fraction of the effort.  
  
 This topic provides an overview of when and how to use async programming and includes links to support topics that contain details and examples.  
  
##  \<a name="BKMK_WhentoUseAsynchrony">\</a> Async Improves Responsiveness  
 Asynchrony is essential for activities that are potentially blocking, such as when your application accesses the web. Access to a web resource sometimes is slow or delayed. If such an activity is blocked within a synchronous process, the entire application must wait. In an asynchronous process, the application can continue with other work that doesn't depend on the web resource until the potentially blocking task finishes.  
  
 The following table shows typical areas where asynchronous programming improves responsiveness. The listed APIs from the  .NET Framework 4.5 and the Windows Runtime contain methods that support async programming.  
  
|Application area|Supporting APIs that contain async methods|  
|----------------------|------------------------------------------------|  
|Web access|\<xref:System.Net.Http.HttpClient*>, [SyndicationClient](http://go.microsoft.com/fwlink/p/?LinkId=259441)|  
|Working with files|[StorageFile](http://go.microsoft.com/fwlink/p/?LinkId=248220), \<xref:System.IO.StreamWriter*>, \<xref:System.IO.StreamReader*>, \<xref:System.Xml.XmlReader*>|  
|Working with images|[MediaCapture](http://go.microsoft.com/fwlink/p/?LinkId=261839), [BitmapEncoder](http://go.microsoft.com/fwlink/p/?LinkId=261840), [BitmapDecoder](http://go.microsoft.com/fwlink/p/?LinkId=261841)|  
|WCF programming|[Synchronous and Asynchronous Operations](http://go.microsoft.com/fwlink/p/?LinkID=192382)|  
|||  
  
 Asynchrony proves especially valuable for applications that access the UI thread because all UI-related activity usually shares one thread. If any process is blocked in a synchronous application, all are blocked. Your application stops responding, and you might conclude that it has failed when instead it's just waiting.  
  
 When you use asynchronous methods, the application continues to respond to the UI. You can resize or minimize a window, for example, or you can close the application if you don't want to wait for it to finish.  
  
 The async-based approach adds the equivalent of an automatic transmission to the list of options that you can choose from when designing asynchronous operations. That is, you get all the benefits of traditional asynchronous programming but with much less effort from the developer.  
  
##  \<a name="BKMK_HowtoWriteanAsyncMethod">\</a> Async Methods Are Easier to Write  
 The [async](../vs140/async--csharp-reference-.md) and [await](../vs140/await--csharp-reference-.md) keywords in C# are the heart of async programming. By using those two keywords, you can use resources in the .NET Framework or the Windows Runtime to create an asynchronous method almost as easily as you create a synchronous method. Asynchronous methods that you define by using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are referred to as async methods.  
  
 The following example shows an async method. Almost everything in the code should look completely familiar to you. The comments call out the features that you add to create the asynchrony.  
  
 You can find a complete Windows Presentation Foundation (WPF) example file at the end of this topic, and you can download the sample from [Async Sample: Example from "Asynchronous Programming with Async and Await"](http://go.microsoft.com/fwlink/?LinkID=261549).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> doesn't have any work that it can do between calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and awaiting its completion, you can simplify your code by calling and awaiting in the following single statement.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following characteristics summarize what makes the previous example an async method.  
  
-   The method signature includes an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> modifier.  
  
-   The name of an async method, by convention, ends with an "Async" suffix.  
  
-   The return type is one of the following types:  
  
    -   <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>Void<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>AccessTheWebAsync<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>AccessTheWebAsync<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>GetStringAsync<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>GetStringAsync<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>AccessTheWebAsync<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>GetStringAsync<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>1*> where <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a string, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> assigns the task to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> variable. The task represents the ongoing process for the call to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, with a commitment to produce an actual string value when the work is complete.  
  
4.  Because <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> hasn't been awaited yet, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> can continue with other work that doesn't depend on the final result from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. That work is represented by a call to the synchronous method <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
5.  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a synchronous method that does its work and returns to its caller.  
  
6.  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> has run out of work that it can do without a result from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> next wants to calculate and return the length of the downloaded string, but the method can't calculate that value until the method has the string.  
  
     Therefore, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> uses an await operator to suspend its progress and to yield control to the method that called <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to the caller. The task represents a promise to produce an integer result that's the length of the downloaded string.  
  
    > [!NOTE]
    >  If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> (and therefore <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>) is complete before <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> awaits it, control remains in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The expense of suspending and then returning to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> would be wasted if the called asynchronous process (<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>) has already completed and AccessTheWebSync doesn't have to wait for the final result.  
  
     Inside the caller (the event handler in this example), the processing pattern continues. The caller might do other work that doesn't depend on the result from <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> before awaiting that result, or the caller might await immediately.   The event handler is waiting for <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is waiting for <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
7.  <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> completes and produces a string result. The string result isn't returned by the call to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> in the way that you might expect. (Remember that the method already returned a task in step 3.) Instead, the string result is stored in the task that represents the completion of the method, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. The await operator retrieves the result from <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. The assignment statement assigns the retrieved result to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
8.  When <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> has the string result, the method can calculate the length of the string. Then the work of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is also complete, and the waiting event handler can resume. In the full example at the end of the topic, you can confirm that the event handler retrieves and prints the value of the length result.  
  
 If you are new to asynchronous programming, take a minute to consider the difference between synchronous and asynchronous behavior. A synchronous method returns when its work is complete (step 5), but an async method returns a task value when its work is suspended (steps 3 and 6). When the async method eventually completes its work, the task is marked as completed and the result, if any, is stored in the task.  
  
 For more information about control flow, see [Control Flow in Async Programs (C#)](../vs140/control-flow-in-async-programs--csharp-.md).  
  
##  \<a name="BKMK_APIAsyncMethods">\</a> API Async Methods  
 You might be wondering where to find methods such as <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> that support async programming. The  .NET Framework 4.5 or higher contains many members that work with <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. You can recognize these members by the "Async" suffix that’s attached to the member name and a return type of \<xref:System.Threading.Tasks.Task*> or <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>System.IO.Stream<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>async<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>async<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>Task.Run<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>finally<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>async<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>async<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>1*>. Inside an async method, an <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> operator is applied to a task that's returned from a call to another async method.  
  
 You specify <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>TResult<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>1*> or a \<xref:System.Threading.Tasks.Task*>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Each returned task represents ongoing work. A task encapsulates information about the state of the asynchronous process and, eventually, either the final result from the process or the exception that the process raises if it doesn't succeed.  
  
 An async method can also have a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> return type. This return type is used primarily to define event handlers, where a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> return type is required. Async event handlers often serve as the starting point for async programs.  
  
 An async method that has a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> return type can’t be awaited, and the caller of a void-returning method can't catch any exceptions that the method throws.  
  
 An async method can't declare [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameters, but the method can call methods that have such parameters.  
  
 For more information and examples, see [Async Return Types (C#)](../vs140/async-return-types--csharp-.md). For more information about how to catch exceptions in async methods, see [try-catch (C# Reference)](../vs140/try-catch--csharp-reference-.md).  
  
 Asynchronous APIs in Windows Runtime  programming have one of the following return types, which are similar to tasks:  
  
-   [IAsyncOperation](http://go.microsoft.com/fwlink/p/?LinkId=261896), which corresponds to <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>async<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>Button1_Click<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>WhenAll<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>1*> types.||  
|[Async Videos on Channel 9](http://go.microsoft.com/fwlink/p/?LinkID=267466)|Provides links to a variety of videos about async programming.||  
  
##  \<a name="BKMK_CompleteExample">\</a> Complete Example  
 The following code is the MainWindow.xaml.cs file from the Windows Presentation Foundation (WPF) application that this topic discusses. You can download the sample from [Async Sample: Example from "Asynchronous Programming with Async and Await"](http://go.microsoft.com/fwlink/p/?LinkID=261549).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [async (C# Reference)](../vs140/async--csharp-reference-.md)   
 [await (C# Reference)](../vs140/await--csharp-reference-.md)