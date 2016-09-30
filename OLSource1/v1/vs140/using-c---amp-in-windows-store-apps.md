---
title: "Using C++ AMP in Windows Store Apps"
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
ms.assetid: 85577298-2c28-4209-9470-eb21048615db
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using C++ AMP in Windows Store Apps
You can use C++ AMP (C++ Accelerated Massive Parallelism) in your [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app to perform calculations on the GPU (Graphics Processing Unit) or other computational accelerators. However, C++ AMP doesn't provide APIs for working directly with Windows Runtime types, and the Windows Runtime doesn't provide a wrapper for C++ AMP. When you use Windows Runtime types in your code—including those that you've created yourself—you must convert them to types that are compatible with C++ AMP.  
  
## Performance considerations  
 If you're using [!INCLUDE[cppwrt](../vs140/includes/cppwrt_md.md)] ([!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)]) to create your [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, we recommend that you use plain-old-data (POD) types together with contiguous storage—for example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or C-style arrays—for data that will be used with C++ AMP. This can help you achieve higher performance than by using non-POD types or Windows RT containers because no marshaling has to occur.  
  
 In a C++ AMP kernel, to access data that’s stored in this way, just wrap the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or array storage in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and then use the array view in a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> loop:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Marshaling Windows Runtime types  
 When you work with Windows Runtime APIs, you might want to use C++ AMP on data that's stored in a Windows Runtime container such as a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or in complex data types such as classes or structs that are declared by using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword or the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword. In these situations, you have to do some extra work to make the data available to C++ AMP.  
  
### Platform::Array\<T>^, where T is a POD type  
 When you encounter a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and T is a POD type, you can access its underlying storage just by using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If T is not a POD type, use the technique that's described in the following section to use the data with C++ AMP.  
  
### Windows Runtime types: ref classes and value classes  
 C++ AMP doesn't support complex data types. This includes non-POD types and any types that are declared by using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword or the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword. If an unsupported type is used in a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> context, a compile-time error is generated.  
  
 When you encounter an unsupported type, you can copy interesting parts of its data into a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object. In addition to making the data available for C++ AMP to consume, this manual-copy approach can also improve performance by maximizing data locality, and by ensuring that data that won't be used isn't copied to the accelerator. You can improve performance further by using a *staging array*, which is a special form of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> that provides a hint to the AMP runtime that the array should be optimized for frequent transfer between it and other arrays on the specified accelerator.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Create your first Windows Store app using C++](http://go.microsoft.com/fwlink/p/?LinkId=249073)   
 [Creating Windows Runtime Components in C++](http://go.microsoft.com/fwlink/p/?LinkId=249076)