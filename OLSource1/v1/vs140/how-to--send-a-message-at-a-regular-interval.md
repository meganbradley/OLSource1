---
title: "How to: Send a Message at a Regular Interval"
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
  - "timer class, example"
  - "sending messages at regular intervals [Concurrency Runtime]"
ms.assetid: 4b60ea6c-97c8-4d69-9f7b-ad79f3548026
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Send a Message at a Regular Interval
This example shows how to use the [concurrency::timer](../vs140/timer-class.md) class to send a message at a regular interval.  
  
## Example  
 The following example uses a `timer` object to report progress during a lengthy operation. This example links the `timer` object to a [concurrency::call](../vs140/call-class.md) object. The `call` object prints a progress indicator to the console at a regular interval. The [concurrency::timer::start](../vs140/timer--start-method.md) method runs the timer on a separate context. The `perform_lengthy_operation` function calls the [concurrency::wait](../vs140/wait-function.md) function on the main context to simulate a time-consuming operation.  
  
 [!code[concrt-report-progress#1](../vs140/codesnippet/CPP/how-to--send-a-message-at-a-regular-interval_1.cpp)]  
  
 This example produces the following sample output:  
  
 **Performing a lengthy operation..........done.**   
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named `report-progress.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc report-progress.cpp**  
  
## See Also  
 [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md)   
 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)   
 [Message Passing Functions](../vs140/message-passing-functions.md)   
 [timer Class](../vs140/timer-class.md)