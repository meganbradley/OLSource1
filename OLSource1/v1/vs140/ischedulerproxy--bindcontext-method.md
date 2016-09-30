---
title: "ISchedulerProxy::BindContext Method"
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
  - "concrtrm/concurrency::ISchedulerProxy::BindContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BindContext method"
ms.assetid: 4404bda6-82af-4ed5-80ac-14f3ff3504f7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISchedulerProxy::BindContext Method
Associates an execution context with a thread proxy, if it is not already associated with one.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An interface to the execution context to associate with a thread proxy.  
  
## Remarks  
 Normally, the [IThreadProxy::SwitchTo](../vs140/ithreadproxy--switchto-method.md) method will bind a thread proxy to an execution context on demand. There are, however, circumstances where it is necessary to bind a context in advance to ensure that the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method switches to an already bound context. This is the case on a UMS scheduling context as it cannot call methods that allocate memory, and binding a thread proxy may involve memory allocation if a thread proxy is not readily available in the free pool of the thread proxy factory.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is thrown if the parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> has the value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISchedulerProxy Structure](../vs140/ischedulerproxy-structure.md)   
 [ISchedulerProxy::UnbindContext Method](../vs140/ischedulerproxy--unbindcontext-method.md)