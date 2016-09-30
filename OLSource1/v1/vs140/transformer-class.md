---
title: "transformer Class"
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
  - "agents/concurrency::transformer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transformer class"
ms.assetid: eea71925-7043-4a92-bfd4-dbc0ece5d081
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# transformer Class
A             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> messaging block is a single-target, multi-source, ordered             <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> which can accept messages of one type and is capable of storing an unbounded number of messages of a different type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The payload type of the messages accepted by the buffer.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The payload type of the messages stored and propagated out by the buffer.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[transformer::transformer Constructor](#transformer__transformer_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> messaging block.|  
|[transformer::~transformer Destructor](#transformer___dtortransformer_destructor)|Destroys the                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> messaging block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[transformer::accept_message Method](#transformer__accept_message_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block, transferring ownership to the caller.|  
|[transformer::consume_message Method](#transformer__consume_message_method)|Consumes a message previously offered by the                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and reserved by the target, transferring ownership to the caller.|  
|[transformer::link_target_notification Method](#transformer__link_target_notification_method)|A callback that notifies that a new target has been linked to this                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> messaging block.|  
|[transformer::propagate_message Method](#transformer__propagate_message_method)|Asynchronously passes a message from an                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method, when called by a source block.|  
|[transformer::propagate_to_any_targets Method](#transformer__propagate_to_any_targets_method)|Executes the transformer function on the input messages.|  
|[transformer::release_message Method](#transformer__release_message_method)|Releases a previous message reservation. (Overrides                                         [source_block::release_message](../vs140/source_block-class.md#source_block__release_message_method).)|  
|[transformer::reserve_message Method](#transformer__reserve_message_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> messaging block. (Overrides                                         [source_block::reserve_message](../vs140/source_block-class.md#source_block__reserve_message_method).)|  
|[transformer::resume_propagation Method](#transformer__resume_propagation_method)|Resumes propagation after a reservation has been released. (Overrides                                         [source_block::resume_propagation](../vs140/source_block-class.md#source_block__resume_propagation_method).)|  
|[transformer::send_message Method](#transformer__send_message_method)|Synchronously passes a message from an                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method, when called by a source block.|  
|[transformer::supports_anonymous_source Method](#transformer__supports_anonymous_source_method)|Overrides the                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method to indicate that this block can accept messages offered to it by a source that is not linked. (Overrides                                         [ITarget::supports_anonymous_source](../vs140/itarget-class.md#itarget__supports_anonymous_source_method).)|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 [ITarget](../vs140/itarget-class.md)  
  
 [source_block](../vs140/source_block-class.md)  
  
 [propagator_block](../vs140/propagator_block-class.md)  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="transformer__accept_message_method">\</a>  transformer::accept_message Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> messaging block, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
##  \<a name="transformer__consume_message_method">\</a>  transformer::consume_message Method  
 Consumes a message previously offered by the                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and reserved by the target, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object being consumed.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 Similar to                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, but is always preceded by a call to                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
##  \<a name="transformer__link_target_notification_method">\</a>  transformer::link_target_notification Method  
 A callback that notifies that a new target has been linked to this                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="transformer__propagate_message_method">\</a>  transformer::propagate_message Method  
 Asynchronously passes a message from an                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="transformer__propagate_to_any_targets_method">\</a>  transformer::propagate_to_any_targets Method  
 Executes the transformer function on the input messages.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="transformer__release_message_method">\</a>  transformer::release_message Method  
 Releases a previous message reservation.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object being released.  
  
##  \<a name="transformer__reserve_message_method">\</a>  transformer::reserve_message Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object being reserved.  
  
### Return Value  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 After                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is called, if it returns                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, either                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> must be called to either take or release ownership of the message.  
  
##  \<a name="transformer__resume_propagation_method">\</a>  transformer::resume_propagation Method  
 Resumes propagation after a reservation has been released.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="transformer__send_message_method">\</a>  transformer::send_message Method  
 Synchronously passes a message from an                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="transformer__supports_anonymous_source_method">\</a>  transformer::supports_anonymous_source Method  
 Overrides the                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> method to indicate that this block can accept messages offered to it by a source that is not linked.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> because the block does not postpone offered messages.  
  
##  \<a name="transformer__transformer_constructor">\</a>  transformer::transformer Constructor  
 Constructs a                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A function that will be invoked for each accepted message.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A pointer to a target block to link with the transformer.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> parameters.  
  
 The type                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is a functor with signature                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> which is invoked by this                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> messaging block to process a message.  
  
 The type                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> is a functor with signature                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> which is invoked by this                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
##  \<a name="transformer___dtortransformer_destructor">\</a>  transformer::~transformer Destructor  
 Destroys the                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [call Class](../vs140/call-class.md)