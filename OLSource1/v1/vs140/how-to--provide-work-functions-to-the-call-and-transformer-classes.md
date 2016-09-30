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
This topic illustrates several ways to provide work functions to the [concurrency::call](../vs140/call-class.md) and [concurrency::transformer](../vs140/transformer-class.md) classes.  
  
 The first example shows how to pass a lambda expression to a `call` object. The second example shows how to pass a function object to a `call` object. The third example shows how to bind a class method to a `call` object.  
  
 For illustration, every example in this topic uses the `call` class. For an example that uses the `transformer` class, see [How to: Use transformer in a Data Pipeline](../vs140/how-to--use-transformer-in-a-data-pipeline.md).  
  
## Example  
 The following example shows a common way to use the `call` class. This example passes a lambda function to the `call` constructor.  
  
 [!code[concrt-call-lambda#1](../vs140/codesnippet/CPP/how-to--provide-work-functions-to-the-call-and-transformer-classes_1.cpp)]  
  
 This example produces the following output.  
  
 **13 squared is 169.**   
## Example  
 The following example resembles the previous one, except that it uses the `call` class together with a function object (functor).  
  
 [!code[concrt-call-functor#1](../vs140/codesnippet/CPP/how-to--provide-work-functions-to-the-call-and-transformer-classes_2.cpp)]  
  
## Example  
 The following example resembles the previous one, except that it uses the [std::bind1st](../vs140/bind1st-function.md) and [std::mem_fun](../vs140/mem_fun-function.md) functions to bind a `call` object to a class method.  
  
 Use this technique if you have to bind a `call` or `transformer` object to a specific class method instead of the function call operator, `operator()`.  
  
 [!code[concrt-call-method#1](../vs140/codesnippet/CPP/how-to--provide-work-functions-to-the-call-and-transformer-classes_3.cpp)]  
  
 You can also assign the result of the `bind1st` function to a [std::function](../vs140/function-class.md) object or use the `auto` keyword, as shown in the following example.  
  
 [!code[concrt-call-method#2](../vs140/codesnippet/CPP/how-to--provide-work-functions-to-the-call-and-transformer-classes_4.cpp)]  
  
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named `call.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc call.cpp**  
  
## See Also  
 [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md)   
 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)   
 [How to: Use transformer in a Data Pipeline](../vs140/how-to--use-transformer-in-a-data-pipeline.md)   
 [call Class](../vs140/call-class.md)   
 [transformer Class](../vs140/transformer-class.md)