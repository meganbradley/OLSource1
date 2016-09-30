---
title: "ISchedulerProxy::Shutdown Method"
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
  - "concrtrm/concurrency::ISchedulerProxy::Shutdown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Shutdown method"
ms.assetid: 95eb2a24-8ff2-4d4a-b150-101b9110af01
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISchedulerProxy::Shutdown Method
Notifies the Resource Manager that the scheduler is shutting down. This will cause the Resource Manager to immediately reclaim all resources granted to the scheduler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 All <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interfaces the scheduler received as a result of subscribing an external thread using the methods <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must be returned to the Resource Manager using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> before a scheduler shuts itself down.  
  
 If your scheduler had any deactivated virtual processor roots, you must activate them using [IVirtualProcessorRoot::Activate](../vs140/ivirtualprocessorroot--activate-method.md), and have the thread proxies executing on them leave the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method of the execution contexts they are dispatching before you invoke <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on a scheduler proxy.  
  
 It is not necessary for the scheduler to individually return all of the virtual processor roots the Resource Manager granted to it via calls to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method because all virtual processors roots will be returned to the Resource Manager at shutdown.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISchedulerProxy Structure](../vs140/ischedulerproxy-structure.md)   
 [ISchedulerProxy::RequestInitialVirtualProcessors Method](../vs140/ischedulerproxy--requestinitialvirtualprocessors-method.md)   
 [ISchedulerProxy::SubscribeCurrentThread Method](../vs140/ischedulerproxy--subscribecurrentthread-method.md)   
 [IExecutionResource::Remove Method](../vs140/iexecutionresource--remove-method.md)