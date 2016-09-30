---
title: "timer Class"
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
  - "agents/concurrency::timer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "timer class"
ms.assetid: 4f4dea51-de9f-40f9-93f5-dd724c567b49
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timer Class
A             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> messaging block is a single-target             <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> capable of sending a message to its target after a specified time period has elapsed or at specific intervals.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The payload type of the output messages of this block.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[timer::timer Constructor](#timer__timer_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> messaging block that will fire a given message after a specified interval.|  
|[timer::~timer Destructor](#timer___dtortimer_destructor)|Destroys a                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> messaging block.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[timer::pause Method](#timer__pause_method)|Stops the                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> messaging block. If it is a repeating                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block, it can be restarted with a subsequent                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> call. For non-repeating timers, this has the same effect as a                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> call.|  
|[timer::start Method](#timer__start_method)|Starts the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> messaging block. The specified number of milliseconds after this is called, the specified value will be propagated downstream as a                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
|[timer::stop Method](#timer__stop_method)|Stops the                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> messaging block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[timer::accept_message Method](#timer__accept_message_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> messaging block, transferring ownership to the caller.|  
|[timer::consume_message Method](#timer__consume_message_method)|Consumes a message previously offered by the                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and reserved by the target, transferring ownership to the caller.|  
|[timer::link_target_notification Method](#timer__link_target_notification_method)|A callback that notifies that a new target has been linked to this                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> messaging block.|  
|[timer::propagate_to_any_targets Method](#timer__propagate_to_any_targets_method)|Tries to offer the message produced by the                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> block to all of the linked targets.|  
|[timer::release_message Method](#timer__release_message_method)|Releases a previous message reservation. (Overrides                                         [source_block::release_message](../vs140/source_block-class.md#source_block__release_message_method).)|  
|[timer::reserve_message Method](#timer__reserve_message_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> messaging block. (Overrides                                         [source_block::reserve_message](../vs140/source_block-class.md#source_block__reserve_message_method).)|  
|[timer::resume_propagation Method](#timer__resume_propagation_method)|Resumes propagation after a reservation has been released. (Overrides                                         [source_block::resume_propagation](../vs140/source_block-class.md#source_block__resume_propagation_method).)|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 [source_block](../vs140/source_block-class.md)  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="timer__accept_message_method">\</a>  timer::accept_message Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> messaging block, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
##  \<a name="timer__consume_message_method">\</a>  timer::consume_message Method  
 Consumes a message previously offered by the                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and reserved by the target, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object being consumed.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 Similar to                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, but is always preceded by a call to                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
##  \<a name="timer__link_target_notification_method">\</a>  timer::link_target_notification Method  
 A callback that notifies that a new target has been linked to this                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A pointer to the newly linked target.  
  
##  \<a name="timer__pause_method">\</a>  timer::pause Method  
 Stops the                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> messaging block. If it is a repeating                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> messaging block, it can be restarted with a subsequent                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> call. For non-repeating timers, this has the same effect as a                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> call.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="timer__propagate_to_any_targets_method">\</a>  timer::propagate_to_any_targets Method  
 Tries to offer the message produced by the                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> block to all of the linked targets.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="timer__release_message_method">\</a>  timer::release_message Method  
 Releases a previous message reservation.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object being released.  
  
##  \<a name="timer__reserve_message_method">\</a>  timer::reserve_message Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object being reserved.  
  
### Return Value  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 After                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is called, if it returns                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, either                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> must be called to either take or release ownership of the message.  
  
##  \<a name="timer__resume_propagation_method">\</a>  timer::resume_propagation Method  
 Resumes propagation after a reservation has been released.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="timer__start_method">\</a>  timer::start Method  
 Starts the                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> messaging block. The specified number of milliseconds after this is called, the specified value will be propagated downstream as a                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="timer__stop_method">\</a>  timer::stop Method  
 Stops the                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="timer__timer_constructor">\</a>  timer::timer Constructor  
 Constructs a                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> messaging block that will fire a given message after a specified interval.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The number of milliseconds that must elapse after the call to start for the specified message to be propagated downstream.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The value which will be propagated downstream when the timer elapses.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The target to which the timer will propagate its message.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 If true, indicates that the timer will fire periodically every                                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> milliseconds.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> messaging block is scheduled is scheduled.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> parameters.  
  
##  \<a name="timer___dtortimer_destructor">\</a>  timer::~timer Destructor  
 Destroys a                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)