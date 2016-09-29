---
title: "Control.MailboxProcessor&lt;&#39;Msg&gt; Class (F#)"
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
  - "Control.MailboxProcessor<'Msg>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpMailboxProcessor class [F#]"
  - "MailboxProcessor class [F#]"
ms.assetid: 2052c977-f787-4a0b-b25f-9444e26b5fdf
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.MailboxProcessor&lt;&#39;Msg&gt; Class (F#)
A message-processing agent which executes an asynchronous computation.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
[<AutoSerializable(false)>]  
type MailboxProcessor<'Msg> =  
 class  
  interface IDisposable  
  new MailboxProcessor : (MailboxProcessor<'Msg> -> Async<unit>) * ?CancellationToken -> MailboxProcessor<'Msg>  
  member this.Post : 'Msg -> unit  
  member this.PostAndAsyncReply : (AsyncReplyChannel<'Reply> -> 'Msg) * int option -> Async<'Reply>  
  member this.PostAndReply : (AsyncReplyChannel<'Reply> -> 'Msg) * int option -> 'Reply  
  member this.PostAndTryAsyncReply : (AsyncReplyChannel<'Reply> -> 'Msg) * ?int -> Async<'Reply option>  
  member this.Receive : ?int -> Async<'Msg>  
  member this.Scan : ('Msg -> Async<'T> option) * ?int -> Async<'T>  
  member this.Start : unit -> unit  
  static member Start : (MailboxProcessor<'Msg> -> Async<unit>) * ?CancellationToken -> MailboxProcessor<'Msg>  
  member this.TryPostAndReply : (AsyncReplyChannel<'Reply> -> 'Msg) * ?int -> 'Reply option  
  member this.TryReceive : ?int -> Async<'Msg option>  
  member this.TryScan : ('Msg -> Async<'T> option) * ?int -> Async<'T option>  
  member this.add_Error : Handler<Exception> -> unit  
  member this.CurrentQueueLength :  int  
  member this.DefaultTimeout :  int with get, set  
  member this.Error :  IEvent<Exception>  
  member this.remove_Error : Handler<Exception> -> unit  
 end  
```  
  
## Remarks  
 The agent encapsulates a message queue that supports multiple-writers and a single reader agent. Writers send messages to the agent by using the Post method and its variations. The agent may wait for messages using the Receive or TryReceive methods or scan through all available messages using the Scan or TryScan method.  
  
 This type is named `FSharpMailboxProcessor` in the .NET assembly. If accessing the type from a .NET language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../VS_csharp/control.mailboxprocessor--msg--constructor--fsharp-.md)|Creates an agent. The `body` function is used to generate the asynchronous computation executed by the agent. This function is not executed until `Start` is called.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[add_Error](../VS_csharp/mailboxprocessor.add_error--msg--method--fsharp-.md)|Occurs when the execution of the agent results in an exception.|  
|[CurrentQueueLength](../VS_csharp/mailboxprocessor.currentqueuelength--msg--property--fsharp-.md)|Returns the number of unprocessed messages in the message queue of the agent.|  
|[DefaultTimeout](../VS_csharp/mailboxprocessor.defaulttimeout--msg--property--fsharp-.md)|Raises a timeout exception if a message not received in this amount of time. By default no timeout is used.|  
|[Error](../VS_csharp/mailboxprocessor.error--msg--property--fsharp-.md)|Occurs when the execution of the agent results in an exception.|  
|[Post](../VS_csharp/mailboxprocessor.post--msg--method--fsharp-.md)|Posts a message to the message queue of the MailboxProcessor, asynchronously.|  
|[PostAndAsyncReply](../VS_csharp/mailboxprocessor.postandasyncreply--msg--reply--method--fsharp-.md)|Posts a message to an agent and await a reply on the channel, asynchronously.|  
|[PostAndReply](../VS_csharp/mailboxprocessor.postandreply--msg--reply--method--fsharp-.md)|Posts a message to an agent and await a reply on the channel, synchronously.|  
|[PostAndTryAsyncReply](../VS_csharp/mailboxprocessor.postandtryasyncreply--msg--reply--method--fsharp-.md)|Like AsyncPostAndReply, but returns None if no reply within the timeout period.|  
|[Receive](../VS_csharp/mailboxprocessor.receive--msg--method--fsharp-.md)|Waits for a message. This will consume the first message in arrival order.|  
|[remove_Error](../VS_csharp/mailboxprocessor.remove_error--msg--method--fsharp-.md)|Occurs when the execution of the agent results in an exception.|  
|[Scan](../VS_csharp/mailboxprocessor.scan--msg--t--method--fsharp-.md)|Scans for a message by looking through messages in arrival order until `scanner` returns a Some value. Other messages remain in the queue.|  
|[Start](../VS_csharp/mailboxprocessor.start--msg--method--fsharp-.md)|Starts the agent.|  
|[TryPostAndReply](../VS_csharp/mailboxprocessor.trypostandreply--msg--reply--method--fsharp-.md)|Like PostAndReply, but returns None if no reply within the timeout period.|  
|[TryReceive](../VS_csharp/mailboxprocessor.tryreceive--msg--method--fsharp-.md)|Waits for a message. This will consume the first message in arrival order.|  
|[TryScan](../VS_csharp/mailboxprocessor.tryscan--msg--t--method--fsharp-.md)|Scans for a message by looking through messages in arrival order until `scanner` returns a Some value. Other messages remain in the queue.|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[Start](../VS_csharp/mailboxprocessor.start--msg--method--fsharp-.md)|Creates and starts an agent. The `body` function is used to generate the asynchronous computation executed by the agent.|  
  
## Example  
 The following example shows the basic use of the `MailboxProcessor` class.  
  
 [!code[FsMailboxProcessor#2](../VS_csharp/codesnippet/FSharp/control.mailboxprocessor--msg--class--fsharp-_1.fs)]  
  
 **Sample Output**  
  
 **Press any key...**  
**Message count = 0. Waiting for next message.**  
**Message received. ID: 1 Contents: ABC**  
**Message count = 1. Waiting for next message.**  
**Message received. ID: 2 Contents: XYZ**  
**Message count = 2. Waiting for next message.**   
## Example  
 The following example shows how to use `MailboxProcessor` to create a simple agent that accepts various types of messages and returns appropriate replies. This server agent represents a market maker, which is a buying and selling agent on a stock exchange that sets bid and ask prices for assets. Clients can query for prices, or buy and sell shares.  
  
 [!code[FsMailboxProcessor#3](../VS_csharp/codesnippet/FSharp/control.mailboxprocessor--msg--class--fsharp-_2.fs)]  
  
 **Sample Output**  
  
 **Posting message for AAA**  
**Replying with Info for AAA**  
**Posting message for BBB**  
**Replying with Notification:**  
**Bought 100 units of BBB at price $20.100000. Total purchase $2010.000000.**  
**Marketmaker balance: $   2010.00**  
**Posting message for CCC**  
**Replying with Notification:**  
**Sold 100 units of CCC at price $30.000000. Total sale $3000.000000.**  
**Marketmaker balance: $   -990.00**  
**Posting message for WrongCode**  
**Posting message with large number of shares of AAA.**  
**Insufficient shares to fulfill order for 1000000000 units of AAA.**  
**Posting message with too large a monetary amount.**  
**Insufficient cash to fulfill order for 100000000 units of AAA.**  
**Press any key...**  
**Posting BUY CCC 1338.**  
**Replying with Notification:**  
**Bought 1338 units of CCC at price $30.150000. Total purchase $40340.700000.**  
**Marketmaker balance: $  39350.70**  
**Program+Snippet3+Reply+Notify**  
**Posting BUY BBB 1961.**  
**Replying with Notification:**  
**Bought 1961 units of BBB at price $20.100000. Total purchase $39416.100000.**  
**Marketmaker balance: $  78766.80**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)