---
title: "How to: Use Cancellation to Break from a Parallel Loop"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - writing a parallel search algorithm [Concurrency Runtime]
  - parallel search algorithm, writing [Concurrency Runtime]
ms.assetid: 421cd2de-f058-465f-b890-dd8fcc0df273
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Use Cancellation to Break from a Parallel Loop
This example shows how to use cancellation to implement a basic parallel search algorithm.  
  
## Example  
 The following example uses cancellation to search for an element in an array. The `parallel_find_any` function uses the [concurrency::parallel_for](../vs140/parallel_for-function.md) algorithm and the [concurrency::run_with_cancellation_token](../vs140/run_with_cancellation_token-function.md) function to search for the position that contains the given value. When the parallel loop finds the value, it calls the [concurrency::cancellation_token_source::cancel](../vs140/cancellation_token_source--cancel-method.md) method to cancel future work.  
  
 [!code[concrt-parallel-array-search#1](../vs140/codesnippet/CPP/how-to--use-cancellation-to-break-from-a-parallel-loop_1.cpp)]
  
  
 The [concurrency::parallel_for](../vs140/parallel_for-function.md) algorithm acts concurrently. Therefore, it does not perform the operations in a pre-determined order. If the array contains multiple instances of the value, the result can be any one of its positions.  
  
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named `parallel-array-search.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc parallel-array-search.cpp**  
  
## See Also  
 [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md)   
 [Parallel Algorithms](../vs140/parallel-algorithms.md)   
 [parallel_for Function](../vs140/parallel_for-function.md)   
 [cancellation_token_source Class](../vs140/cancellation_token_source-class.md)