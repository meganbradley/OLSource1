---
title: "accelerator_view Class"
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
  - "amprt/Concurrency::accelerator_view"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accelerator_view class"
ms.assetid: 9f298c21-bf62-46e0-88b8-01c5c78ef144
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator_view Class
Represents a virtual device abstraction on a C++ AMP data-parallel accelerator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator_view::accelerator_view Constructor](../vs140/accelerator_view--accelerator_view-constructor.md)|Initializes a new instance of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.|  
|[accelerator_view::~accelerator_view Destructor](../vs140/accelerator_view--~accelerator_view-destructor.md)|Destroys the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator_view::create_marker Method](../vs140/accelerator_view--create_marker-method.md)|Returns a future to track the completion of all commands submitted so far to this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
|[accelerator_view::flush Method](../vs140/accelerator_view--flush-method.md)|Submits all pending commands queued to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to the accelerator for execution.|  
|[accelerator_view::get_accelerator Method](../vs140/accelerator_view--get_accelerator-method.md)|Returns the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
|[Accelerator_view::get_is_auto_selection Method](../vs140/accelerator_view--get_is_auto_selection-method.md)|Returns a Boolean value that indicates whether the runtime will automatically select an appropriate accelerator when the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is passed to a [parallel_for_each](../vs140/parallel_for_each-function--c---amp-.md).|  
|[accelerator_view::get_is_debug Method](../vs140/accelerator_view--get_is_debug-method.md)|Returns a Boolean value that indicates whether the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object has the DEBUG layer enabled for extensive error reporting.|  
|[accelerator_view::get_queuing_mode Method](../vs140/accelerator_view--get_queuing_mode-method.md)|Returns the queuing mode for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|[accelerator_view::get_version Method](../vs140/accelerator_view--get_version-method.md)|Returns the version of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[accelerator_view::wait Method](../vs140/accelerator_view--wait-method.md)|Waits for all commands submitted to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object to finish.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator_view::operator!= Operator](../vs140/accelerator_view--operator!=-operator.md)|Compares this <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object with another and returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if they are the same; otherwise, returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|[accelerator_view::operator= Operator](../vs140/accelerator_view--operator=-operator.md)|Copies the contents of the specified <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object into this one.|  
|[accelerator_view::operator== Operator](../vs140/accelerator_view--operator==-operator.md)|Compares this <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object with another and returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if they are the same; otherwise, returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator_view::accelerator Data Member](../vs140/accelerator_view--accelerator-data-member.md)|Gets the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object for the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[Accelerator_view::is_auto_selection](../vs140/accelerator_view--is_auto_selection-data-member.md)|Gets a Boolean value that indicates whether the runtime will automatically select an appropriate accelerator when the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object is passed to a [parallel_for_each](../vs140/parallel_for_each-function--c---amp-.md).|  
|[accelerator_view::is_debug Data Member](../vs140/accelerator_view--is_debug-data-member.md)|Gets a Boolean value that indicates whether the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object has the DEBUG layer enabled for extensive error reporting.|  
|[accelerator_view::queuing_mode Data Member](../vs140/accelerator_view--queuing_mode-data-member.md)|Gets the queuing mode for the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
|[accelerator_view::version Data Member](../vs140/accelerator_view--version-data-member.md)|Gets the version of the accelerator.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
## Remarks  
 An <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object represents a logical, isolated view of an accelerator. A single physical compute device can have many logical, isolated <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> objects. Each accelerator has a default <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object. Additional <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects can be created.  
  
 Physical devices can be shared among many client threads. Client threads can cooperatively use the same <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object of an accelerator, or each client can communicate with a compute device via an independent <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object for isolation from other client threads.  
  
 An <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object can have one of two [queuing_mode Enumeration](../vs140/queuing_mode-enumeration.md) states. If the queuing mode is <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, commands like <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> are sent to the corresponding accelerator device as soon as they return to the caller. If the queuing mode is <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, such commands are queued up on a command queue that corresponds to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object. Commands are not actually sent to the device until <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is called.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)