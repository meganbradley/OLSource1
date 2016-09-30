---
title: "ordered_message_processor Class"
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
  - "agents/concurrency::ordered_message_processor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ordered_message_processor class"
ms.assetid: 787adfb7-7f79-4a70-864a-80e3b64088cd
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ordered_message_processor Class
An             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a             <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that allows message blocks to process messages in the order they were received.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The payload type of messages handled by the processor.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|A type alias for                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[ordered_message_processor::ordered_message_processor Constructor](#ordered_message_processor__ordered_message_processor_constructor)|Constructs an                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[ordered_message_processor::~ordered_message_processor Destructor](#ordered_message_processor___dtorordered_message_processor_destructor)|Destroys the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ordered_message_processor::async_send Method](#ordered_message_processor__async_send_method)|Asynchronously queues up messages and starts a processing task, if this has not been done already. (Overrides                                         [message_processor::async_send](../vs140/message_processor-class.md#message_processor__async_send_method).)|  
|[ordered_message_processor::initialize Method](#ordered_message_processor__initialize_method)|Initializes the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object with the appropriate callback function, scheduler and schedule group.|  
|[ordered_message_processor::initialize_batched_processing Method](#ordered_message_processor__initialize_batched_processing_method)|Initialize batched message processing|  
|[ordered_message_processor::sync_send Method](#ordered_message_processor__sync_send_method)|Synchronously queues up messages and starts a processing task, if this has not been done already. (Overrides                                         [message_processor::sync_send](../vs140/message_processor-class.md#message_processor__sync_send_method).)|  
|[ordered_message_processor::wait Method](#ordered_message_processor__wait_method)|A processor-specific spin wait used in destructors of message blocks to make sure that all asynchronous processing tasks have time to finish before destroying the block. (Overrides                                         [message_processor::wait](../vs140/message_processor-class.md#message_processor__wait_method).)|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ordered_message_processor::process_incoming_message Method](#ordered_message_processor__process_incoming_message_method)|The processing function that is called asynchronously. It dequeues messages and begins processing them. (Overrides                                         [message_processor::process_incoming_message](../vs140/message_processor-class.md#message_processor__process_incoming_message_method).)|  
  
## Inheritance Hierarchy  
 [message_processor](../vs140/message_processor-class.md)  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="ordered_message_processor__async_send_method">\</a>  ordered_message_processor::async_send Method  
 Asynchronously queues up messages and starts a processing task, if this has not been done already.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A pointer to a message.  
  
##  \<a name="ordered_message_processor__initialize_method">\</a>  ordered_message_processor::initialize Method  
 Initializes the                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object with the appropriate callback function, scheduler and schedule group.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A pointer to the scheduler to be used for scheduling light-weight tasks.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A pointer to the schedule group to be used for scheduling light-weight tasks.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The handler functor invoked during callback.  
  
##  \<a name="ordered_message_processor__initialize_batched_processing_method">\</a>  ordered_message_processor::initialize_batched_processing Method  
 Initialize batched message processing  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The processor functor invoked during callback.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The propagator functor invoked during callback.  
  
##  \<a name="ordered_message_processor__ordered_message_processor_constructor">\</a>  ordered_message_processor::ordered_message_processor Constructor  
 Constructs an                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> will not schedule asynchronous or synchronous handlers until the                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function is called.  
  
##  \<a name="ordered_message_processor___dtorordered_message_processor_destructor">\</a>  ordered_message_processor::~ordered_message_processor Destructor  
 Destroys the                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Waits for all outstanding asynchronous operations before destroying the processor.  
  
##  \<a name="ordered_message_processor__process_incoming_message_method">\</a>  ordered_message_processor::process_incoming_message Method  
 The processing function that is called asynchronously. It dequeues messages and begins processing them.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="ordered_message_processor__sync_send_method">\</a>  ordered_message_processor::sync_send Method  
 Synchronously queues up messages and starts a processing task, if this has not been done already.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer to a message.  
  
##  \<a name="ordered_message_processor__wait_method">\</a>  ordered_message_processor::wait Method  
 A processor-specific spin wait used in destructors of message blocks to make sure that all asynchronous processing tasks have time to finish before destroying the block.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)