---
title: "IResourceManager::RegisterScheduler Method"
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
  - "concrtrm/concurrency::IResourceManager::RegisterScheduler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterScheduler method"
ms.assetid: c7010591-4513-4cb9-96cf-606ac1af77a3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IResourceManager::RegisterScheduler Method
Registers a scheduler with the Resource Manager. Once the scheduler is registered, it should communicate with the Resource Manager using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface that is returned.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface to the scheduler to be registered.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The version of communication interface the scheduler is using to communicate with the Resource Manager. Using a version allows the Resource Manager to evolve the communication interface while allowing schedulers to obtain access to older features. Schedulers that wish to use Resource Manager features present in Visual Studio 2010 should use the version <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface the Resource Manager has associated with your scheduler. Your scheduler should use this interface to communicate with Resource Manager from this point on.  
  
## Remarks  
 Use this method to initiate communication with the Resource Manager. The method associates the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface for your scheduler with an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface and hands it back to you. You can use the returned interface to request execution resources for use by your scheduler, or to subscribe threads with the Resource Manager. The Resource Manager will use policy elements from the scheduler policy returned by the [IScheduler::GetPolicy](../vs140/ischeduler--getpolicy-method.md) method to determine what type of threads the scheduler will need to execute work. If your <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> policy key has the value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and the value is read back out of the policy as the value <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> interface passed to the method must be an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interface.  
  
 The method throws an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> exception if the parameter <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> has the value <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or if the parameter <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not a valid version for the communication interface.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IResourceManager Structure](../vs140/iresourcemanager-structure.md)   
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [ISchedulerProxy Structure](../vs140/ischedulerproxy-structure.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)