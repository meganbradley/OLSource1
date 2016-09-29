---
title: "Concurrency Namespace (C++ AMP)"
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
  - "amp/Concurrency"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Concurrency namespace"
ms.assetid: b5aab265-3bac-42c5-8ead-f92ce05ef267
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Concurrency Namespace (C++ AMP)
Provides classes and functions that accelerate the execution of C++ code on data-parallel hardware. For more information, see [Overview (C++ AMP).](../vs140/c---amp-overview.md)  
  
## Syntax  
  
```  
namespace Concurrency;  
```  
  
## Members  
  
### Namespaces  
  
|Name|Description|  
|----------|-----------------|  
|[direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)|Provides functions that support D3D interoperability. Enables seamless use of D3D resources for compute in AMP code and the use of resources created in AMP in D3D code, without creating redundant intermediate copies. You can use C++ AMP to incrementally accelerate the compute-intensive sections of your DirectX applications and use the D3D API on data produced from AMP computations.|  
|[Concurrency::fast_math Namespace](../vs140/concurrency--fast_math-namespace.md)|Functions in the `fast_math` namespace are not C99-compliant. Only single-precision versions of each function are provided. These functions use the DirectX intrinsic functions, which are faster than the corresponding functions in the `precise_math` namespace and do not require extended double-precision support on the accelerator, but they are less accurate. There are two versions of each function for source-level compatibility with C99 code; both versions take and return single-precision values.|  
|[Concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)|Provides types and functions that are designed for graphics programming.|  
|[Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)|Functions in the `precise_math` namespace are C99 compliant. Both single-precision and double-precision versions of each function are included. These functions—this includes the single-precision functions—require extended double-precision support on the accelerator.|  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator Class](../vs140/accelerator-class.md)|Represents an abstraction of a physical DP-optimized compute node.|  
|[accelerator_view Class](../vs140/accelerator_view-class.md)|Represents a virtual device abstraction on a C++ AMP data-parallel accelerator.|  
|[Accelerator_view_removed Class](../vs140/accelerator_view_removed-class.md)|The exception that is thrown when an underlying DirectX call fails due to the Windows timeout-detection-and-recovery mechanism.|  
|[array Class](../vs140/array-class.md)|A data aggregate on an `accelerator_view` in the grid domain. It is a collection of variables, one for each element in a grid domain. Each variable holds a value that corresponds to some C++ type.|  
|[array_view Class](../vs140/array_view-class.md)|Represents a view into the data in an array<T,N>.|  
|[completion_future Class](../vs140/completion_future-class.md)|Represents a future that corresponds to a C++ AMP asynchronous operation.|  
|[extent Class  (C++ AMP)](../vs140/extent-class--c---amp-.md)|Represents a vector of N integer values that specify the bounds of an N-dimensional space that has an origin of 0. The values in the coordinate vector are ordered from most significant to least significant. For example, in Cartesian 3-dimensional space, the extent vector (7,5,3) represents a space in which the z coordinate ranges from 0 to 7, the y coordinate ranges from 0 to 5, and the x coordinate ranges from 0 to 3.|  
|[index Class](../vs140/index-class.md)|Defines an N-dimensional index point.|  
|[invalid_compute_domain Class](../vs140/invalid_compute_domain-class.md)|The exception that's thrown when the runtime can't start a kernel by using the compute domain specified at the `parallel_for_each` call site.|  
|[out_of_memory Class](../vs140/out_of_memory-class.md)|The exception that is thrown when a method fails because of a lack of system or device memory.|  
|[runtime_exception Class](../vs140/runtime_exception-class.md)|The base type for exceptions in the C++ AMP library.|  
|[tile_barrier Class](../vs140/tile_barrier-class.md)|A capability class that is only creatable by the system and is passed to a tiled `parallel_for_each` lambda as part of the `tiled_index` parameter. It provides one method, `wait()`, whose purpose is to synchronize execution of threads that are running in the thread group (tile).|  
|[tiled_extent Class](../vs140/tiled_extent-class.md)|A `tiled_extent` object is an `extent` object of one to three dimensions that subdivides the extent space into one-dimensional, two-dimensional, or three-dimensional tiles.|  
|[tiled_index Class](../vs140/tiled_index-class.md)|Provides an index into a `tiled_grid` object. This class has properties to access element relative to the local tile origin and relative to the global origin.|  
|[uninitialized_object Class](../vs140/uninitialized_object-class.md)|The exception that is thrown when an uninitialized object is used.|  
|[unsupported_feature Class](../vs140/unsupported_feature-class.md)|The exception that is thrown when an unsupported feature is used.|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[Access_type Enumeration](../vs140/access_type-enumeration.md)|Specifies the data access type.|  
|[queuing_mode Enumeration](../vs140/queuing_mode-enumeration.md)|Specifies the queuing modes that are supported on the accelerator.|  
  
### Operators  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator== Operator (C++ AMP)](../vs140/operator==-operator--c---amp-.md)|Determines whether the specified data structures are equal.|  
|[Operator!= Operator (C++ AMP)](../vs140/operator!=-operator--c---amp-.md)|Determines whether the specified data structures are unequal.|  
|[operator+ Operator (C++ AMP)](../vs140/operator--operator--c---amp-.md)|Computes the component-wise sum of the specified arguments.|  
|[operator- Operator (C++ AMP)](../vs140/operator--operator--c---amp-1.md)|Computes the component-wise difference between the specified arguments.|  
|[operator* Operator (C++ AMP)](../vs140/operator--operator--c---amp-.md)|Computes the component-wise product of the specified arguments.|  
|[operator/ Operator (C++ AMP)](../vs140/operator--operator--c---amp-2.md)|Computes the component-wise quotient of the specified arguments.|  
|[operator% Operator (C++ AMP)](../vs140/operator--operator--c---amp-.md)|Computes the modulus of the first specified argument by the second specified argument.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[all_memory_fence Function](../vs140/all_memory_fence-function.md)|Blocks execution of all threads in a tile until all memory accesses have been completed.|  
|[amp_uninitialize Function](../vs140/amp_uninitialize-function.md)|Uninitializes the C++ AMP runtime.|  
|[atomic_compare_exchange Function](../vs140/atomic_compare_exchange-function.md)|Overloaded. If the value stored at the specified location compares equal to the first specified value, then the second specified value is stored in the same location as an atomic operation.|  
|[atomic_exchange Function](../vs140/atomic_exchange-function--c---amp-.md)|Overloaded. Sets the value stored at the specified location to the specified value as an atomic operation.|  
|[atomic_fetch_add Function](../vs140/atomic_fetch_add-function--c---amp-.md)|Overloaded. Sets the value stored at the specified location to the sum of that value and a specified value as an atomic operation.|  
|[atomic_fetch_and Function](../vs140/atomic_fetch_and-function--c---amp-.md)|Overloaded. Sets the value stored at the specified location to the bitwise `and` of that value and a specified value as an atomic operation.|  
|[atomic_fetch_dec Function](../vs140/atomic_fetch_dec-function.md)|Overloaded. Decrements the value stored at the specified location and stores the result in the same location as an atomic operation.|  
|[atomic_fetch_inc Function](../vs140/atomic_fetch_inc-function.md)|Overloaded. Increments the value stored at the specified location and stores the result in the same location as an atomic operation.|  
|[atomic_fetch_max Function](../vs140/atomic_fetch_max-function.md)|Overloaded. Sets the value stored at the specified location to the larger of that value and a specified value as an atomic operation.|  
|[atomic_fetch_min Function](../vs140/atomic_fetch_min-function.md)|Overloaded. Sets the value stored at the specified location to the smaller of that value and a specified value as an atomic operation.|  
|[atomic_fetch_or Function](../vs140/atomic_fetch_or-function--c---amp-.md)|Overloaded. Sets the value stored at the specified location to the bitwise `or` of that value and a specified value as an atomic operation.|  
|[atomic_fetch_sub Function](../vs140/atomic_fetch_sub-function--c---amp-.md)|Overloaded. Sets the value stored at the specified location to the difference of that value and a specified value as an atomic operation.|  
|[atomic_fetch_xor Function](../vs140/atomic_fetch_xor-function--c---amp-.md)|Overloaded. Sets the value stored at the specified location to the bitwise `xor` of that value and a specified value as an atomic operation.|  
|[copy Function](../vs140/copy-function.md)|Copies a C++ AMP object. All synchronous data transfer requirements are met. Data can't be copied when code is running code on an accelerator. The general form of this function is `copy(src, dest)`.|  
|[copy_async Function](../vs140/copy_async-function.md)|Copies a C++ AMP object and returns [completion_future](../vs140/completion_future-class.md) that can be waited on. Data can't be copied when code is running on an accelerator. The general form of this function is `copy(src, dest)`.|  
|[direct3d_abort Function](../vs140/direct3d_abort-function.md)|Aborts the execution of a function that has the `restrict(amp)` restriction clause.|  
|[direct3d_errorf Function](../vs140/direct3d_errorf-function.md)|Prints a formatted string to the Visual Studio **Output** window and raises a [runtime_exception](../vs140/runtime_exception-class.md) exception that has the same formatting string.|  
|[direct3d_printf Function](../vs140/direct3d_printf-function.md)|Prints a formatted string to the Visual Studio **Output** window. It is called from a function that has the `restrict(amp)` restriction clause.|  
|[Global_memory_fence Function](../vs140/global_memory_fence-function.md)|Blocks execution of all threads in a tile until all global memory accesses have been completed.|  
|[parallel_for_each Function (C++ Accelerated Massive Parallelism)](../vs140/parallel_for_each-function--c---amp-.md)|Runs a function across the compute domain.|  
|[tile_static_memory_fence Function](../vs140/tile_static_memory_fence-function.md)|Blocks execution of all threads in a tile until `tile_static` memory accesses have been completed.|  
  
## Constants  
  
|Name|Description|  
|----------|-----------------|  
|[HLSL_MAX_NUM_BUFFERS Constant](../vs140/hlsl_max_num_buffers-constant.md)|The maximum number of buffers allowed by DirectX.|  
|[MODULENAME_MAX_LENGTH Constant](../vs140/modulename_max_length-constant.md)|Stores the maximum length of the module name. This value must be the same on the compiler and the runtime.|  
  
## Requirements  
 **Header:** amp.h  
  
## See Also  
 [Reference (C++ Accelerated Massive Parallelism)](../vs140/reference--c---amp-.md)