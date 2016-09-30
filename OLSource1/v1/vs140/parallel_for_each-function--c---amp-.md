---
title: "parallel_for_each Function (C++ AMP)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::parallel_for_each"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_for_each function"
ms.assetid: 449013a2-5f16-4280-ac1a-0d850f7d5160
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_for_each Function (C++ AMP)
Runs a function across the compute domain. For more information, see [Overview of C++ Accelerated Massive Parallelism (C++ AMP)](../vs140/c---amp-overview.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to run the parallel computation on.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that contains the data for the computation.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The dimension of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The dimension of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The dimension of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A lambda or function object that takes an argument of type "index\<_Rank>" and performs the parallel computation.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A lambda or functor.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The rank of the extent.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function starts data-parallel computations on accelerator devices. The basic behavior of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is like that of [for_each](../vs140/for_each.md), which runs a function on each element that's in a container. The basic components in a call to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are a *compute domain*, an *index*, and a *kernel function*. When <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> runs, a parallel activity is run for each index in the compute domain. You can use the parallel activity to access the elements in the input or output arrays. A call to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> behaves as though it's synchronous. In practice, the call is asynchronous because it runs on a separate device. There are no guarantees about the order and concurrency of the parallel activities run by the non-tiled <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Activities communicate only by using atomic functions.  
  
 The tiled version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> organizes the parallel activities into tiles that have a fixed size and 1, 2, or 3 dimensions, as specified in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument. Threads in the same tile have access to any variables declared with the [tile_static](../vs140/tile_static-keyword.md) keyword. You can use the [tile_barrier::wait](../vs140/tile_barrier--wait-method.md) method to synchronize access to variables declared with the [tile_static](../vs140/tile_static-keyword.md) keyword. The following restrictions apply to the tiled <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>:  
  
-   The product of the tile extent dimensions cannot exceed 1024.  
  
    -   3D:  D0 * D1 \* D2 ≤ 1024; and D0 ≤ 64  
  
    -   2D:  D0 * D1 ≤ 1024  
  
    -   1D:  D0 ≤ 1024  
  
-   The tiled grid provided as the first parameter to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> must be divisible, along each of its dimensions, by the corresponding tile extent.  
  
 For more information, see [Using Tiles](../vs140/using-tiles.md).  
  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> code runs on an accelerator, usually a GPU device. You can pass this accelerator explicitly to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> as an optional <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter. Otherwise, the target accelerator is chosen from the objects of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> that are captured in the kernel function. If all arrays aren’t bound to the same accelerator, an exception is thrown. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> argument passed to the kernel contains a collection of indexes, including those that are relative to the current tile.  
  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> function must be a lambda or function object. To run on an accelerator, the lambda must include the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> clause, although it can have additional restrictions. The restriction clause imposes several restrictions of the kernel function. For more information, see [Restriction Clause (C++ AMP)](../vs140/restrict--c---amp-.md).  
  
 You must be able to invoke the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument by using one of the following argument types:  
  
-   Non-tiled: <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> must be the same rank as the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> used in the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
-   Tiled: A <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object whose dimensions match those of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object used in the call to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 The kernel function must return <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 Because the kernel function doesn't take any other arguments, all other data operated on by the kernel must be captured in the lambda or function object. All captured data must be passed by value, except for <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> objects, which must be captured by reference or pointer. Several restrictions also apply on the object types that can be captured. For more information, see [Restriction Clause (C++ AMP)](../vs140/restrict--c---amp-.md).  
  
 If an error occurs when trying to start the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, call the runtime throws an exception.  Exceptions can be thrown the following reasons:  
  
-   Failure to create the shader.  
  
-   Failure to create buffers.  
  
-   Invalid extent passed.  
  
-   Mismatched accelerators.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)