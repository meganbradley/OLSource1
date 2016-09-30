---
title: "invalid_multiple_scheduling Class"
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
  - "concrt/concurrency::invalid_multiple_scheduling"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_multiple_scheduling class"
ms.assetid: e9a47cb7-a778-4df7-92b0-3752119fd4c7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_multiple_scheduling Class
This class describes an exception thrown when a             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is scheduled multiple times using the             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method of a             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object without an intervening call to either the             <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or             <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> methods.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[invalid_multiple_scheduling::invalid_multiple_scheduling Constructor](#invalid_multiple_scheduling__invalid_multiple_scheduling_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="invalid_multiple_scheduling__invalid_multiple_scheduling_constructor">\</a>  invalid_multiple_scheduling::invalid_multiple_scheduling Constructor  
 Constructs an                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task_handle Class](../vs140/task_handle-class.md)   
 [task_group Class](../vs140/task_group-class.md)   
 [task_group::run Method](../vs140/task_group-class.md#task_group__run_method)   
 [task_group::wait Method](../vs140/task_group-class.md#task_group__wait_method)   
 [task_group::run_and_wait Method](../vs140/task_group-class.md#task_group__run_and_wait_method)   
 [structured_task_group Class](../vs140/structured_task_group-class.md)   
 [structured_task_group::run Method](../vs140/structured_task_group-class.md#structured_task_group__run_method)   
 [structured_task_group::wait Method](../vs140/structured_task_group-class.md#structured_task_group__wait_method)   
 [structured_task_group::run_and_wait Method](../vs140/structured_task_group-class.md#structured_task_group__run_and_wait_method)