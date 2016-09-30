---
title: "Scheduler::ResetDefaultSchedulerPolicy Method"
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
  - "concrt/concurrency::Scheduler::ResetDefaultSchedulerPolicy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ResetDefaultSchedulerPolicy method"
ms.assetid: 87598ef3-3f59-408c-a3e0-dfab6663210b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::ResetDefaultSchedulerPolicy Method
Resets the default scheduler policy to the runtime default. The next time a default scheduler is created, it will use the runtime default policy settings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This method can be called while a default scheduler exists within the process. It will not affect the policy of the existing default scheduler. However, if the default scheduler were to shutdown, and a new default were to be created at a later point, the new scheduler would use the runtime default policy settings.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Scheduler::SetDefaultSchedulerPolicy Method](../vs140/scheduler--setdefaultschedulerpolicy-method.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)