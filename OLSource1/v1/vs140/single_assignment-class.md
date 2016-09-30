---
title: "single_assignment Class"
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
  - "agents/concurrency::single_assignment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "single_assignment class"
ms.assetid: ccc34728-8de9-4e07-b83d-a36a58d9d2b9
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment Class
A             <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> messaging block is a multi-target, multi-source, ordered             <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> capable of storing a single, write-once             <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The payload type of the message stored and propagated by the buffer.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[single_assignment::single_assignment Constructor](#single_assignment__single_assignment_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> messaging block.|  
|[single_assignment::~single_assignment Destructor](#single_assignment___dtorsingle_assignment_destructor)|Destroys the                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[single_assignment::has_value Method](#single_assignment__has_value_method)|Checks whether this                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> messaging block has been initialized with a value yet.|  
|[single_assignment::value Method](#single_assignment__value_method)|Gets a reference to the current payload of the message being stored in the                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> messaging block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[single_assignment::accept_message Method](#single_assignment__accept_message_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> messaging block, returning a copy of the message to the caller.|  
|[single_assignment::consume_message Method](#single_assignment__consume_message_method)|Consumes a message previously offered by the                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and reserved by the target, returning a copy of the message to the caller.|  
|[single_assignment::link_target_notification Method](#single_assignment__link_target_notification_method)|A callback that notifies that a new target has been linked to this                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> messaging block.|  
|[single_assignment::propagate_message Method](#single_assignment__propagate_message_method)|Asynchronously passes a message from an                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method, when called by a source block.|  
|[single_assignment::propagate_to_any_targets Method](#single_assignment__propagate_to_any_targets_method)|Places the                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> in this                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> messaging block and offers it to all of the linked targets.|  
|[single_assignment::release_message Method](#single_assignment__release_message_method)|Releases a previous message reservation. (Overrides                                         [source_block::release_message](../vs140/source_block-class.md#source_block__release_message_method).)|  
|[single_assignment::reserve_message Method](#single_assignment__reserve_message_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> messaging block. (Overrides                                         [source_block::reserve_message](../vs140/source_block-class.md#source_block__reserve_message_method).)|  
|[single_assignment::resume_propagation Method](#single_assignment__resume_propagation_method)|Resumes propagation after a reservation has been released. (Overrides                                         [source_block::resume_propagation](../vs140/source_block-class.md#source_block__resume_propagation_method).)|  
|[single_assignment::send_message Method](#single_assignment__send_message_method)|Synchronously passes a message from an                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method, when called by a source block.|  
  
## Remarks  
 A                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> messaging block propagates out copies of its message to each target.  
  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 [ITarget](../vs140/itarget-class.md)  
  
 [source_block](../vs140/source_block-class.md)  
  
 [propagator_block](../vs140/propagator_block-class.md)  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="single_assignment__accept_message_method">\</a>  single_assignment::accept_message Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> messaging block, returning a copy of the message to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> messaging block returns copies of the message to its targets, rather than transferring ownership of the currently held message.  
  
##  \<a name="single_assignment__consume_message_method">\</a>  single_assignment::consume_message Method  
 Consumes a message previously offered by the                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and reserved by the target, returning a copy of the message to the caller.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object being consumed.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 Similar to                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, but is always preceded by a call to                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
##  \<a name="single_assignment__has_value_method">\</a>  single_assignment::has_value Method  
 Checks whether this                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> messaging block has been initialized with a value yet.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> if the block has received a value,                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="single_assignment__link_target_notification_method">\</a>  single_assignment::link_target_notification Method  
 A callback that notifies that a new target has been linked to this                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A pointer to the newly linked target.  
  
##  \<a name="single_assignment__propagate_message_method">\</a>  single_assignment::propagate_message Method  
 Asynchronously passes a message from an                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="single_assignment__propagate_to_any_targets_method">\</a>  single_assignment::propagate_to_any_targets Method  
 Places the                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> in this                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> messaging block and offers it to all of the linked targets.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to a                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> that this                                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> messaging block has taken ownership of.  
  
##  \<a name="single_assignment__release_message_method">\</a>  single_assignment::release_message Method  
 Releases a previous message reservation.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object being released.  
  
##  \<a name="single_assignment__reserve_message_method">\</a>  single_assignment::reserve_message Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object being reserved.  
  
### Return Value  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 After                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is called, if it returns                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, either                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> must be called to either take or release ownership of the message.  
  
##  \<a name="single_assignment__resume_propagation_method">\</a>  single_assignment::resume_propagation Method  
 Resumes propagation after a reservation has been released.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="single_assignment__send_message_method">\</a>  single_assignment::send_message Method  
 Synchronously passes a message from an                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="single_assignment__single_assignment_constructor">\</a>  single_assignment::single_assignment Constructor  
 Constructs a                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> parameters.  
  
 The type                         <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is a functor with signature                         <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> which is invoked by this                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
##  \<a name="single_assignment___dtorsingle_assignment_destructor">\</a>  single_assignment::~single_assignment Destructor  
 Destroys the                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="single_assignment__value_method">\</a>  single_assignment::value Method  
 Gets a reference to the current payload of the message being stored in the                 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The payload of the stored message.  
  
### Remarks  
 This method will wait until a message arrives if no message is currently stored in the                         <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> messaging block.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)   
 [unbounded_buffer Class](../vs140/unbounded_buffer-class.md)