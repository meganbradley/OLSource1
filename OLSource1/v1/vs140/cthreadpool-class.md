---
title: "CThreadPool Class"
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
  - "ATL.CThreadPool"
  - "ATL::CThreadPool"
  - "CThreadPool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CThreadPool class"
ms.assetid: 06683718-01b9-413c-9481-2dc1734ec70f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CThreadPool Class
This class provides a pool of worker threads that process a queue of work items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Worker*  
 The class conforming to the [worker archetype](../vs140/worker-archetype.md) providing the code used to process work items queued on the thread pool.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The class providing the function used to create the threads in the pool.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CThreadPool::CThreadPool](../vs140/cthreadpool--cthreadpool.md)|The constructor for the thread pool.|  
|[CThreadPool::~CThreadPool](../vs140/cthreadpool--~cthreadpool.md)|The destructor for the thread pool.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CThreadPool::AddRef](../vs140/cthreadpool--addref.md)|Implementation of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|[CThreadPool::GetNumThreads](../vs140/cthreadpool--getnumthreads.md)|Call this method to get the number of threads in the pool.|  
|[CThreadPool::GetQueueHandle](../vs140/cthreadpool--getqueuehandle.md)|Call this method to get the handle of the IO completion port used to queue work items.|  
|[CThreadPool::GetSize](../vs140/cthreadpool--getsize.md)|Call this method to get the number of threads in the pool.|  
|[CThreadPool::GetTimeout](../vs140/cthreadpool--gettimeout.md)|Call this method to get the maximum time in milliseconds that the thread pool will wait for a thread to shut down.|  
|[CThreadPool::Initialize](../vs140/cthreadpool--initialize.md)|Call this method to initialize the thread pool.|  
|[CThreadPool::QueryInterface](../vs140/cthreadpool--queryinterface.md)|Implementation of **IUnknown::QueryInterface**.|  
|[CThreadPool::QueueRequest](../vs140/cthreadpool--queuerequest.md)|Call this method to queue a work item to be handled by a thread in the pool.|  
|[CThreadPool::Release](../vs140/cthreadpool--release.md)|Implementation of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|[CThreadPool::SetSize](../vs140/cthreadpool--setsize.md)|Call this method to set the number of threads in the pool.|  
|[CThreadPool::SetTimeout](../vs140/cthreadpool--settimeout.md)|Call this method to set the maximum time in milliseconds that the thread pool will wait for a thread to shut down.|  
|[CThreadPool::Shutdown](../vs140/cthreadpool--shutdown.md)|Call this method to shut down the thread pool.|  
  
## Remarks  
 Threads in the pool are created and destroyed when the pool is initialized, resized, or shut down. An instance of class *Worker* will be created on the stack of each worker thread in the pool. Each instance will live for the lifetime of the thread.  
  
 Immediately after creation of a thread, *Worker*:: <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will be called on the object associated with that thread. Immediately before destruction of a thread, *Worker*:: <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> will be called. Both methods must accept a **void\*** argument. The value of this argument is passed to the thread pool through the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter of [CThreadPool::Initialize](../vs140/cthreadpool--initialize.md).  
  
 When there are work items in the queue and worker threads available for work, a worker thread will pull an item off the queue and call the **Execute** method of the *Worker* object for that thread. Three items are then passed to the method: the item from the queue, the same <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> passed to *Worker*:: <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and *Worker*:: <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and a pointer to the [OVERLAPPED](http://msdn.microsoft.com/library/windows/desktop/ms684342) structure used for the IO completion port queue.  
  
 The *Worker* class declares the type of the items that will be queued on the thread pool by providing a typedef, *Worker*:: <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. This type must be capable of being cast to and from a **ULONG_PTR**.  
  
 An example of a *Worker* class is [CNonStatelessWorker Class](../vs140/cnonstatelessworker-class.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 [IThreadPoolConfig](../vs140/ithreadpoolconfig-interface.md)  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlutil.h  
  
##  \<a name="cthreadpool__addref">\</a>  CThreadPool::AddRef  
 Implementation of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Always returns 1.  
  
### Remarks  
 This class does not implement lifetime control using reference counting.  
  
##  \<a name="cthreadpool__cthreadpool">\</a>  CThreadPool::CThreadPool  
 The constructor for the thread pool.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the timeout value to [ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT](../vs140/atls_default_threadpoolshutdowntimeout.md).  
  
##  \<a name="cthreadpool___dtorcthreadpool">\</a>  CThreadPool::~CThreadPool  
 The destructor for the thread pool.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Calls [CThreadPool::Shutdown](../vs140/cthreadpool--shutdown.md).  
  
##  \<a name="cthreadpool__getnumthreads">\</a>  CThreadPool::GetNumThreads  
 Call this method to get the number of threads in the pool.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of threads in the pool.  
  
##  \<a name="cthreadpool__getqueuehandle">\</a>  CThreadPool::GetQueueHandle  
 Call this method to get the handle of the IO completion port used to queue work items.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns the queue handle or NULL if the thread pool has not been initialized.  
  
##  \<a name="cthreadpool__getsize">\</a>  CThreadPool::GetSize  
 Call this method to get the number of threads in the pool.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [out] Address of the variable that, on success, receives the number of threads in the pool.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cthreadpool__gettimeout">\</a>  CThreadPool::GetTimeout  
 Call this method to get the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 [out] Address of the variable that, on success, receives the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This timeout value is used by [CThreadPool::Shutdown](../vs140/cthreadpool--shutdown.md) if no other value is supplied to that method.  
  
##  \<a name="cthreadpool__initialize">\</a>  CThreadPool::Initialize  
 Call this method to initialize the thread pool.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The worker parameter to be passed to the worker thread object's <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>,                                 **Execute**, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> methods.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The requested number of threads in the pool.  
  
 If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is negative, its absolute value will be multiplied by the number of processors in the machine to get the total number of threads.  
  
 If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is zero, [ATLS_DEFAULT_THREADSPERPROC](../vs140/atls_default_threadsperproc.md) will be multiplied by the number of processors in the machine to get the total number of threads.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The stack size for each thread in the pool.  
  
 *hCompletion*  
 The handle of an object to associate with the completion port.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cthreadpool__queryinterface">\</a>  CThreadPool::QueryInterface  
 Implementation of **IUnknown::QueryInterface**.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 Objects of this class can be successfully queried for the **IUnknown** and [IThreadPoolConfig](../vs140/ithreadpoolconfig-interface.md) interfaces.  
  
##  \<a name="cthreadpool__queuerequest">\</a>  CThreadPool::QueueRequest  
 Call this method to queue a work item to be handled by a thread in the pool.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The request to be queued.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 This method adds a work item to the queue. The threads in the pool pick items off the queue in the order in which they are received.  
  
##  \<a name="cthreadpool__release">\</a>  CThreadPool::Release  
 Implementation of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Always returns 1.  
  
### Remarks  
 This class does not implement lifetime control using reference counting.  
  
##  \<a name="cthreadpool__setsize">\</a>  CThreadPool::SetSize  
 Call this method to set the number of threads in the pool.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The requested number of threads in the pool.  
  
 If <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is negative, its absolute value will be multiplied by the number of processors in the machine to get the total number of threads.  
  
 If <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is zero, [ATLS_DEFAULT_THREADSPERPROC](../vs140/atls_default_threadsperproc.md) will be multiplied by the number of processors in the machine to get the total number of threads.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 If the number of threads specified is less than the number of threads currently in the pool, the object puts a shutdown message on the queue to be picked up by a waiting thread. When a waiting thread pulls the message off the queue, it notifies the thread pool and exits the thread procedure. This process is repeated until the number of threads in the pool reaches the specified number or until no thread has exited within the period specified by [GetTimeout](../vs140/cthreadpool--gettimeout.md)/ [SetTimeout](../vs140/cthreadpool--settimeout.md). In this situation the method will return an HRESULT corresponding to **WAIT_TIMEOUT** and the pending shutdown message is canceled.  
  
##  \<a name="cthreadpool__settimeout">\</a>  CThreadPool::SetTimeout  
 Call this method to set the maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The requested maximum time in milliseconds that the thread pool will wait for a thread to shut down.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The timeout is initialized to [ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT](../vs140/atls_default_threadpoolshutdowntimeout.md) in the constructor.  
  
 Note that <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is the time that the pool will wait for a single thread to shut down. The maximum time that could be taken to remove multiple threads from the pool could be slightly less than <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> multiplied by the number of threads.  
  
##  \<a name="cthreadpool__shutdown">\</a>  CThreadPool::Shutdown  
 Call this method to shut down the thread pool.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The requested maximum time in milliseconds that the thread pool will wait for a thread to shut down. If 0 or no value is supplied, this method will use the timeout set by [CThreadPool::SetTimeout](../vs140/cthreadpool--settimeout.md).  
  
### Remarks  
 This method posts a shutdown request to all threads in the pool. If the timeout expires, this method will call [TerminateThread](http://msdn.microsoft.com/library/windows/desktop/ms686717) on any thread that did not exit. This method is called automatically from the destructor of the class.  
  
## See Also  
 [IThreadPoolConfig Interface](../vs140/ithreadpoolconfig-interface.md)   
 [DefaultThreadTraits](../vs140/defaultthreadtraits.md)   
 [ATL Classes](../vs140/atl-classes.md)