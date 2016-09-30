---
title: "unbounded_buffer Class"
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
  - "agents/concurrency::unbounded_buffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unbounded_buffer class"
ms.assetid: 6b1a939a-1819-4385-b1d8-708f83d4ec47
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unbounded_buffer Class
An             <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> messaging block is a multi-target, multi-source, ordered             <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> capable of storing an unbounded number of messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The payload type of the messages stored and propagated by the buffer.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[unbounded_buffer::unbounded_buffer Constructor](#unbounded_buffer__unbounded_buffer_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block.|  
|[unbounded_buffer::~unbounded_buffer Destructor](#unbounded_buffer___dtorunbounded_buffer_destructor)|Destroys the                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> messaging block.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[unbounded_buffer::dequeue Method](#unbounded_buffer__dequeue_method)|Removes an item from the                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> messaging block.|  
|[unbounded_buffer::enqueue Method](#unbounded_buffer__enqueue_method)|Adds an item to the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> messaging block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[unbounded_buffer::accept_message Method](#unbounded_buffer__accept_message_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> messaging block, transferring ownership to the caller.|  
|[unbounded_buffer::consume_message Method](#unbounded_buffer__consume_message_method)|Consumes a message previously offered by the                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> messaging block and reserved by the target, transferring ownership to the caller.|  
|[unbounded_buffer::link_target_notification Method](#unbounded_buffer__link_target_notification_method)|A callback that notifies that a new target has been linked to this                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> messaging block.|  
|[unbounded_buffer::process_input_messages Method](#unbounded_buffer__process_input_messages_method)|Places the                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> in this                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> messaging block and tries to offer it to all of the linked targets.|  
|[unbounded_buffer::propagate_message Method](#unbounded_buffer__propagate_message_method)|Asynchronously passes a message from an                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method, when called by a source block.|  
|[unbounded_buffer::propagate_output_messages Method](#unbounded_buffer__propagate_output_messages_method)|Places the                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> in this                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> messaging block and tries to offer it to all of the linked targets. (Overrides                                         [source_block::propagate_output_messages](../vs140/source_block-class.md#source_block__propagate_output_messages_method).)|  
|[unbounded_buffer::release_message Method](#unbounded_buffer__release_message_method)|Releases a previous message reservation. (Overrides                                         [source_block::release_message](../vs140/source_block-class.md#source_block__release_message_method).)|  
|[unbounded_buffer::reserve_message Method](#unbounded_buffer__reserve_message_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> messaging block. (Overrides                                         [source_block::reserve_message](../vs140/source_block-class.md#source_block__reserve_message_method).)|  
|[unbounded_buffer::resume_propagation Method](#unbounded_buffer__resume_propagation_method)|Resumes propagation after a reservation has been released. (Overrides                                         [source_block::resume_propagation](../vs140/source_block-class.md#source_block__resume_propagation_method).)|  
|[unbounded_buffer::send_message Method](#unbounded_buffer__send_message_method)|Synchronously passes a message from an                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method, when called by a source block.|  
|[unbounded_buffer::supports_anonymous_source Method](#unbounded_buffer__supports_anonymous_source_method)|Overrides the                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method to indicate that this block can accept messages offered to it by a source that is not linked. (Overrides                                         [ITarget::supports_anonymous_source](../vs140/itarget-class.md#itarget__supports_anonymous_source_method).)|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 [ITarget](../vs140/itarget-class.md)  
  
 [source_block](../vs140/source_block-class.md)  
  
 [propagator_block](../vs140/propagator_block-class.md)  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="unbounded_buffer__accept_message_method">\</a>  unbounded_buffer::accept_message Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> messaging block, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
##  \<a name="unbounded_buffer__consume_message_method">\</a>  unbounded_buffer::consume_message Method  
 Consumes a message previously offered by the                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> messaging block and reserved by the target, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object being consumed.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 Similar to                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, but is always preceded by a call to                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
##  \<a name="unbounded_buffer__dequeue_method">\</a>  unbounded_buffer::dequeue Method  
 Removes an item from the                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The payload of the message removed from the                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="unbounded_buffer__enqueue_method">\</a>  unbounded_buffer::enqueue Method  
 Adds an item to the                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The item to add.  
  
### Return Value  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> if the item was accepted,                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="unbounded_buffer__link_target_notification_method">\</a>  unbounded_buffer::link_target_notification Method  
 A callback that notifies that a new target has been linked to this                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A pointer to the newly linked target.  
  
##  \<a name="unbounded_buffer__propagate_message_method">\</a>  unbounded_buffer::propagate_message Method  
 Asynchronously passes a message from an                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="unbounded_buffer__propagate_output_messages_method">\</a>  unbounded_buffer::propagate_output_messages Method  
 Places the                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> in this                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> messaging block and tries to offer it to all of the linked targets.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 If another message is already ahead of this one in the                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, propagation to linked targets will not occur until any earlier messages have been accepted or consumed. The first linked target to successfully                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> the message takes ownership, and no other target can then get the message.  
  
##  \<a name="unbounded_buffer__process_input_messages_method">\</a>  unbounded_buffer::process_input_messages Method  
 Places the                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> in this                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> messaging block and tries to offer it to all of the linked targets.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
##  \<a name="unbounded_buffer__release_message_method">\</a>  unbounded_buffer::release_message Method  
 Releases a previous message reservation.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object being released.  
  
##  \<a name="unbounded_buffer__reserve_message_method">\</a>  unbounded_buffer::reserve_message Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object being reserved.  
  
### Return Value  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 After                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is called, if it returns                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, either                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> must be called to either take or release ownership of the message.  
  
##  \<a name="unbounded_buffer__resume_propagation_method">\</a>  unbounded_buffer::resume_propagation Method  
 Resumes propagation after a reservation has been released.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="unbounded_buffer__send_message_method">\</a>  unbounded_buffer::send_message Method  
 Synchronously passes a message from an                 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="unbounded_buffer__supports_anonymous_source_method">\</a>  unbounded_buffer::supports_anonymous_source Method  
 Overrides the                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> method to indicate that this block can accept messages offered to it by a source that is not linked.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> because the block does not postpone offered messages.  
  
##  \<a name="unbounded_buffer__unbounded_buffer_constructor">\</a>  unbounded_buffer::unbounded_buffer Constructor  
 Constructs an                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> parameters.  
  
 The type                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is a functor with signature                         <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> which is invoked by this                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
##  \<a name="unbounded_buffer___dtorunbounded_buffer_destructor">\</a>  unbounded_buffer::~unbounded_buffer Destructor  
 Destroys the                 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)   
 [single_assignment Class](../vs140/single_assignment-class.md)