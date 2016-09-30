---
title: "join Class"
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
  - "agents/concurrency::join"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "join class"
ms.assetid: d2217119-70a1-40b6-809f-c1c13a571c3f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# join Class
A             <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> messaging block is a single-target, multi-source, ordered             <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> which combines together messages of type             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> from each of its sources.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The payload type of the messages joined and propagated by the block.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The kind of                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> block this is, either                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[join::join Constructor](#join__join_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block.|  
|[join::~join Destructor](#join___dtorjoin_destructor)|Destroys the                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[join::accept_message Method](#join__accept_message_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> messaging block, transferring ownership to the caller.|  
|[join::consume_message Method](#join__consume_message_method)|Consumes a message previously offered by the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> messaging block and reserved by the target, transferring ownership to the caller.|  
|[join::link_target_notification Method](#join__link_target_notification_method)|A callback that notifies that a new target has been linked to this                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> messaging block.|  
|[join::propagate_message Method](#join__propagate_message_method)|Asynchronously passes a message from an                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> messaging block. It is invoked by the                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method, when called by a source block.|  
|[join::propagate_to_any_targets Method](#join__propagate_to_any_targets_method)|Constructs an output message containing an input message from each source when they have all propagated a message. Sends this output message out to each of its targets.|  
|[join::release_message Method](#join__release_message_method)|Releases a previous message reservation. (Overrides                                         [source_block::release_message](../vs140/source_block-class.md#source_block__release_message_method).)|  
|[join::reserve_message Method](#join__reserve_message_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> messaging block. (Overrides                                         [source_block::reserve_message](../vs140/source_block-class.md#source_block__reserve_message_method).)|  
|[join::resume_propagation Method](#join__resume_propagation_method)|Resumes propagation after a reservation has been released. (Overrides                                         [source_block::resume_propagation](../vs140/source_block-class.md#source_block__resume_propagation_method).)|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 [ITarget](../vs140/itarget-class.md)  
  
 [source_block](../vs140/source_block-class.md)  
  
 [propagator_block](../vs140/propagator_block-class.md)  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="join__accept_message_method">\</a>  join::accept_message Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> messaging block, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
##  \<a name="join__consume_message_method">\</a>  join::consume_message Method  
 Consumes a message previously offered by the                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> messaging block and reserved by the target, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object being consumed.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 Similar to                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, but is always preceded by a call to                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
##  \<a name="join__join_constructor">\</a>  join::join Constructor  
 Constructs a                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The number of inputs this                                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> block will be allowed.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> parameters.  
  
 The type                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is a functor with signature                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> which is invoked by this                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
##  \<a name="join___dtorjoin_destructor">\</a>  join::~join Destructor  
 Destroys the                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="join__link_target_notification_method">\</a>  join::link_target_notification Method  
 A callback that notifies that a new target has been linked to this                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="join__propagate_message_method">\</a>  join::propagate_message Method  
 Asynchronously passes a message from an                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> messaging block. It is invoked by the                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="join__propagate_to_any_targets_method">\</a>  join::propagate_to_any_targets Method  
 Constructs an output message containing an input message from each source when they have all propagated a message. Sends this output message out to each of its targets.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="join__release_message_method">\</a>  join::release_message Method  
 Releases a previous message reservation.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object being released.  
  
##  \<a name="join__reserve_message_method">\</a>  join::reserve_message Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 After                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is called, if it returns                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, either                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> must be called to either take or release ownership of the message.  
  
##  \<a name="join__resume_propagation_method">\</a>  join::resume_propagation Method  
 Resumes propagation after a reservation has been released.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [choice Class](../vs140/choice-class.md)   
 [multitype_join Class](../vs140/multitype_join-class.md)   
 [join_type Enumeration](concurrency_namespace_Enumerations)