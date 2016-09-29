---
title: "How to: Provide Work Functions to the call and transformer Classes"
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
  - "call class, example"
  - "using the transformer class [Concurrency Runtime]"
  - "using the call class [Concurrency Runtime]"
ms.assetid: df715ce4-8507-41ca-b204-636d11707a73
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Provide Work Functions to the call and transformer Classes
This topic illustrates several ways to provide work functions to the [concurrency::call](../VS_csharp/call-class.md) and [concurrency::transformer](../VS_csharp/transformer-class.md) classes.  
  
 The first example shows how to pass a lambda expression to a `call` object. The second example shows how to pass a function object to a `call` object. The third example shows how to bind a class method to a `call` object.  
  
 For illustration, every example in this topic uses the `call` class. For an example that uses the `transformer` class, see [How to: Use transformer in a Data Pipeline](../VS_csharp/how-to--use-transformer-in-a-data-pipeline.md).  
  
## Example  
 The following example shows a common way to use the `call` class. This example passes a lambda function to the `call` constructor.  
  
 [!code[concrt-call-lambda#1](../VS_csharp/codesnippet/CPP/how-to--provide-work-functions-to-the-call-and-transformer-classes_1.cpp)]  
  
 This example produces the following output.  
  
 **13 squared is 169.**   
## Example  
 The following example resembles the previous one, except that it uses the `call` class together with a function object (functor).  
  
 [!code[concrt-call-functor#1](../VS_csharp/codesnippet/CPP/how-to--provide-work-functions-to-the-call-and-transformer-classes_2.cpp)]  
  
## Example  
 The following example resembles the previous one, except that it uses the [std::bind1st](../Topic/bind1st%20Function.md) and [std::mem_fun](../Topic/mem_fun%20Function.md) functions to bind a `call` object to a class method.  
  
 Use this technique if you have to bind a `call` or `transformer` object to a specific class method instead of the function call operator, `operator()`.  
  
 [!code[concrt-call-method#1](../VS_csharp/codesnippet/CPP/how-to--provide-work-functions-to-the-call-and-transformer-classes_3.cpp)]  
  
 You can also assign the result of the `bind1st` function to a [std::function](../VS_csharp/function-class.md) object or use the `auto` keyword, as shown in the following example.  
  
 [!code[concrt-call-method#2](../VS_csharp/codesnippet/CPP/how-to--provide-work-functions-to-the-call-and-transformer-classes_4.cpp)]  
  
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named `call.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc call.cpp**  
  
## See Also  
 [Asynchronous Agents Library](../VS_csharp/asynchronous-agents-library.md)   
 [Asynchronous Message Blocks](../VS_csharp/asynchronous-message-blocks.md)   
 [How to: Use transformer in a Data Pipeline](../VS_csharp/how-to--use-transformer-in-a-data-pipeline.md)   
 [call Class](../VS_csharp/call-class.md)   
 [transformer Class](../VS_csharp/transformer-class.md)