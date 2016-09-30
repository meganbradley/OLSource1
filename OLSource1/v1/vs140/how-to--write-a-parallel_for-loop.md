---
title: "How to: Write a parallel_for Loop"
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
  - "writing a parallel_for loop [Concurrency Runtime]"
  - "parallel_for function, example"
ms.assetid: adb4d64e-5514-4b70-8dcb-b9210e6b5a1c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write a parallel_for Loop
This example demonstrates how to use [concurrency::parallel_for](../vs140/parallel_for-function.md) to compute the product of two matrices.  
  
## Example  
 The following example shows the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> function, which computes the product of two square matrices.  
  
 [!code[concrt-parallel-matrix-multiply#1](../vs140/codesnippet/CPP/how-to--write-a-parallel_for-loop_1.cpp)]  
  
## Example  
 The following example shows the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function, which uses the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> algorithm to perform the outer loop in parallel.  
  
 [!code[concrt-parallel-matrix-multiply#2](../vs140/codesnippet/CPP/how-to--write-a-parallel_for-loop_2.cpp)]  
  
 This example parallelizes the outer loop only because it performs enough work to benefit from the overhead for parallel processing. If you parallelize the inner loop, you will not receive a gain in performance because the small amount of work that the inner loop performs does not overcome the overhead for parallel processing. Therefore, parallelizing the outer loop only is the best way to maximize the benefits of concurrency on most systems.  
  
## Example  
 The following more complete example compares the performance of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function versus the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function.  
  
 [!code[concrt-parallel-matrix-multiply#3](../vs140/codesnippet/CPP/how-to--write-a-parallel_for-loop_3.cpp)]  
  
 The following sample output is for a computer that has four processors.  
  
 **serial: 3853**  
**parallel: 1311**   
## Compiling the Code  
 To compile the code, copy it and then paste it in a Visual Studio project, or paste it in a file that is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc parallel-matrix-multiply.cpp**  
  
## See Also  
 [Parallel Algorithms](../vs140/parallel-algorithms.md)   
 [parallel_for Function](../vs140/parallel_for-function.md)