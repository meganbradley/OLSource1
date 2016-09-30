---
title: "Control.Async Class (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Control.Async"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpAsync class [F#]"
  - "Async class [F#]"
ms.assetid: 03eb4d12-a01a-4565-a077-5e83f17cf6f7
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.Async Class (F#)
Contains members for creating and manipulating asynchronous computations. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a static class.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This type is named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
 For an overview of asynchronous workflows, see [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md).  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[AsBeginEnd](../vs140/async.asbeginend--arg--t--method--fsharp-.md)|Creates three functions that can be used to implement the .NET Framework Asynchronous Programming Model (APM) for the supplied asynchronous computation.|  
|[AwaitEvent](../vs140/async.awaitevent--del--t--method--fsharp-.md)|Creates an asynchronous computation that waits for a single invocation of a .NET Framework event by adding a handler to the event. When the computation finishes or is canceled, the handler is removed from the event.|  
|[AwaitIAsyncResult](../vs140/async.awaitiasyncresult-method--fsharp-.md)|Creates an asynchronous computation that waits for the supplied \<xref:System.IAsyncResult*>.|  
|[AwaitTask](../vs140/async.awaittask--t--method--fsharp-.md)|Returns an asynchronous computation that waits for the given task to complete and returns its result.|  
|[AwaitWaitHandle](../vs140/async.awaitwaithandle-method--fsharp-.md)|Creates an asynchronous computation that waits for the supplied \<xref:System.Threading.WaitHandle*>.|  
|[CancelDefaultToken](../vs140/async.canceldefaulttoken-method--fsharp-.md)|Raises the cancellation condition for the most recent set of asynchronous computations started without any specific \<xref:System.Threading.CancellationToken*>. Replaces the global \<xref:System.Threading.CancellationTokenSource*> with a new global token source for any asynchronous computations created without any specific \<xref:System.Threading.CancellationToken*>.|  
|[CancellationToken](../vs140/async.cancellationtoken-property--fsharp-.md)|Creates an asynchronous computation that returns the \<xref:System.Threading.CancellationToken*> that manages the execution of the computation.|  
|[Catch](../vs140/async.catch--t--method--fsharp-.md)|Creates an asynchronous computation. If this computation finishes successfully, this method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> with the returned value. If this computation raises an exception before it finishes, this method returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with the raised exception.|  
|[DefaultCancellationToken](../vs140/async.defaultcancellationtoken-property--fsharp-.md)|Gets the default cancellation token for running asynchronous computations.|  
|[FromBeginEnd\<'T>](../vs140/async.frombeginend--t--method--fsharp-.md)|Creates an asynchronous computation by specifying a beginning and ending function, like .NET Framework APIs.|  
|[FromBeginEnd\<'Arg1,'T>](../vs140/async.frombeginend--arg1--t--method--fsharp-.md)|Creates an asynchronous computation by specifying a beginning and ending function, like .NET Framework APIs. This overload should be used if the operation is qualified by one argument.|  
|[FromBeginEnd\<'Arg1,'Arg2,'T>](../vs140/async.frombeginend--arg1--arg2--t--method--fsharp-.md)|Creates an asynchronous computation by specifying a beginning and ending function, like .NET Framework APIs. This overload should be used if the operation is qualified by two arguments.|  
|[FromBeginEnd\<'Arg1,'Arg2,'Arg3,'T>](../vs140/async.frombeginend--arg1--arg2--arg3--t--method--fsharp-.md)|Creates an asynchronous computation by specifying a beginning and ending function, like .NET Framework APIs. This overload should be used if the operation is qualified by three arguments.|  
|[FromContinuations](../vs140/async.fromcontinuations--t--method--fsharp-.md)|Creates an asynchronous computation that includes the current success, exception, and cancellation continuations. The callback function must eventually call exactly one of the given continuations.|  
|[Ignore](../vs140/async.ignore--t--method--fsharp-.md)|Creates an asynchronous computation that runs the given computation and ignores its result.|  
|[OnCancel](../vs140/async.oncancel-method--fsharp-.md)|Generates a scoped, cooperative cancellation handler for use within an asynchronous workflow.|  
|[Parallel](../vs140/async.parallel--t--method--fsharp-.md)|Creates an asynchronous computation that runs all the supplied asynchronous computations, initially queuing each as a work item and using a fork/join pattern.|  
|[RunSynchronously](../vs140/async.runsynchronously--t--method--fsharp-.md)|Runs an asynchronous computation and waits for its result.|  
|[Sleep](../vs140/async.sleep-method--fsharp-.md)|Creates an asynchronous computation that pauses for the specified time. A \<xref:System.Threading.Timer*> object is used to schedule the delay. The operation does not block operating system threads for the duration of the delay.|  
|[Start](../vs140/async.start-method--fsharp-.md)|Starts an asynchronous computation in the thread pool. Does not wait for its result.|  
|[StartAsTask](../vs140/async.startastask--t--method--fsharp-.md)|Executes a computation in the thread pool. Returns a \<xref:System.Threading.Tasks.Task*> that will be completed in the corresponding state once the computation terminates (produces the result, throws exception or gets canceled) If no cancellation token is provided then the default cancellation token is used.|  
|[StartChild](../vs140/async.startchild--t--method--fsharp-.md)|Starts a child computation within an asynchronous workflow. This allows multiple asynchronous computations to be executed simultaneously.|  
|[StartChildAsTask](../vs140/async.startchildastask--t--method--fsharp-.md)|Creates an asynchronous computation which starts the given computation as a \<xref:System.Threading.Tasks.Task*>.|  
|[StartImmediate](../vs140/async.startimmediate-method--fsharp-.md)|Runs an asynchronous computation, starting immediately on the current operating system thread.|  
|[StartWithContinuations](../vs140/async.startwithcontinuations--t--method--fsharp-.md)|Runs an asynchronous computation, starting immediately on the current operating system thread. This method calls one of the three continuations when the operation finishes.|  
|[SwitchToContext](../vs140/async.switchtocontext-method--fsharp-.md)|Creates an asynchronous computation that runs its continuation by using the \<xref:System.Threading.SynchronizationContext.Post*> method of the supplied synchronization context. If the supplied synchronization context is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the asynchronous computation is equivalent to [SwitchToThreadPool](../vs140/async.switchtothreadpool-method--fsharp-.md).|  
|[SwitchToNewThread](../vs140/async.switchtonewthread-method--fsharp-.md)|Creates an asynchronous computation that creates a new thread and runs its continuation in that thread.|  
|[SwitchToThreadPool](../vs140/async.switchtothreadpool-method--fsharp-.md)|Creates an asynchronous computation that queues a work item that runs its continuation.|  
|[TryCancelled](../vs140/async.trycancelled--t--method--fsharp-.md)|Creates an asynchronous computation that runs the supplied computation. If this computation is cancelled before it finishes, the computation generated by running the supplied compensation function is executed.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)   
 [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md)   
 [Control.Async\<'T> Type (F#)](../vs140/control.async--t--type--fsharp-.md)