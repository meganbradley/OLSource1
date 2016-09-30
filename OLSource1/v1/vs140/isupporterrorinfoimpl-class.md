---
title: "ISupportErrorInfoImpl Class"
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
  - "ATL::ISupportErrorInfoImpl<piid>"
  - "ATL::ISupportErrorInfoImpl"
  - "ISupportErrorInfoImpl"
  - "ATL.ISupportErrorInfoImpl<piid>"
  - "ATL.ISupportErrorInfoImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ISupportErrorInfo ATL implementation"
  - "ISupportErrorInfoImpl class"
  - "error information, ATL"
ms.assetid: e33a4b11-a123-41cf-bcea-7b19743902af
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISupportErrorInfoImpl Class
This class provides a default implementation of the [ISupportErrorInfo Interface](assetId:///42d33066-36b4-4a5b-aa5d-46682e560f32) and can be used when only a single interface generates errors on an object.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the IID of an interface that supports [IErrorInfo](assetId:///4dda6909-2d9a-4727-ae0c-b5f90dcfa447).  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ISupportErrorInfoImpl::InterfaceSupportsErrorInfo](../vs140/isupporterrorinfoimpl--interfacesupportserrorinfo.md)|Indicates whether the interface identified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> supports the [IErrorInfo](assetId:///4dda6909-2d9a-4727-ae0c-b5f90dcfa447) interface.|  
  
## Remarks  
 The [ISupportErrorInfo Interface](assetId:///42d33066-36b4-4a5b-aa5d-46682e560f32) ensures that error information can be returned to the client. Objects that use **IErrorInfo** must implement **ISupportErrorInfo**.  
  
 Class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> provides a default implementation of **ISupportErrorInfo** and can be used when only a single interface generates errors on an object. For example:  
  
 [!code[NVC_ATL_COM#48](../vs140/codesnippet/CPP/isupporterrorinfoimpl-class_1.h)]  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="isupporterrorinfoimpl__interfacesupportserrorinfo">\</a>  ISupportErrorInfoImpl::InterfaceSupportsErrorInfo  
 Indicates whether the interface identified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> supports the [IErrorInfo](assetId:///4dda6909-2d9a-4727-ae0c-b5f90dcfa447) interface.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 See [ISupportErrorInfo::InterfaceSupportsErrorInfo](assetId:///a54ef18d-ee3f-4483-ac4a-99d758f0960a) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ithreadpoolconfig__getsize">\</a>  IThreadPoolConfig::GetSize  
 Call this method to get the number of threads in the pool.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [out] Address of the variable that, on success, receives the number of threads in the pool.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Example  
 [!code[NVC_ATL_Utilities#134](../vs140/codesnippet/CPP/isupporterrorinfoimpl-class_2.cpp)]  
  
##  \<a name="ithreadpoolconfig__gettimeout">\</a>  IThreadPoolConfig::GetTimeout  
 Call this method to get the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [out] Address of the variable that, on success, receives the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Example  
 See [IThreadPoolConfig::GetSize](../vs140/ithreadpoolconfig--getsize.md).  
  
##  \<a name="ithreadpoolconfig__setsize">\</a>  IThreadPoolConfig::SetSize  
 Call this method to set the number of threads in the pool.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The requested number of threads in the pool.  
  
 If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is negative, its absolute value will be multiplied by the number of processors in the machine to get the total number of threads.  
  
 If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is zero, [ATLS_DEFAULT_THREADSPERPROC](../vs140/atls_default_threadsperproc.md) will be multiplied by the number of processors in the machine to get the total number of threads.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Example  
 See [IThreadPoolConfig::GetSize](../vs140/ithreadpoolconfig--getsize.md).  
  
##  \<a name="ithreadpoolconfig__settimeout">\</a>  IThreadPoolConfig::SetTimeout  
 Call this method to set the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The requested maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Example  
 See [IThreadPoolConfig::GetSize](../vs140/ithreadpoolconfig--getsize.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)