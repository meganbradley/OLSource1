---
title: "Message Passing Functions"
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
  - "message passing functions"
ms.assetid: 42477c9e-a8a6-4dc4-a98e-93c6dc8c4dd0
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Message Passing Functions
The Asynchronous Agents Library provides several functions that let you pass messages among components.  
  
 These message-passing functions are used with the various message-block types. For more information about the message-block types that are defined by the Concurrency Runtime, see [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
##  <a name="top"></a> Sections  
 This topic describes the following message-passing functions:  
  
-   [send and asend](#send)  
  
-   [receive and try_receive](#receive)  
  
-   [Examples](#examples)  
  
##  <a name="send"></a> send and asend  
 The [concurrency::send](../vs140/send-function.md) function sends a message to the specified target synchronously and the [concurrency::asend](../vs140/asend-function.md) function sends a message to the specified target asynchronously. Both the `send` and `asend` functions wait until the target indicates that it will eventually accept or decline the message.  
  
 The `send` function waits until the target accepts or declines the message before it returns. The `send` function returns `true` if the message was delivered and `false` otherwise. Because the `send` function works synchronously, the `send` function waits for the target to receive the message before it returns.  
  
 Conversely, the `asend` function does not wait for the target to accept or decline the message before it returns. Instead, the `asend` function returns `true` if the target accepts the message and will eventually take it. Otherwise, `asend` returns `false` to indicate that the target either declined the message or postponed the decision about whether to take the message.  
  
 [[Top](#top)]  
  
##  <a name="receive"></a> receive and try_receive  
 The [concurrency::receive](../vs140/receive-function.md) and [concurrency::try_receive](../vs140/try_receive-function.md) functions read data from a given source. The `receive` function waits for data to become available, whereas the `try_receive` function returns immediately.  
  
 Use the `receive` function when you must have the data to continue. Use the `try_receive` function if you must not block the current context or you do not have to have the data to continue.  
  
 [[Top](#top)]  
  
##  <a name="examples"></a> Examples  
 For examples that use the `send` and `asend`, and `receive` functions, see the following topics:  
  
-   [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)  
  
-   [How to: Implement Various Producer-Consumer Patterns](../vs140/how-to--implement-various-producer-consumer-patterns.md)  
  
-   [How to: Provide Work Functions to the call and transformer Classes](../vs140/how-to--provide-work-functions-to-the-call-and-transformer-classes.md)  
  
-   [How to: Use transformer in a Data Pipeline](../vs140/how-to--use-transformer-in-a-data-pipeline.md)  
  
-   [How to: Select Among Completed Tasks](../vs140/how-to--select-among-completed-tasks.md)  
  
-   [How to: Send a Message at a Regular Interval](../vs140/how-to--send-a-message-at-a-regular-interval.md)  
  
-   [How to: Use a Message Block Filter](../vs140/how-to--use-a-message-block-filter.md)  
  
 [[Top](#top)]  
  
## See Also  
 [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md)   
 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)   
 [send Function](../vs140/send-function.md)   
 [asend Function](../vs140/asend-function.md)   
 [receive Function](../vs140/receive-function.md)   
 [try_receive Function](../vs140/try_receive-function.md)