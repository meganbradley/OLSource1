---
title: "overwrite_buffer Class"
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
  - "agents/concurrency::overwrite_buffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overwrite_buffer class"
ms.assetid: 5cc428fe-3697-419c-9fb2-78f6181c9293
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# overwrite_buffer Class
An             <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> messaging block is a multi-target, multi-source, ordered             <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> capable of storing a single message at a time. New messages overwrite previously held ones.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The payload type of the messages stored and propagated by the buffer.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[overwrite_buffer::overwrite_buffer Constructor](#overwrite_buffer__overwrite_buffer_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> messaging block.|  
|[overwrite_buffer::~overwrite_buffer Destructor](#overwrite_buffer___dtoroverwrite_buffer_destructor)|Destroys the                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[overwrite_buffer::has_value Method](#overwrite_buffer__has_value_method)|Checks whether this                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> messaging block has a value yet.|  
|[overwrite_buffer::value Method](#overwrite_buffer__value_method)|Gets a reference to the current payload of the message being stored in the                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> messaging block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[overwrite_buffer::accept_message Method](#overwrite_buffer__accept_message_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> messaging block, returning a copy of the message to the caller.|  
|[overwrite_buffer::consume_message Method](#overwrite_buffer__consume_message_method)|Consumes a message previously offered by the                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> messaging block and reserved by the target, returning a copy of the message to the caller.|  
|[overwrite_buffer::link_target_notification Method](#overwrite_buffer__link_target_notification_method)|A callback that notifies that a new target has been linked to this                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> messaging block.|  
|[overwrite_buffer::propagate_message Method](#overwrite_buffer__propagate_message_method)|Asynchronously passes a message from an                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method, when called by a source block.|  
|[overwrite_buffer::propagate_to_any_targets Method](#overwrite_buffer__propagate_to_any_targets_method)|Places the                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> in this                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> messaging block and offers it to all of the linked targets.|  
|[overwrite_buffer::release_message Method](#overwrite_buffer__release_message_method)|Releases a previous message reservation. (Overrides                                         [source_block::release_message](../vs140/source_block-class.md#source_block__release_message_method).)|  
|[overwrite_buffer::reserve_message Method](#overwrite_buffer__reserve_message_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> messaging block. (Overrides                                         [source_block::reserve_message](../vs140/source_block-class.md#source_block__reserve_message_method).)|  
|[overwrite_buffer::resume_propagation Method](#overwrite_buffer__resume_propagation_method)|Resumes propagation after a reservation has been released. (Overrides                                         [source_block::resume_propagation](../vs140/source_block-class.md#source_block__resume_propagation_method).)|  
|[overwrite_buffer::send_message Method](#overwrite_buffer__send_message_method)|Synchronously passes a message from an                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method, when called by a source block.|  
|[overwrite_buffer::supports_anonymous_source Method](#overwrite_buffer__supports_anonymous_source_method)|Overrides the                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method to indicate that this block can accept messages offered to it by a source that is not linked. (Overrides                                         [ITarget::supports_anonymous_source](../vs140/itarget-class.md#itarget__supports_anonymous_source_method).)|  
  
## Remarks  
 An                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> messaging block propagates out copies of its stored message to each of its targets.  
  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 [ITarget](../vs140/itarget-class.md)  
  
 [source_block](../vs140/source_block-class.md)  
  
 [propagator_block](../vs140/propagator_block-class.md)  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="overwrite_buffer__accept_message_method">\</a>  overwrite_buffer::accept_message Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> messaging block, returning a copy of the message to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> messaging block returns copies of the message to its targets, rather than transferring ownership of the currently held message.  
  
##  \<a name="overwrite_buffer__consume_message_method">\</a>  overwrite_buffer::consume_message Method  
 Consumes a message previously offered by the                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> messaging block and reserved by the target, returning a copy of the message to the caller.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object being consumed.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 Similar to                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, but is always preceded by a call to                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
##  \<a name="overwrite_buffer__has_value_method">\</a>  overwrite_buffer::has_value Method  
 Checks whether this                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> messaging block has a value yet.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> if the block has received a value,                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="overwrite_buffer__link_target_notification_method">\</a>  overwrite_buffer::link_target_notification Method  
 A callback that notifies that a new target has been linked to this                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A pointer to the newly linked target.  
  
##  \<a name="overwrite_buffer___dtoroverwrite_buffer_destructor">\</a>  overwrite_buffer::~overwrite_buffer Destructor  
 Destroys the                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="overwrite_buffer__overwrite_buffer_constructor">\</a>  overwrite_buffer::overwrite_buffer Constructor  
 Constructs an                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> parameters.  
  
 The type                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is a functor with signature                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> which is invoked by this                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
##  \<a name="overwrite_buffer__propagate_message_method">\</a>  overwrite_buffer::propagate_message Method  
 Asynchronously passes a message from an                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="overwrite_buffer__propagate_to_any_targets_method">\</a>  overwrite_buffer::propagate_to_any_targets Method  
 Places the                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> in this                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> messaging block and offers it to all of the linked targets.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to a                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object that this                                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> has taken ownership of.  
  
### Remarks  
 This method overwrites the current message in the                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> with the newly accepted message                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
##  \<a name="overwrite_buffer__send_message_method">\</a>  overwrite_buffer::send_message Method  
 Synchronously passes a message from an                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="overwrite_buffer__supports_anonymous_source_method">\</a>  overwrite_buffer::supports_anonymous_source Method  
 Overrides the                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> method to indicate that this block can accept messages offered to it by a source that is not linked.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> because the block does not postpone offered messages.  
  
##  \<a name="overwrite_buffer__release_message_method">\</a>  overwrite_buffer::release_message Method  
 Releases a previous message reservation.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object being released.  
  
##  \<a name="overwrite_buffer__reserve_message_method">\</a>  overwrite_buffer::reserve_message Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object being reserved.  
  
### Return Value  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 After                         <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> is called, if it returns                         <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, either                         <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> must be called to either take or release ownership of the message.  
  
##  \<a name="overwrite_buffer__resume_propagation_method">\</a>  overwrite_buffer::resume_propagation Method  
 Resumes propagation after a reservation has been released.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="overwrite_buffer__value_method">\</a>  overwrite_buffer::value Method  
 Gets a reference to the current payload of the message being stored in the                 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The payload of the currently stored message.  
  
### Remarks  
 The value stored in the                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> could change immediately after this method returns. This method will wait until a message arrives if no message is currently stored in the                         <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [unbounded_buffer Class](../vs140/unbounded_buffer-class.md)   
 [single_assignment Class](../vs140/single_assignment-class.md)