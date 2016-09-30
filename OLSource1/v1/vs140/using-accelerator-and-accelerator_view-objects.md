---
title: "Using accelerator and accelerator_view Objects"
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
ms.assetid: 18f0dc66-8236-4420-9f46-1a14f2c3fba1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using accelerator and accelerator_view Objects
You can use the [accelerator](../vs140/accelerator-class.md) and [accelerator_view](../vs140/accelerator_view-class.md) classes to specify the device or emulator to run your C++ AMP code on. A system might have several devices or emulators that differ by amount of memory, shared memory support, debugging support, or double-precision support. C++ Accelerated Massive Parallelism (C++ AMP) provides APIs that you can use to examine the available accelerators, set one as the default, specify multiple accelerator_views for multiple calls to parallel_for_each, and perform special debugging tasks.  
  
## Using the Default Accelerator  
 The C++ AMP runtime picks a default accelerator, unless you write code to pick a specific one. The runtime chooses the default accelerator as follows:  
  
1.  If the app is running in debug mode, an accelerator that supports debugging.  
  
2.  Otherwise, the accelerator that's specified by the CPPAMP_DEFAULT_ACCELERATOR environment variable, if it's set.  
  
3.  Otherwise, a non-emulated device.  
  
4.  Otherwise, the device that has the greatest amount of available memory.  
  
5.  Otherwise, a device that's not attached to the display.  
  
 Additionally, the runtime specifies an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for the default accelerator. This means that the default accelerator uses shared memory if it’s supported and if its performance characteristics (bandwidth and latency) are known to be the same as dedicated (non-shared) memory.  
  
 You can determine the properties of the default accelerator by constructing the default accelerator and examining its properties. The following code example prints the path, amount of accelerator memory, shared memory support, double-precision support, and limited double-precision support of the default accelerator.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### CPPAMP_DEFAULT_ACCELERATOR Environment Variable  
 You can set the CPPAMP_DEFAULT_ACCELERATOR environment variable to specify the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of the default accelerator. The path is hardware-dependent. The following code uses the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function to retrieve a list of the available accelerators and then displays the path and characteristics of each accelerator.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Selecting an Accelerator  
 To select an accelerator, use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method to retrieve a list of the available accelerators and then select one based on its properties. This example shows how to pick the accelerator that has the most memory:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
> [!NOTE]
>  One of the accelerators that are returned by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the CPU accelerator. You cannot execute code on the CPU accelerator. To filter out the CPU accelerator, compare the value of the [device_path](../vs140/accelerator--device_path-data-member.md) property of the accelerator that's returned by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with the value of the [accelerator::cpu_accelerator](../vs140/accelerator--cpu_accelerator-data-member.md). For more information, see the "Special Accelerators" section in this article.  
  
## Shared Memory  
 Shared memory is memory that can be accessed by both the CPU and the accelerator. The use of shared memory eliminates or significantly reduces the overhead of copying data between the CPU and the accelerator. Although the memory is shared, it cannot be accessed concurrently by both the CPU and the accelerator, and doing so causes undefined behavior. The accelerator property [supports_cpu_shared_memory](../vs140/accelerator--supports_cpu_shared_memory-data-member.md) returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the accelerator supports shared memory, and the [default_cpu_access_type](../vs140/accelerator--default_cpu_access_type-data-member.md) property gets the default [access_type](../vs140/access_type-enumeration.md) for memory allocated on the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>—for example, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>s associated with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects accessed on the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The C++ AMP runtime automatically chooses the best default <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for each <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, but the performance characteristics (bandwidth and latency) of shared memory can be worse than those of dedicated (non-shared) accelerator memory when reading from the CPU, writing from the CPU, or both. If shared memory performs as well as dedicated memory for reading and writing from the CPU, the runtime defaults to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; otherwise, the runtime chooses a more conservative default <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and allows the app to override it if the memory access patterns of its computation kernels benefit from a different <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 The following code example shows how to determine whether the default accelerator supports shared memory, and then overrides its default access type and creates an <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> from it.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> always reflects the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> it’s associated with, and it provides no interface to override or change its <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## Changing the Default Accelerator  
 You can change the default accelerator by calling the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method. You can change the default accelerator only once per app execution and you must change it before any code is executed on the GPU. Any subsequent function calls to change the accelerator return <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. If you want to use a different accelerator in a call to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, read the "Using Multiple Accelerators" section in this article. The following code example sets the default accelerator to one that is not emulated, is not connected to a display, and supports double-precision.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Using Multiple Accelerators  
 There are two ways to use multiple accelerators in your app:  
  
-   You can pass <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects to the calls to the [parallel_for_each](../vs140/parallel_for_each-function--c---amp-.md) method.  
  
-   You can construct an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object using a specific <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object. The C+AMP runtime will pick up the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object from the captured <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object in the lambda expression.  
  
## Special Accelerators  
 The device paths of three special accelerators are available as properties of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> class:  
  
-   [accelerator::direct3d_ref Data Member](../vs140/accelerator--direct3d_ref-data-member.md): This single-threaded accelerator uses software on the CPU to emulate a generic graphics card. It's used by default for debugging, but it's not useful in production because it's slower than the hardware accelerators. Additionally, it's available only in the DirectX SDK and the Windows SDK, and it's unlikely to be installed on your customers' computers. For more information, see [Debugging GPU Code](../vs140/debugging-gpu-code.md).  
  
-   [accelerator::direct3d_warp Data Member](../vs140/accelerator--direct3d_warp-data-member.md): This accelerator provides a fallback solution for executing C++ AMP code on multi-core CPUs that use Streaming SIMD Extensions (SSE).  
  
-   [accelerator::cpu_accelerator Data Member](../vs140/accelerator--cpu_accelerator-data-member.md): You can use this accelerator for setting up staging arrays. It cannot execute C++ AMP code. For more information, see the [Staging Arrays in C++ AMP](http://go.microsoft.com/fwlink/p/?LinkId=248485) post on the Parallel Programming in Native Code blog.  
  
## Interoperability  
 The C++ AMP runtime supports interoperability between the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class and the Direct3D [ID3D11Device interface](http://go.microsoft.com/fwlink/p/?LinkId=248488). The [create_accelerator_view](../vs140/create_accelerator_view-function.md) method takes an <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> interface and returns an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object. The [get_device](assetId:///8194125e-8396-4d62-aa8a-65831dea8439) method takes an <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object and returns an <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> interface.  
  
## See Also  
 [C++ Accelerated Massive Parallelism (C++ AMP)](../vs140/c---amp--c---accelerated-massive-parallelism-.md)   
 [Debugging GPU Code](../vs140/debugging-gpu-code.md)   
 [accelerator Class](../vs140/accelerator-class.md)   
 [accelerator_view Class](../vs140/accelerator_view-class.md)