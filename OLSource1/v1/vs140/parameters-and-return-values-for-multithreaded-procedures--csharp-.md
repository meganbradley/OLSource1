---
title: "Parameters and Return Values for Multithreaded Procedures (C#)"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
ms.assetid: ba63c30c-d9f0-4962-b5c7-9d83ba851e6a
caps.latest.revision: 5
---
# Parameters and Return Values for Multithreaded Procedures (C#)
Supplying and returning values in a multithreaded application is complicated because the constructor for the thread class must be passed a reference to a procedure that takes no arguments and returns no value. The following sections show some simple ways to supply parameters and return values from procedures on separate threads.  
  
## Supplying Parameters for Multithreaded Procedures  
 The best way to supply parameters for a multithreaded method call is to wrap the target method in a class and define fields for that class that will serve as parameters for the new thread. The advantage of this approach is that you can create a new instance of the class, with its own parameters, every time you want to start a new thread. For example, suppose you have a function that calculates the area of a triangle, as in the following code:  
  
```c#  
double CalcArea(double Base, double Height)  
{  
    return 0.5 * Base * Height;  
}  
```  
  
 You can write a class that wraps the `CalcArea` function and creates fields to store input parameters, as follows:  
  
```c#  
class AreaClass  
{  
    public double Base;  
    public double Height;  
    public double Area;  
    public void CalcArea()  
    {  
        Area = 0.5 * Base * Height;  
        MessageBox.Show("The area is: " + Area.ToString());  
    }  
}  
```  
  
 To use the `AreaClass`, you can create an `AreaClass` object, and set the `Base` and `Height` properties as shown in the following code:  
  
```c#  
protected void TestArea()  
{  
    AreaClass AreaObject = new AreaClass();  
  
    System.Threading.Thread Thread =  
        new System.Threading.Thread(AreaObject.CalcArea);  
    AreaObject.Base = 30;  
    AreaObject.Height = 40;  
    Thread.Start();  
}  
```  
  
 Notice that the `TestArea` procedure does not check the value of the `Area` field after calling the `CalcArea` method. Because `CalcArea` runs on a separate thread, the `Area` field is not guaranteed to be set if you check it immediately after calling `Thread.Start`. The next section discusses a better way to return values from multithreaded procedures.  
  
## Returning Values from Multithreaded Procedures  
 Returning values from procedures that run on separate threads is complicated by the fact that the procedures cannot be functions and cannot use `ByRef` arguments. The easiest way to return values is to use the <xref:System.ComponentModel.BackgroundWorker?qualifyHint=False> component to manage your threads and raise an event when the task is done, and process the results with an event handler.  
  
 The following example returns a value by raising an event from a procedure running on a separate thread:  
  
```c#  
class AreaClass2  
{  
    public double Base;  
    public double Height;  
    public double CalcArea()  
    {  
        // Calculate the area of a triangle.  
        return 0.5 * Base * Height;  
    }  
}  
  
private System.ComponentModel.BackgroundWorker BackgroundWorker1  
    = new System.ComponentModel.BackgroundWorker();  
  
private void TestArea2()  
{  
    InitializeBackgroundWorker();  
  
    AreaClass2 AreaObject2 = new AreaClass2();  
    AreaObject2.Base = 30;  
    AreaObject2.Height = 40;  
  
    // Start the asynchronous operation.  
    BackgroundWorker1.RunWorkerAsync(AreaObject2);  
}  
  
private void InitializeBackgroundWorker()  
{  
    // Attach event handlers to the BackgroundWorker object.  
    BackgroundWorker1.DoWork +=  
        new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);  
    BackgroundWorker1.RunWorkerCompleted +=  
        new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);  
}  
  
private void BackgroundWorker1_DoWork(  
    object sender,  
    System.ComponentModel.DoWorkEventArgs e)  
{  
    AreaClass2 AreaObject2 = (AreaClass2)e.Argument;  
    // Return the value through the Result property.  
    e.Result = AreaObject2.CalcArea();  
}  
  
private void BackgroundWorker1_RunWorkerCompleted(  
    object sender,  
    System.ComponentModel.RunWorkerCompletedEventArgs e)  
{  
    // Access the result through the Result property.  
    double Area = (double)e.Result;  
    MessageBox.Show("The area is: " + Area.ToString());  
}  
```  
  
 You can provide parameters and return values to thread-pool threads by using the optional `ByVal` state-object variable of the <xref:System.Threading.ThreadPool.QueueUserWorkItem?qualifyHint=False> method. Thread-timer threads also support a state object for this purpose. For information on thread pooling and thread timers, see [Thread Pooling (C#)](../vs140/thread-pooling--csharp-.md) and [Thread Timers (C#)](../vs140/thread-timers--csharp-.md).  
  
## See Also  
 [Walkthrough: Multithreading with the BackgroundWorker Component (C#)](../vs140/walkthrough--multithreading-with-the-backgroundworker-component--csharp-.md)   
 [Thread Pooling (C#)](../vs140/thread-pooling--csharp-.md)   
 [Thread Synchronization (C#)](../vs140/thread-synchronization--csharp-.md)   
 [Events (C# Programming Guide)](../vs140/events--csharp-programming-guide-.md)   
 [Multithreaded Applications (C#)](../vs140/multithreaded-applications--csharp-.md)   
 [Delegates (C# Programming Guide)](../vs140/delegates--csharp-programming-guide-.md)   
 [Multithreading in Components](assetId:///2fc31e68-fb71-4544-b654-0ce720478779)