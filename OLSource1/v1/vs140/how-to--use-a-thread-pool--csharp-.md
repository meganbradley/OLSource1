---
title: "How to: Use a Thread Pool (C#)"
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
ms.assetid: 210a9235-83a6-420b-af52-2d6a58e5133f
caps.latest.revision: 5
---
# How to: Use a Thread Pool (C#)
*Thread pooling* is a form of multithreading in which tasks are added to a queue and automatically started when threads are created. For more information, see [Thread Pooling (C#)](../vs140/thread-pooling--csharp-.md).  
  
 The following example uses the .NET Framework thread pool to calculate the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> result for ten numbers between 20 and 40. Each <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> result is represented by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class, which provides a method named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that performs the calculation. An object that represents each <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value is created, and the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method is passed to \<xref:System.Threading.ThreadPool.QueueUserWorkItem*>, which assigns an available thread in the pool to execute the method.  
  
 Because each <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is given a semi-random value to compute, and because each thread will be competing for processor time, you cannot know in advance how long it will take for all ten results to be calculated. That is why each <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is passed an instance of the \<xref:System.Threading.ManualResetEvent*> class during construction. Each object signals the provided event object when its calculation is complete, which allows the primary thread to block execution with \<xref:System.Threading.WaitHandle.WaitAll*> until all ten <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects have calculated a result. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method then displays each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> result.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Following is an example of the output.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Threading.Mutex*>   
 \<xref:System.Threading.WaitHandle.WaitAll*>   
 \<xref:System.Threading.ManualResetEvent*>   
 \<xref:System.Threading.EventWaitHandle.Set*>   
 \<xref:System.Threading.ThreadPool*>   
 \<xref:System.Threading.ThreadPool.QueueUserWorkItem*>   
 \<xref:System.Threading.ManualResetEvent*>   
 [Thread Pooling (C#)](../vs140/thread-pooling--csharp-.md)   
 [Threading (C#)](../vs140/threading--csharp-.md)   
 [Monitor](assetId:///33fe4aef-b44b-42fd-9e72-c908e39e75db)   
 [Security in the .NET Framework](assetId:///9a9621d7-8883-4a4f-a874-65e8e09e20a6)