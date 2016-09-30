---
title: "How to: Extend the Async Walkthrough by Using Task.WhenAll (Visual Basic)"
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
ms.assetid: c06d386d-e996-4da9-bf3d-05a3b6c0a258
caps.latest.revision: 7
---
# How to: Extend the Async Walkthrough by Using Task.WhenAll (Visual Basic)
You can improve the performance of the async solution in [Walkthrough: Accessing the Web by Using Async and Await (Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--visual-basic-.md) by using the \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName> method. This method asynchronously awaits multiple asynchronous operations, which are represented as a collection of tasks.  
  
 You might have noticed in the walkthrough that the websites download at different rates. Sometimes one of the websites is very slow, which delays all the remaining downloads. When you run the asynchronous solutions that you build in the walkthrough, you can end the program easily if you don't want to wait, but a better option would be to start all the downloads at the same time and let faster downloads continue without waiting for the one that’s delayed.  
  
 You apply the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method to a collection of tasks. The application of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns a single task that isn’t complete until every task in the collection is completed. The tasks appear to run in parallel, but no additional threads are created. The tasks can complete in any order.  
  
> [!IMPORTANT]
>  The following procedures describe extensions to the async applications that are developed in [Walkthrough: Accessing the Web by Using Async and Await (Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--visual-basic-.md). You can develop the applications by either completing the walkthrough or downloading the code from [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=255191).  
>   
>  To run the example, you must have Visual Studio 2012 or later installed on your computer.  
  
### To add Task.WhenAll to your GetURLContentsAsync solution  
  
1.  Add the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method to the first application that's developed in [Walkthrough: Accessing the Web by Using Async and Await (Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--visual-basic-.md).  
  
    -   If you downloaded the code from  [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=255191), open the AsyncWalkthrough project, and then add <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to the MainWindow.xaml.vb file.  
  
    -   If you developed the code by completing the walkthrough, add <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to the application that includes the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method. The MainWindow.xaml.vb file for this application is the first example in the "Complete Code Examples from the Walkthrough" section.  
  
     The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method consolidates the actions in the body of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> loop in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in the original walkthrough. The method asynchronously downloads the contents of a specified website as a byte array, and then displays and returns the length of the byte array.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Comment out or delete the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> loop in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, as the following code shows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Create a collection of tasks. The following code defines a [query](../vs140/linq--language-integrated-query-.md) that, when executed by the \<xref:System.Linq.Enumerable.ToArray*> method, creates a collection of tasks that download the contents of each website. The tasks are started when the query is evaluated.  
  
     Add the following code to method <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> after the declaration of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Apply <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to the collection of tasks, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> returns a single task that finishes when all the tasks in the collection of tasks have completed.  
  
     In the following example, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> expression awaits the completion of the single task that <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> returns. The expression evaluates to an array of integers, where each integer is the length of a downloaded website. Add the following code to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, just after the code that you added in the previous step.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  Finally, use the \<xref:System.Linq.Enumerable.Sum*> method to calculate the sum of the lengths of all the websites. Add the following line to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### To add Task.WhenAll to the HttpClient.GetByteArrayAsync solution  
  
1.  Add the following version of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to the second application that's developed in [Walkthrough: Accessing the Web by Using Async and Await (Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--visual-basic-.md).  
  
    -   If you downloaded the code from [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=255191), open the AsyncWalkthrough_HttpClient project, and then add <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to the MainWindow.xaml.vb file.  
  
    -   If you developed the code by completing the walkthrough, add <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to the application that uses the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method. The MainWindow.xaml.vb file for this application is the second example in the "Complete Code Examples from the Walkthrough" section.  
  
     The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method consolidates the actions in the body of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> loop in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> in the original walkthrough. The method asynchronously downloads the contents of a specified website as a byte array, and then displays and returns the length of the byte array.  
  
     The only difference from the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> method in the previous procedure is the use of the \<xref:System.Net.Http.HttpClient*> instance, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
2.  Comment out or delete the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> loop in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, as the following code shows.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  Define a [query](../vs140/linq--language-integrated-query-.md) that, when executed by the \<xref:System.Linq.Enumerable.ToArray*> method, creates a collection of tasks that download the contents of each website. The tasks are started when the query is evaluated.  
  
     Add the following code to method <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> after the declaration of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
4.  Next, apply <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to the collection of tasks, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> returns a single task that finishes when all the tasks in the collection of tasks have completed.  
  
     In the following example, the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> expression awaits the completion of the single task that <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> returns. When complete, the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> expression evaluates to an array of integers, where each integer is the length of a downloaded website. Add the following code to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, just after the code that you added in the previous step.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
5.  Finally, use the \<xref:System.Linq.Enumerable.Sum*> method to get the sum of the lengths of all the websites. Add the following line to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### To test the Task.WhenAll solutions  
  
-   For either solution, choose the F5 key to run the program, and then choose the **Start** button. The output should resemble the output from the async solutions in [Walkthrough: Accessing the Web by Using Async and Await (Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--visual-basic-.md). However, notice that the websites appear in a different order each time.  
  
## Example  
 The following code shows the extensions to the project that uses the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> method to download content from the web.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Example  
 The following code shows the extensions to the project that uses method <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to download content from the web.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName>   
 [Walkthrough: Accessing the Web by Using Async and Await (Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--visual-basic-.md)