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
Contains members for creating and manipulating asynchronous computations. `Control.Async` is a static class.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
type Async =  
 class  
  static member AsBeginEnd : ('Arg -> Async<'T>) -> ('Arg * AsyncCallback * obj -> IAsyncResult) * (IAsyncResult -> 'T) * (IAsyncResult -> unit)  
  static member AwaitEvent : IEvent<'Del,'T> * ?(unit -> unit) -> Async<'T>  
  static member AwaitIAsyncResult : IAsyncResult * ?int -> Async<bool>  
  static member AwaitTask : Task<'T> -> Async<'T>  
  static member AwaitWaitHandle : WaitHandle * ?int -> Async<bool>  
  static member CancelDefaultToken : unit -> unit  
  static member Catch : Async<'T> -> Async<Choice<'T,exn>>  
  static member FromBeginEnd : 'Arg1 * 'Arg2 * 'Arg3 * ('Arg1 * 'Arg2 * 'Arg3 * AsyncCallback * obj -> IAsyncResult) * (IAsyncResult -> 'T) * ?(unit -> unit) -> Async<'T>  
  static member FromBeginEnd : 'Arg1 * 'Arg2 * ('Arg1 * 'Arg2 * AsyncCallback * obj -> IAsyncResult) * (IAsyncResult -> 'T) * ?(unit -> unit) -> Async<'T>  
  static member FromBeginEnd : 'Arg1 * ('Arg1 * AsyncCallback * obj -> IAsyncResult) * (IAsyncResult -> 'T) * ?(unit -> unit) -> Async<'T>  
  static member FromBeginEnd : (AsyncCallback * obj -> IAsyncResult) * (IAsyncResult -> 'T) * ?(unit -> unit) -> Async<'T>  
  static member FromContinuations : (('T -> unit) * (exn -> unit) * (OperationCanceledException -> unit) -> unit) -> Async<'T>  
  static member Ignore : Async<'T> -> Async<unit>  
  static member OnCancel : (unit -> unit) -> Async<IDisposable>  
  static member Parallel : seq<Async<'T>> -> Async<'T []>  
  static member RunSynchronously : Async<'T> * ?int * ?CancellationToken -> 'T  
  static member Sleep : int -> Async<unit>  
  static member Start : Async<unit> * ?CancellationToken -> unit  
  static member StartAsTask : Async<'T> * ?TaskCreationOptions * ?CancellationToken -> Task<'T>  
  static member StartChild : Async<'T> * ?int -> Async<Async<'T>>  
  static member StartChildAsTask : Async<'T> * ?TaskCreationOptions -> Async<Task<'T>>  
  static member StartImmediate : Async<unit> * ?CancellationToken -> unit  
  static member StartWithContinuations : Async<'T> * ('T -> unit) * (exn -> unit) * (OperationCanceledException -> unit) * ?CancellationToken -> unit  
  static member SwitchToContext : SynchronizationContext -> Async<unit>  
  static member SwitchToNewThread : unit -> Async<unit>  
  static member SwitchToThreadPool : unit -> Async<unit>  
  static member TryCancelled : Async<'T> * (OperationCanceledException -> unit) -> Async<'T>  
  static member CancellationToken :  Async<CancellationToken>  
  static member DefaultCancellationToken :  CancellationToken  
 end  
```  
  
## Remarks  
 This type is named `FSharpAsync` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
 For an overview of asynchronous workflows, see [Asynchronous Workflows (F#)](../VS_csharp/asynchronous-workflows--fsharp-.md).  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[AsBeginEnd](../VS_csharp/async.asbeginend--arg--t--method--fsharp-.md)|Creates three functions that can be used to implement the .NET Framework Asynchronous Programming Model (APM) for the supplied asynchronous computation.|  
|[AwaitEvent](../VS_csharp/async.awaitevent--del--t--method--fsharp-.md)|Creates an asynchronous computation that waits for a single invocation of a .NET Framework event by adding a handler to the event. When the computation finishes or is canceled, the handler is removed from the event.|  
|[AwaitIAsyncResult](../VS_csharp/async.awaitiasyncresult-method--fsharp-.md)|Creates an asynchronous computation that waits for the supplied <xref:System.IAsyncResult*>.|  
|[AwaitTask](../VS_csharp/async.awaittask--t--method--fsharp-.md)|Returns an asynchronous computation that waits for the given task to complete and returns its result.|  
|[AwaitWaitHandle](../VS_csharp/async.awaitwaithandle-method--fsharp-.md)|Creates an asynchronous computation that waits for the supplied <xref:System.Threading.WaitHandle*>.|  
|[CancelDefaultToken](../VS_csharp/async.canceldefaulttoken-method--fsharp-.md)|Raises the cancellation condition for the most recent set of asynchronous computations started without any specific <xref:System.Threading.CancellationToken*>. Replaces the global <xref:System.Threading.CancellationTokenSource*> with a new global token source for any asynchronous computations created without any specific <xref:System.Threading.CancellationToken*>.|  
|[CancellationToken](../VS_csharp/async.cancellationtoken-property--fsharp-.md)|Creates an asynchronous computation that returns the <xref:System.Threading.CancellationToken*> that manages the execution of the computation.|  
|[Catch](../VS_csharp/async.catch--t--method--fsharp-.md)|Creates an asynchronous computation. If this computation finishes successfully, this method returns `Choice1Of2` with the returned value. If this computation raises an exception before it finishes, this method returns `Choice2Of2` with the raised exception.|  
|[DefaultCancellationToken](../VS_csharp/async.defaultcancellationtoken-property--fsharp-.md)|Gets the default cancellation token for running asynchronous computations.|  
|[FromBeginEnd<'T>](../VS_csharp/async.frombeginend--t--method--fsharp-.md)|Creates an asynchronous computation by specifying a beginning and ending function, like .NET Framework APIs.|  
|[FromBeginEnd<'Arg1,'T>](../VS_csharp/async.frombeginend--arg1--t--method--fsharp-.md)|Creates an asynchronous computation by specifying a beginning and ending function, like .NET Framework APIs. This overload should be used if the operation is qualified by one argument.|  
|[FromBeginEnd<'Arg1,'Arg2,'T>](../VS_csharp/async.frombeginend--arg1--arg2--t--method--fsharp-.md)|Creates an asynchronous computation by specifying a beginning and ending function, like .NET Framework APIs. This overload should be used if the operation is qualified by two arguments.|  
|[FromBeginEnd<'Arg1,'Arg2,'Arg3,'T>](../VS_csharp/async.frombeginend--arg1--arg2--arg3--t--method--fsharp-.md)|Creates an asynchronous computation by specifying a beginning and ending function, like .NET Framework APIs. This overload should be used if the operation is qualified by three arguments.|  
|[FromContinuations](../VS_csharp/async.fromcontinuations--t--method--fsharp-.md)|Creates an asynchronous computation that includes the current success, exception, and cancellation continuations. The callback function must eventually call exactly one of the given continuations.|  
|[Ignore](../VS_csharp/async.ignore--t--method--fsharp-.md)|Creates an asynchronous computation that runs the given computation and ignores its result.|  
|[OnCancel](../VS_csharp/async.oncancel-method--fsharp-.md)|Generates a scoped, cooperative cancellation handler for use within an asynchronous workflow.|  
|[Parallel](../VS_csharp/async.parallel--t--method--fsharp-.md)|Creates an asynchronous computation that runs all the supplied asynchronous computations, initially queuing each as a work item and using a fork/join pattern.|  
|[RunSynchronously](../VS_csharp/async.runsynchronously--t--method--fsharp-.md)|Runs an asynchronous computation and waits for its result.|  
|[Sleep](../VS_csharp/async.sleep-method--fsharp-.md)|Creates an asynchronous computation that pauses for the specified time. A <xref:System.Threading.Timer*> object is used to schedule the delay. The operation does not block operating system threads for the duration of the delay.|  
|[Start](../VS_csharp/async.start-method--fsharp-.md)|Starts an asynchronous computation in the thread pool. Does not wait for its result.|  
|[StartAsTask](../VS_csharp/async.startastask--t--method--fsharp-.md)|Executes a computation in the thread pool. Returns a <xref:System.Threading.Tasks.Task*> that will be completed in the corresponding state once the computation terminates (produces the result, throws exception or gets canceled) If no cancellation token is provided then the default cancellation token is used.|  
|[StartChild](../VS_csharp/async.startchild--t--method--fsharp-.md)|Starts a child computation within an asynchronous workflow. This allows multiple asynchronous computations to be executed simultaneously.|  
|[StartChildAsTask](../VS_csharp/async.startchildastask--t--method--fsharp-.md)|Creates an asynchronous computation which starts the given computation as a <xref:System.Threading.Tasks.Task*>.|  
|[StartImmediate](../VS_csharp/async.startimmediate-method--fsharp-.md)|Runs an asynchronous computation, starting immediately on the current operating system thread.|  
|[StartWithContinuations](../VS_csharp/async.startwithcontinuations--t--method--fsharp-.md)|Runs an asynchronous computation, starting immediately on the current operating system thread. This method calls one of the three continuations when the operation finishes.|  
|[SwitchToContext](../VS_csharp/async.switchtocontext-method--fsharp-.md)|Creates an asynchronous computation that runs its continuation by using the <xref:System.Threading.SynchronizationContext.Post*> method of the supplied synchronization context. If the supplied synchronization context is `null`, the asynchronous computation is equivalent to [SwitchToThreadPool](../VS_csharp/async.switchtothreadpool-method--fsharp-.md).|  
|[SwitchToNewThread](../VS_csharp/async.switchtonewthread-method--fsharp-.md)|Creates an asynchronous computation that creates a new thread and runs its continuation in that thread.|  
|[SwitchToThreadPool](../VS_csharp/async.switchtothreadpool-method--fsharp-.md)|Creates an asynchronous computation that queues a work item that runs its continuation.|  
|[TryCancelled](../VS_csharp/async.trycancelled--t--method--fsharp-.md)|Creates an asynchronous computation that runs the supplied computation. If this computation is cancelled before it finishes, the computation generated by running the supplied compensation function is executed.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)   
 [Asynchronous Workflows (F#)](../VS_csharp/asynchronous-workflows--fsharp-.md)   
 [Control.Async<'T> Type (F#)](../VS_csharp/control.async--t--type--fsharp-.md)