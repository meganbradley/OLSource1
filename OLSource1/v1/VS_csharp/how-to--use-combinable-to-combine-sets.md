---
title: "How to: Use combinable to Combine Sets"
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
  - "combining sets with combinable [Concurrency Runtime]"
ms.assetid: 66ffe8e3-6bbb-4e9f-b790-b612922a68a7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use combinable to Combine Sets
This topic shows how to use the [concurrency::combinable](../VS_csharp/combinable-class.md) class to compute the set of prime numbers.  
  
## Example  
 The following example computes the set of prime numbers two times. Each computation stores the result in a [std::bitset](../VS_csharp/bitset-class.md) object. The example first computes the set serially and then computes the set in parallel. The example also prints to the console the time that is required to perform both computations.  
  
 This example uses the [concurrency::parallel_for](../VS_csharp/parallel_for-function.md) algorithm and a `combinable` object to generate thread-local sets. It then uses the [concurrency::combinable::combine_each](../VS_csharp/combinable--combine_each-method.md) method to combine the thread-local sets into the final set.  
  
 [!code[concrt-parallel-combine-primes#1](../VS_csharp/codesnippet/CPP/how-to--use-combinable-to-combine-sets_1.cpp)]  
  
 The following sample output is for a computer that has four processors.  
  
 **serial time: 312 ms**  
**parallel time: 78 ms**   
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named `parallel-combine-primes.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc parallel-combine-primes.cpp**  
  
## See Also  
 [Parallel Containers and Objects](../VS_csharp/parallel-containers-and-objects.md)   
 [combinable Class](../VS_csharp/combinable-class.md)   
 [combinable::combine_each Method](../VS_csharp/combinable--combine_each-method.md)