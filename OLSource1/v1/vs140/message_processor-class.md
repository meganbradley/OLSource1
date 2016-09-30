---
title: "message_processor Class"
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
  - "agents/concurrency::message_processor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message_processor class"
ms.assetid: 23afb052-daa7-44ed-bf24-d2513db748da
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message_processor Class
The             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class is the abstract base class for processing of             <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects. There is no guarantee on the ordering of the messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The data type of the payload within messages handled by this                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|A type alias for                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[message_processor::async_send Method](#message_processor__async_send_method)|When overridden in a derived class, places messages into the block asynchronously.|  
|[message_processor::sync_send Method](#message_processor__sync_send_method)|When overridden in a derived class, places messages into the block synchronously.|  
|[message_processor::wait Method](#message_processor__wait_method)|When overridden in a derived class, waits for all asynchronous operations to complete.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[message_processor::process_incoming_message Method](#message_processor__process_incoming_message_method)|When overridden in a derived class, performs the forward processing of messages into the block. Called once every time a new message is added and the queue is found to be empty.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="message_processor__async_send_method">\</a>  message_processor::async_send Method  
 When overridden in a derived class, places messages into the block asynchronously.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object to send asynchronously.  
  
### Remarks  
 Processor implementations should override this method.  
  
##  \<a name="message_processor__process_incoming_message_method">\</a>  message_processor::process_incoming_message Method  
 When overridden in a derived class, performs the forward processing of messages into the block. Called once every time a new message is added and the queue is found to be empty.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Message block implementations should override this method.  
  
##  \<a name="message_processor__sync_send_method">\</a>  message_processor::sync_send Method  
 When overridden in a derived class, places messages into the block synchronously.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object to send synchronously.  
  
### Remarks  
 Processor implementations should override this method.  
  
##  \<a name="message_processor__wait_method">\</a>  message_processor::wait Method  
 When overridden in a derived class, waits for all asynchronous operations to complete.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Processor implementations should override this method.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [ordered_message_processor Class](../vs140/ordered_message_processor-class.md)