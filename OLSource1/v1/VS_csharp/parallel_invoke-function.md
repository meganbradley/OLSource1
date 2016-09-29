---
title: "parallel_invoke Function"
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
  - "ppl/concurrency::parallel_invoke"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_invoke function"
ms.assetid: 8c8fe553-f372-4138-b9c6-e31b0e83eb9b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_invoke Function
Executes the function objects supplied as parameters in parallel, and blocks until they have finished executing. Each function object could be a lambda expression, a pointer to function, or any object that supports the function call operator with the signature `void operator()()`.  
  
## Syntax  
  
```  
template <  
   typename _Function1,  
   typename _Function2  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2  
);  
  
template <  
   typename _Function1,  
   typename _Function2,  
   typename _Function3  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2,  
   const _Function3& _Func3  
);  
  
template <  
   typename _Function1,  
   typename _Function2,  
   typename _Function3,  
   typename _Function4  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2,  
   const _Function3& _Func3,  
   const _Function4& _Func4  
);  
  
template <  
   typename _Function1,  
   typename _Function2,  
   typename _Function3,  
   typename _Function4,  
   typename _Function5  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2,  
   const _Function3& _Func3,  
   const _Function4& _Func4,  
   const _Function5& _Func5  
);  
  
template <  
   typename _Function1,  
   typename _Function2,  
   typename _Function3,  
   typename _Function4,  
   typename _Function5,  
   typename _Function6  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2,  
   const _Function3& _Func3,  
   const _Function4& _Func4,  
   const _Function5& _Func5,  
   const _Function6& _Func6  
);  
  
template <  
   typename _Function1,  
   typename _Function2,  
   typename _Function3,  
   typename _Function4,  
   typename _Function5,  
   typename _Function6,  
   typename _Function7  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2,  
   const _Function3& _Func3,  
   const _Function4& _Func4,  
   const _Function5& _Func5,  
   const _Function6& _Func6,  
   const _Function7& _Func7  
);  
  
template <  
   typename _Function1,  
   typename _Function2,  
   typename _Function3,  
   typename _Function4,  
   typename _Function5,  
   typename _Function6,  
   typename _Function7,  
   typename _Function8  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2,  
   const _Function3& _Func3,  
   const _Function4& _Func4,  
   const _Function5& _Func5,  
   const _Function6& _Func6,  
   const _Function7& _Func7,  
   const _Function8& _Func8  
);  
  
template <  
   typename _Function1,  
   typename _Function2,  
   typename _Function3,  
   typename _Function4,  
   typename _Function5,  
   typename _Function6,  
   typename _Function7,  
   typename _Function8,  
   typename _Function9  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2,  
   const _Function3& _Func3,  
   const _Function4& _Func4,  
   const _Function5& _Func5,  
   const _Function6& _Func6,  
   const _Function7& _Func7,  
   const _Function8& _Func8,  
   const _Function9& _Func9  
);  
  
template <  
   typename _Function1,  
   typename _Function2,  
   typename _Function3,  
   typename _Function4,  
   typename _Function5,  
   typename _Function6,  
   typename _Function7,  
   typename _Function8,  
   typename _Function9,  
   typename _Function10  
>  
void parallel_invoke(  
   const _Function1& _Func1,  
   const _Function2& _Func2,  
   const _Function3& _Func3,  
   const _Function4& _Func4,  
   const _Function5& _Func5,  
   const _Function6& _Func6,  
   const _Function7& _Func7,  
   const _Function8& _Func8,  
   const _Function9& _Func9,  
   const _Function10& _Func10  
);  
```  
  
#### Parameters  
 `_Function1`  
 The type of the first function object to be executed in parallel.  
  
 `_Function2`  
 The type of the second function object to be executed in parallel.  
  
 `_Function3`  
 The type of the third function object to be executed in parallel.  
  
 `_Function4`  
 The type of the fourth function object to be executed in parallel.  
  
 `_Function5`  
 The type of the fifth function object to be executed in parallel.  
  
 `_Function6`  
 The type of the sixth function object to be executed in parallel.  
  
 `_Function7`  
 The type of the seventh function object to be executed in parallel.  
  
 `_Function8`  
 The type of the eighth function object to be executed in parallel.  
  
 `_Function9`  
 The type of the ninth function object to be executed in parallel.  
  
 `_Function10`  
 The type of the tenth function object to be executed in parallel.  
  
 `_Func1`  
 The first function object to be executed in parallel.  
  
 `_Func2`  
 The second function object to be executed in parallel.  
  
 `_Func3`  
 The third function object to be executed in parallel.  
  
 `_Func4`  
 The fourth function object to be executed in parallel.  
  
 `_Func5`  
 The fifth function object to be executed in parallel.  
  
 `_Func6`  
 The sixth function object to be executed in parallel.  
  
 `_Func7`  
 The seventh function object to be executed in parallel.  
  
 `_Func8`  
 The eighth function object to be executed in parallel.  
  
 `_Func9`  
 The ninth function object to be executed in parallel.  
  
 `_Func10`  
 The tenth function object to be executed in parallel.  
  
## Remarks  
 Note that one or more of the function objects supplied as parameters may execute inline on the calling context.  
  
 If one or more of the function objects passed as parameters to this function throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to `parallel_invoke`.  
  
 For more information, see [Parallel Algorithms](../VS_csharp/parallel-algorithms.md).  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)