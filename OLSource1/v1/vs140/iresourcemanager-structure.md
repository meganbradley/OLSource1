---
title: "IResourceManager Structure"
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
  - "concrtrm/concurrency::IResourceManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IResourceManager structure"
ms.assetid: 3dd5ec2c-fe53-4121-ae77-1bc1d1167ff4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IResourceManager Structure
An interface to the Concurrency Runtime's Resource Manager. This is the interface by which schedulers communicate with the Resource Manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[IResourceManager::OSVersion Enumeration](#iresourcemanager__osversion_enumeration)|An enumerated type that represents the operating system version.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IResourceManager::CreateNodeTopology Method](#iresourcemanager__createnodetopology_method)|Present only in debug builds of the runtime, this method is a test hook designed to facilitate testing of the Resource Manager on varying hardware topologies, without requiring actual hardware matching the configuration. With retail builds of the runtime, this method will return without performing any action.|  
|[IResourceManager::GetAvailableNodeCount Method](#iresourcemanager__getavailablenodecount_method)|Returns the number of nodes available to the Resource Manager.|  
|[IResourceManager::GetFirstNode Method](#iresourcemanager__getfirstnode_method)|Returns the first node in enumeration order as defined by the Resource Manager.|  
|[IResourceManager::Reference Method](#iresourcemanager__reference_method)|Increments the reference count on the Resource Manager instance.|  
|[IResourceManager::RegisterScheduler Method](#iresourcemanager__registerscheduler_method)|Registers a scheduler with the Resource Manager. Once the scheduler is registered, it should communicate with the Resource Manager using the                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface that is returned.|  
|[IResourceManager::Release Method](#iresourcemanager__release_method)|Decrements the reference count on the Resource Manager instance. The Resource Manager is destroyed when its reference count goes to                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
  
## Remarks  
 Use the                 [CreateResourceManager](concurrency_namespace_Functions) function to obtain an interface to the singleton Resource Manager instance. The method increments a reference count on the Resource Manager, and you should invoke the                 [IResourceManager::Release](#iresourcemanager__release_method) method to release the reference when you are done with Resource Manager. Typically, each scheduler you create will invoke this method during creation, and release the reference to the Resource Manager after it shuts down.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="iresourcemanager__createnodetopology_method">\</a>  IResourceManager::CreateNodeTopology Method  
 Present only in debug builds of the runtime, this method is a test hook designed to facilitate testing of the Resource Manager on varying hardware topologies, without requiring actual hardware matching the configuration. With retail builds of the runtime, this method will return without performing any action.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The number of processor nodes being simulated.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An array that specifies the number of cores on each node.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A matrix specifying the node distance between any two nodes. This parameter can have the value                                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 An array that specifies the processor group each node belongs to.  
  
### Remarks  
 [invalid_argument](../vs140/invalid_argument-class.md) is thrown if the parameter                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> has the value                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> was passed in, or if the parameter                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> has the value                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 [invalid_operation](../vs140/invalid_operation-class.md) is thrown if this method is called while other schedulers exist in the process.  
  
##  \<a name="iresourcemanager__getavailablenodecount_method">\</a>  IResourceManager::GetAvailableNodeCount Method  
 Returns the number of nodes available to the Resource Manager.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The number of nodes available to the Resource Manager.  
  
##  \<a name="iresourcemanager__getfirstnode_method">\</a>  IResourceManager::GetFirstNode Method  
 Returns the first node in enumeration order as defined by the Resource Manager.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The first node in enumeration order as defined by the Resource Manager.  
  
##  \<a name="iresourcemanager__osversion_enumeration">\</a>  IResourceManager::OSVersion Enumeration  
 An enumerated type that represents the operating system version.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="iresourcemanager__reference_method">\</a>  IResourceManager::Reference Method  
 Increments the reference count on the Resource Manager instance.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The resulting reference count.  
  
##  \<a name="iresourcemanager__registerscheduler_method">\</a>  IResourceManager::RegisterScheduler Method  
 Registers a scheduler with the Resource Manager. Once the scheduler is registered, it should communicate with the Resource Manager using the                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> interface that is returned.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An                                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> interface to the scheduler to be registered.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The version of communication interface the scheduler is using to communicate with the Resource Manager. Using a version allows the Resource Manager to evolve the communication interface while allowing schedulers to obtain access to older features. Schedulers that wish to use Resource Manager features present in Visual Studio 2010 should use the version                                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
### Return Value  
 The                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> interface the Resource Manager has associated with your scheduler. Your scheduler should use this interface to communicate with Resource Manager from this point on.  
  
### Remarks  
 Use this method to initiate communication with the Resource Manager. The method associates the                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> interface for your scheduler with an                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> interface and hands it back to you. You can use the returned interface to request execution resources for use by your scheduler, or to subscribe threads with the Resource Manager. The Resource Manager will use policy elements from the scheduler policy returned by the                         [IScheduler::GetPolicy](../vs140/ischeduler-structure.md#ischeduler__getpolicy_method) method to determine what type of threads the scheduler will need to execute work. If your                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> policy key has the value                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the value is read back out of the policy as the value                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> interface passed to the method must be an                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> interface.  
  
 The method throws an                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> exception if the parameter                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> has the value                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or if the parameter                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is not a valid version for the communication interface.  
  
##  \<a name="iresourcemanager__release_method">\</a>  IResourceManager::Release Method  
 Decrements the reference count on the Resource Manager instance. The Resource Manager is destroyed when its reference count goes to                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The resulting reference count.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [ISchedulerProxy Structure](../vs140/ischedulerproxy-structure.md)   
 [IScheduler Structure](../vs140/ischeduler-structure.md)