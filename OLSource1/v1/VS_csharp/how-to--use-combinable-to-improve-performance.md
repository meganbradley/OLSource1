---
title: "How to: Use combinable to Improve Performance"
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
  - "combinable class, example"
  - "improving parallel performance with combinable [Concurrency Runtime]"
ms.assetid: fa730580-1c94-4b2d-8aec-57c91dc0497e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use combinable to Improve Performance
This example shows how to use the [concurrency::combinable](../VS_csharp/combinable-class.md) class to compute the sum of the numbers in a [std::array](../VS_csharp/array-class--stl-.md) object that are prime. The `combinable` class improves performance by eliminating shared state.  
  
> [!TIP]
>  In some cases, parallel map ([concurrency::parallel_transform](../VS_csharp/parallel_transform-function.md)) and reduce ([concurrency:: parallel_reduce](../VS_csharp/parallel_reduce-function.md)) can provide performance improvements over `combinable`. For an example that uses map and reduce operations to produce the same results as this example, see [Parallel Algorithms](../VS_csharp/parallel-algorithms.md).  
  
## Example  
 The following example uses the [std::accumulate](../Topic/accumulate.md) function to compute the sum of the elements in an array that are prime. In this example, `a` is an `array` object and the `is_prime` function determines whether its input value is prime.  
  
 [!code[concrt-parallel-sum-of-primes#1](../VS_csharp/codesnippet/CPP/how-to--use-combinable-to-improve-performance_1.cpp)]  
  
## Example  
 The following example shows a naïve way to parallelize the previous example. This example uses the [concurrency::parallel_for_each](../VS_csharp/parallel_for_each-function.md) algorithm to process the array in parallel and a [concurrency::critical_section](../VS_csharp/critical_section-class.md) object to synchronize access to the `prime_sum` variable. This example does not scale because each thread must wait for the shared resource to become available.  
  
 [!code[concrt-parallel-sum-of-primes#2](../VS_csharp/codesnippet/CPP/how-to--use-combinable-to-improve-performance_2.cpp)]  
  
## Example  
 The following example uses a `combinable` object to improve the performance of the previous example. This example eliminates the need for synchronization objects; it scales because the `combinable` object enables each thread to perform its task independently.  
  
 A `combinable` object is typically used in two steps. First, produce a series of fine-grained computations by performing work in parallel. Next, combine (or reduce) the computations into a final result. This example uses the [concurrency::combinable::local](../VS_csharp/combinable--local-method.md) method to obtain a reference to the local sum. It then uses the [concurrency::combinable::combine](../VS_csharp/combinable--combine-method.md) method and a [std::plus](../VS_csharp/plus-struct.md) object to combine the local computations into the final result.  
  
 [!code[concrt-parallel-sum-of-primes#3](../VS_csharp/codesnippet/CPP/how-to--use-combinable-to-improve-performance_3.cpp)]  
  
## Example  
 The following complete example computes the sum of prime numbers both serially and in parallel. The example prints to the console the time that is required to perform both computations.  
  
 [!code[concrt-parallel-sum-of-primes#4](../VS_csharp/codesnippet/CPP/how-to--use-combinable-to-improve-performance_4.cpp)]  
  
 The following sample output is for a computer that has four processors.  
  
 **1709600813**  
**serial time: 6178 ms**  
**1709600813**  
**parallel time: 1638 ms**   
## Compiling the Code  
 To compile the code, copy it and then paste it in a Visual Studio project, or paste it in a file that is named `parallel-sum-of-primes.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc parallel-sum-of-primes.cpp**  
  
## Robust Programming  
 For an example that uses map and reduce operations to produce the same results, see [Parallel Algorithms](../VS_csharp/parallel-algorithms.md).  
  
## See Also  
 [Parallel Containers and Objects](../VS_csharp/parallel-containers-and-objects.md)   
 [combinable Class](../VS_csharp/combinable-class.md)   
 [critical_section Class](../VS_csharp/critical_section-class.md)