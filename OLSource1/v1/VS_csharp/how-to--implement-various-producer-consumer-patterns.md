---
title: "How to: Implement Various Producer-Consumer Patterns"
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
  - "producer-consumer patterns, implementing [Concurrency Runtime]"
  - "implementing producer-consumer patterns [Concurrency Runtime]"
ms.assetid: 75f2c7cc-5399-49ea-98eb-847fe6747169
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement Various Producer-Consumer Patterns
This topic describes how to implement the producer-consumer pattern in your application. In this pattern, the *producer* sends messages to a message block, and the *consumer* reads messages from that block.  
  
 The topic demonstrates two scenarios. In the first scenario, the consumer must receive each message that the producer sends. In the second scenario, the consumer periodically polls for data, and therefore does not have to receive each message.  
  
 Both examples in this topic use agents, message blocks, and message-passing functions to transmit messages from the producer to the consumer. The producer agent uses the [concurrency::send](../VS_csharp/send-function.md) function to write messages to a [concurrency::ITarget](../VS_csharp/itarget-class.md) object. The consumer agent uses the [concurrency::receive](../VS_csharp/receive-function.md) function to read messages from a [concurrency::ISource](../VS_csharp/isource-class.md) object. Both agents hold a sentinel value to coordinate the end of processing.  
  
 For more information about asynchronous agents, see [Asynchronous Agents](../VS_csharp/asynchronous-agents.md). For more information about message blocks and message-passing functions, see [Asynchronous Message Blocks](../VS_csharp/asynchronous-message-blocks.md) and [Message Passing Functions](../VS_csharp/message-passing-functions.md).  
  
## Example  
 In this example, the producer agent sends a series of numbers to the consumer agent. The consumer receives each of these numbers and computes their average. The application writes the average to the console.  
  
 This example uses a [concurrency::unbounded_buffer](../VS_csharp/unbounded_buffer-class.md) object to enable the producer to queue messages. The `unbounded_buffer` class implements `ITarget` and `ISource` so that the producer and the consumer can send and receive messages to and from a shared buffer. The `send` and `receive` functions coordinate the task of propagating the data from the producer to the consumer.  
  
 [!code[concrt-producer-consumer-average#1](../VS_csharp/codesnippet/CPP/how-to--implement-various-producer-consumer-patterns_1.cpp)]  
  
 This example produces the following output.  
  
 **The average is 50.**   
## Example  
 In this example, the producer agent sends a series of stock quotes to the consumer agent. The consumer agent periodically reads the current quote and prints it to the console.  
  
 This example resembles the previous one, except that it uses a [concurrency::overwrite_buffer](../VS_csharp/overwrite_buffer-class.md) object to enable the producer to share one message with the consumer. As in the previous example, `overwrite_buffer` class implements `ITarget` and `ISource` so that the producer and the consumer can act on a shared message buffer.  
  
 [!code[concrt-producer-consumer-quotes#1](../VS_csharp/codesnippet/CPP/how-to--implement-various-producer-consumer-patterns_2.cpp)]  
  
 This example produces the following sample output.  
  
 **Current quote is 24.44.**  
**Current quote is 24.44.**  
**Current quote is 24.65.**  
**Current quote is 24.99.**  
**Current quote is 23.76.**  
**Current quote is 22.30.**  
**Current quote is 25.89.** Unlike with an `unbounded_buffer` object, the `receive` function does not remove the message from the `overwrite_buffer` object. If the consumer reads from the message buffer more than one time before the producer overwrites that message, the receiver obtains the same message every time.  
  
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named `producer-consumer.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc producer-consumer.cpp**  
  
## See Also  
 [Asynchronous Agents Library](../VS_csharp/asynchronous-agents-library.md)   
 [Asynchronous Agents](../VS_csharp/asynchronous-agents.md)   
 [Asynchronous Message Blocks](../VS_csharp/asynchronous-message-blocks.md)   
 [Message Passing Functions](../VS_csharp/message-passing-functions.md)