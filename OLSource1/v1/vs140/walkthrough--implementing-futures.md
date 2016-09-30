---
title: "Walkthrough: Implementing Futures"
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
helpviewer_keywords: 
  - "implementing futures [Concurrency Runtime]"
  - "futures, implementing [Concurrency Runtime]"
ms.assetid: 82ea75cc-aaec-4452-b10d-8abce0a87e5b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Implementing Futures
This topic shows how to implement futures in your application. The topic demonstrates how to combine existing functionality in the Concurrency Runtime into something that does more.  
  
> [!IMPORTANT]
>  This topic illustrates the concept of futures for demonstration purposes. We recommend that you use [std::future](../vs140/future-class.md) or [concurrency::task](../vs140/task-class--concurrency-runtime-.md) when you require an asynchronous task that computes a value for later use.  
  
 A *task* is a computation that can be decomposed into additional, more fine-grained, computations. A *future* is an asynchronous task that computes a value for later use.  
  
 To implement futures, this topic defines the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class uses these components of the Concurrency Runtime: the [concurrency::task_group](../vs140/task_group-class.md) class and the [concurrency::single_assignment](../vs140/single_assignment-class.md) class. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class uses the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class to compute a value asynchronously and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class to store the result of the computation. The constructor of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class takes a work function that computes the result, and the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method retrieves the result.  
  
### To implement the async_future class  
  
1.  Declare a template class named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that is parameterized on the type of the resulting computation. Add <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> sections to this class.  
  
     [!code[concrt-futures#2](../vs140/codesnippet/CPP/walkthrough--implementing-futures_1.cpp)]  
  
2.  In the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class, declare a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data member.  
  
     [!code[concrt-futures#3](../vs140/codesnippet/CPP/walkthrough--implementing-futures_2.cpp)]  
  
3.  In the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class, implement the constructor. The constructor is a template that is parameterized on the work function that computes the result. The constructor asynchronously executes the work function in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> data member and uses the [concurrency::send](../vs140/send-function.md) function to write the result to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> data member.  
  
     [!code[concrt-futures#4](../vs140/codesnippet/CPP/walkthrough--implementing-futures_3.cpp)]  
  
4.  In the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class, implement the destructor. The destructor waits for the task to finish.  
  
     [!code[concrt-futures#5](../vs140/codesnippet/CPP/walkthrough--implementing-futures_4.cpp)]  
  
5.  In the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class, implement the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method. This method uses the [concurrency::receive](../vs140/receive-function.md) function to retrieve the result of the work function.  
  
     [!code[concrt-futures#6](../vs140/codesnippet/CPP/walkthrough--implementing-futures_5.cpp)]  
  
## Example  
  
### Description  
 The following example shows the complete <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class and an example of its usage. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function creates a [std::vector](../vs140/vector-class.md) object that contains 10,000 random integer values. It then uses <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> objects to find the smallest and largest values that are contained in the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
### Code  
 [!code[concrt-futures#1](../vs140/codesnippet/CPP/walkthrough--implementing-futures_6.cpp)]  
  
### Comments  
 This example produces the following output:  
  
 **smallest: 0**  
**largest:  9999**  
**average:  4981** The example uses the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method to retrieve the results of the computation. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method waits for the computation to finish if the computation is still active.  
  
## Robust Programming  
 To extend the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class to handle exceptions that are thrown by the work function, modify the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method to call the [concurrency::task_group::wait](../vs140/task_group--wait-method.md) method. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method throws any exceptions that were generated by the work function.  
  
 The following example shows the modified version of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> function uses a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>-<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> block to print the result of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object or to print the value of the exception that is generated by the work function.  
  
 [!code[concrt-futures-with-eh#1](../vs140/codesnippet/CPP/walkthrough--implementing-futures_7.cpp)]  
  
 This example produces the following output:  
  
 **caught exception: error** For more information about the exception handling model in the Concurrency Runtime, see [Exception Handling in the Concurrency Runtime](../vs140/exception-handling-in-the-concurrency-runtime.md).  
  
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc futures.cpp**  
  
## See Also  
 [Concurrency Runtime Walkthroughs](../vs140/concurrency-runtime-walkthroughs.md)   
 [Exception Handling in the Concurrency Runtime](../vs140/exception-handling-in-the-concurrency-runtime.md)   
 [task_group Class](../vs140/task_group-class.md)   
 [single_assignment Class](../vs140/single_assignment-class.md)