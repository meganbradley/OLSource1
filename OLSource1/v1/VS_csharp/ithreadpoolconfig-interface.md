---
title: "IThreadPoolConfig Interface"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "IThreadPoolConfig"
  - "ATL::IThreadPoolConfig"
  - "ATL.IThreadPoolConfig"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IThreadPoolConfig interface"
ms.assetid: 69e642bf-6925-46e6-9a37-cce52231b1cc
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IThreadPoolConfig Interface
This interface provides methods for configuring a thread pool.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      __interface  
__declspec(uuid("B1F64757-6E88-4fa2-8886-7848B0D7E660"))  
IThreadPoolConfig :  
public IUnknown  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[GetSize](../VS_csharp/ithreadpoolconfig--getsize.md)|Call this method to get the number of threads in the pool.|  
|[GetTimeout](../VS_csharp/ithreadpoolconfig--gettimeout.md)|Call this method to get the maximum time in milliseconds that the thread pool will wait for a thread to shut down.|  
|[SetSize](../VS_csharp/ithreadpoolconfig--setsize.md)|Call this method to set the number of threads in the pool.|  
|[SetTimeout](../VS_csharp/ithreadpoolconfig--settimeout.md)|Call this method to set the maximum time in milliseconds that the thread pool will wait for a thread to shut down.|  
  
## Remarks  
 This interface is implemented by [CThreadPool](../VS_csharp/cthreadpool-class.md).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Classes](../VS_csharp/atl-classes.md)   
 [CThreadPool Class](../VS_csharp/cthreadpool-class.md)