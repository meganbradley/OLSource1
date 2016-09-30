---
title: "call Class"
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
  - "agents/concurrency::call"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "call class"
ms.assetid: 1521970a-1e9c-4b0c-a681-d18e40976f49
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# call Class
A             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> messaging block is a multi-source, ordered             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that invokes a specified function when receiving a message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The payload type of the messages propagated to this block.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The signature of functions that this block can accept.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[call::call Constructor](#call__call_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> messaging block.|  
|[call::~call Destructor](#call___dtorcall_destructor)|Destroys the                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> messaging block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[call::process_input_messages Method](#call__process_input_messages_method)|Executes the call function on the input messages.|  
|[call::process_message Method](#call__process_message_method)|Processes a message that was accepted by this                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> messaging block.|  
|[call::propagate_message Method](#call__propagate_message_method)|Asynchronously passes a message from an                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method, when called by a source block.|  
|[call::send_message Method](#call__send_message_method)|Synchronously passes a message from an                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method, when called by a source block.|  
|[call::supports_anonymous_source Method](#call__supports_anonymous_source_method)|Overrides the                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method to indicate that this block can accept messages offered to it by a source that is not linked. (Overrides                                         [ITarget::supports_anonymous_source](../vs140/itarget-class.md#itarget__supports_anonymous_source_method).)|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ITarget](../vs140/itarget-class.md)  
  
 [target_block](../vs140/target_block-class.md)  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="call__call_constructor">\</a>  call::call Constructor  
 Constructs a                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A function that will be invoked for each accepted message.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameters.  
  
 The type                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is a functor with signature                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> which is invoked by this                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> messaging block to process a message.  
  
 The type                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is a functor with signature                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> which is invoked by this                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
##  \<a name="call___dtorcall_destructor">\</a>  call::~call Destructor  
 Destroys the                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="call__process_input_messages_method">\</a>  call::process_input_messages Method  
 Executes the call function on the input messages.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
##  \<a name="call__process_message_method">\</a>  call::process_message Method  
 Processes a message that was accepted by this                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A pointer to the message that is to be handled.  
  
##  \<a name="call__propagate_message_method">\</a>  call::propagate_message Method  
 Asynchronously passes a message from an                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="call__send_message_method">\</a>  call::send_message Method  
 Synchronously passes a message from an                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="call__supports_anonymous_source_method">\</a>  call::supports_anonymous_source Method  
 Overrides the                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> method to indicate that this block can accept messages offered to it by a source that is not linked.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> because the block does not postpone offered messages.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [transformer Class](../vs140/transformer-class.md)