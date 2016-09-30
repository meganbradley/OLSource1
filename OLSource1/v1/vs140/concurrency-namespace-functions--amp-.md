---
title: "Concurrency namespace functions (AMP)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2bef0985-cb90-4ece-90b9-66529aec73c9
caps.latest.revision: 10
---
# Concurrency namespace functions (AMP)
||||  
|-|-|-|  
|[all_memory_fence Function](#all_memory_fence_function)|[amp_uninitialize Function](#amp_uninitialize_function)|[atomic_compare_exchange Function](#atomic_compare_exchange_function)|  
|[atomic_exchange Function (C++ AMP)](#atomic_exchange_function__c_add_add_amp_)|[atomic_fetch_add Function (C++ AMP)](#atomic_fetch_add_function__c_add_add_amp_)|[atomic_fetch_and Function (C++ AMP)](#atomic_fetch_and_function__c_add_add_amp_)|  
|[atomic_fetch_dec Function](#atomic_fetch_dec_function)|[atomic_fetch_inc Function](#atomic_fetch_inc_function)|[atomic_fetch_max Function](#atomic_fetch_max_function)|  
|[atomic_fetch_min Function](#atomic_fetch_min_function)|[atomic_fetch_or Function (C++ AMP)](#atomic_fetch_or_function__c_add_add_amp_)|[atomic_fetch_sub Function (C++ AMP)](#atomic_fetch_sub_function__c_add_add_amp_)|  
|[atomic_fetch_xor Function (C++ AMP)](#atomic_fetch_xor_function__c_add_add_amp_)|[copy Function](#copy_function)|[copy_async Function](#copy_async_function)|  
|[direct3d_abort Function](#direct3d_abort_function)|[direct3d_errorf Function](#direct3d_errorf_function)|[direct3d_printf Function](#direct3d_printf_function)|  
|[global_memory_fence Function](#global_memory_fence_function)|[parallel_for_each Function (C++ AMP)](#parallel_for_each_function__c_add_add_amp_)|[tile_static_memory_fence Function](#tile_static_memory_fence_function)|  
  
##  \<a name="all_memory_fence_function">\</a>  all_memory_fence Function  
 Blocks execution of all threads in a tile until all memory accesses have been completed. This ensures that all memory accesses are visible to other threads in the thread tile, and are executed in program order.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
##  \<a name="amp_uninitialize_function">\</a>  amp_uninitialize Function  
 Uninitializes the C++ AMP runtime. It is legal to call this function multiple times during an applications lifetime. Calling any C++ AMP API afer calling this function will reinitialize the C++ AMP runtime. Note that it is illegal to use C++ AMP objects across calls to this function and doing so will result in undefined behavior. Also, concurrently calling this function and any other AMP APIs is illegal and would result in undefined behavior.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="atomic_compare_exchange_function">\</a>  atomic_compare_exchange Function  
 Atomically compares the value stored at a memory location specified in the first argument for equality with the value of the second specified argument, and if the values are the same, the value at the memory location is changed to that of the third specified argument.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The location from which one of the values to be compared is read, and to which the new value, if any, is to be stored.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The location from which the second value to be compared is read.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The value to be stored to the memory location specified in by                                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> if                                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is equal to                                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if the operation is successful; otherwise,                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_exchange_function__c_add_add_amp_">\</a>  atomic_exchange Function (C++ AMP)  
 Sets the value of destination location as an atomic operation.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to the destionation location.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The new value.  
  
### Return Value  
 The original value of the destination location.  
  
##  \<a name="atomic_fetch_add_function__c_add_add_amp_">\</a>  atomic_fetch_add Function (C++ AMP)  
 Atomically add a value to the value of a memory location.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Pointer to the memory location.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The value to be added.  
  
### Return Value  
 The original value of the memory location.  
  
##  \<a name="atomic_fetch_and_function__c_add_add_amp_">\</a>  atomic_fetch_and Function (C++ AMP)  
 Atomically performs a bitwise AND operation of a value and the value of a memory location.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Pointer to the memory location.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The value to use in the bitwise AND calculation.  
  
### Return Value  
 The original value of the memory location.  
  
##  \<a name="atomic_fetch_dec_function">\</a>  atomic_fetch_dec Function  
 Atomically decrements the value stored at the specified memory location.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The location in memory of the value to be decremented.  
  
### Return Value  
 The original value stored at the memory location.  
  
##  \<a name="atomic_fetch_inc_function">\</a>  atomic_fetch_inc Function  
 Atomically increments the value stored at the specified memory location.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The location in memory of the value to be incremented.  
  
### Return Value  
 The original value stored at the memory location.  
  
##  \<a name="atomic_fetch_max_function">\</a>  atomic_fetch_max Function  
 Atomically computes the maximum value between the value stored at the memory location specified in the first argument and the value specified in the second argument, and stores it at the same memory location.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The location from which one of the values to be compared is read, and to which the maximum of the two values is to be stored.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The value to be compared to the value at the specified location.  
  
### Return Value  
 The original value stored at the specified location location.  
  
##  \<a name="atomic_fetch_min_function">\</a>  atomic_fetch_min Function  
 Atomically computes the minimum value between the value stored at the memory location specified in the first argument and the value specified in the second argument, and stores it at the same memory location.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The location from which one of the values to be compared is read, and to which the minimum of the two values is to be stored.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The value to be compared to the value at the specified location.  
  
### Return Value  
 The original value stored at the specified location location.  
  
##  \<a name="atomic_fetch_or_function__c_add_add_amp_">\</a>  atomic_fetch_or Function (C++ AMP)  
 Atomically performs a bitwise OR operation with a value and the value of a memory location.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Pointer to the memory location.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The value to use in the bitwise OR calculation.  
  
### Return Value  
 The original value of the memory location.  
  
##  \<a name="atomic_fetch_sub_function__c_add_add_amp_">\</a>  atomic_fetch_sub Function (C++ AMP)  
 Atomically subtracts a value from a memory location.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Pointer to the destionation location.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The value to be subtracted.  
  
### Return Value  
 The original value of the memory location.  
  
##  \<a name="atomic_fetch_xor_function__c_add_add_amp_">\</a>  atomic_fetch_xor Function (C++ AMP)  
 Atomically peforms an bitwise XOR operation of a value and a memory location.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Pointer to the memory location.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The value to use in the XOR calculation.  
  
### Return Value  
 The original value of the memory location.  
  
##  \<a name="copy_function">\</a>  copy Function  
 Copies a C++ AMP object. All synchronous data transfer requirements are met. You can't copy data when running code on an accelerator. The general form of this function is                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The object to copy to.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 An output iterator to the beginning position at destination.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The type of the output iterator.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The rank of the object to copy from or the object to copy to.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 To object to copy.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The data type of the elements that are copied.  
  
##  \<a name="copy_async_function">\</a>  copy_async Function  
 Copies a C++ AMP object and returns a                 [completion_future](../vs140/completion_future-class.md) object that can be waited on. You can't copy data when running code on an accelerator.  The general form of this function is                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The object to copy to.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 An output iterator to the beginning position at destination.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The type of the input interator.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The type of the output iterator.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The rank of the object to copy from or the object to copy to.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 To object to copy.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A beginning iterator into the source container.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 An ending iterator into the source container.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The data type of the elements that are copied.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> that can be waited on.  
  
##  \<a name="direct3d_abort_function">\</a>  direct3d_abort Function  
 Aborts the execution of a function with the                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> restriction clause. When the AMP runtime detects the call, it raises a                 [runtime_exception](../vs140/runtime_exception-class.md) exception with the error message "Reference Rasterizer: Shader abort instruction hit".  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="direct3d_errorf_function">\</a>  direct3d_errorf Function  
 Prints a formatted string to the Visual Studio output window. It is called from a function with the                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> restriction clause. When the AMP runtime detects the call, it raises a                 [runtime_exception](../vs140/runtime_exception-class.md) exception with the same formatting string.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
##  \<a name="direct3d_printf_function">\</a>  direct3d_printf Function  
 Prints a formatted string to the Visual Studio output window. It is called from a function with the                 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> restriction clause.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="global_memory_fence_function">\</a>  global_memory_fence Function  
 Blocks execution of all threads in a tile until all global memory accesses have been completed. This ensures that global memory accesses are visible to other threads in the thread tile, and are executed in program order.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A tile_barrier object  
  
##  \<a name="parallel_for_each_function__c_add_add_amp_">\</a>  parallel_for_each Function (C++ AMP)  
 Runs a function across the compute domain. For more information, see                 [Overview of C++ Accelerated Massive Parallelism (C++ AMP)](../vs140/c---amp-overview.md).  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object to run the parallel computation on.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 An                                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object that contains the data for the computation.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The dimension of the                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The dimension of the                                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The dimension of the                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A lambda or function object that takes an argument of type "index\<_Rank>" and performs the parallel computation.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A lambda or functor.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The rank of the extent.  
  
##  \<a name="tile_static_memory_fence_function">\</a>  tile_static_memory_fence Function  
 Blocks execution of all threads in a tile until all outstanding                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> memory accesses have been completed. This ensures that                 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> memory accesses are visible to other threads in the thread tile, and that accesses are executed in program order.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A tile_barrier object.  
  
## See Also  
 [Concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)