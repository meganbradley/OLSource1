---
title: "target_block Class"
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
  - "agents/concurrency::target_block"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "target_block class"
ms.assetid: 3ce181b4-b94a-4894-bf7b-64fc09821f9f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block Class
The             <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class is an abstract base class that provides basic link management functionality and error checking for target only blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The link registry to be used for holding the source links.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The processor type for message processing.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The type of the iterator for the                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> for this                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[target_block::target_block Constructor](#target_block__target_block_constructor)|Constructs a                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[target_block::~target_block Destructor](#target_block___dtortarget_block_destructor)|Destroys the                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[target_block::propagate Method](#target_block__propagate_method)|Asynchronously passes a message from a source block to this target block.|  
|[target_block::send Method](#target_block__send_method)|Synchronously passes a message from a source block to this target block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[target_block::async_send Method](#target_block__async_send_method)|Asynchronously sends a message for processing.|  
|[target_block::decline_incoming_messages Method](#target_block__decline_incoming_messages_method)|Indicates to the block that new messages should be declined.|  
|[target_block::enable_batched_processing Method](#target_block__enable_batched_processing_method)|Enables batched processing for this block.|  
|[target_block::initialize_target Method](#target_block__initialize_target_method)|Initializes the base object. Specifically, the                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object needs to be initialized.|  
|[target_block::link_source Method](#target_block__link_source_method)|Links a specified source block to this                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.|  
|[target_block::process_input_messages Method](#target_block__process_input_messages_method)|Processes messages that are received as inputs.|  
|[target_block::process_message Method](#target_block__process_message_method)|When overridden in a derived class, processes a message that was accepted by this                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
|[target_block::propagate_message Method](#target_block__propagate_message_method)|When overridden in a derived class, this method asynchronously passes a message from an                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object. It is invoked by the                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method, when called by a source block.|  
|[target_block::register_filter Method](#target_block__register_filter_method)|Registers a filter method that will be invoked on every message received.|  
|[target_block::remove_sources Method](#target_block__remove_sources_method)|Unlinks all sources after waiting for outstanding asynchronous send operations to complete.|  
|[target_block::send_message Method](#target_block__send_message_method)|When overridden in a derived class, this method synchronously passes a message from an                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object. It is invoked by the                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method, when called by a source block.|  
|[target_block::sync_send Method](#target_block__sync_send_method)|Synchronously send a message for processing.|  
|[target_block::unlink_source Method](#target_block__unlink_source_method)|Unlinks a specified source block from this                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.|  
|[target_block::unlink_sources Method](#target_block__unlink_sources_method)|Unlinks all source blocks from this                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object. (Overrides                                         [ITarget::unlink_sources](../vs140/itarget-class.md#itarget__unlink_sources_method).)|  
|[target_block::wait_for_async_sends Method](#target_block__wait_for_async_sends_method)|Waits for all asynchronous propagations to complete.|  
  
## Inheritance Hierarchy  
 [ITarget](../vs140/itarget-class.md)  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="target_block__async_send_method">\</a>  target_block::async_send Method  
 Asynchronously sends a message for processing.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A pointer to the message being sent.  
  
##  \<a name="target_block__decline_incoming_messages_method">\</a>  target_block::decline_incoming_messages Method  
 Indicates to the block that new messages should be declined.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 This method is called by the destructor to ensure that new messages are declined while destruction is in progress.  
  
##  \<a name="target_block__enable_batched_processing_method">\</a>  target_block::enable_batched_processing Method  
 Enables batched processing for this block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="target_block__initialize_target_method">\</a>  target_block::initialize_target Method  
 Initializes the base object. Specifically, the                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object needs to be initialized.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The scheduler to be used for scheduling tasks.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The schedule group to be used for scheduling tasks.  
  
##  \<a name="target_block__link_source_method">\</a>  target_block::link_source Method  
 Links a specified source block to this                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> block that is to be linked.  
  
### Remarks  
 This function should not be called directly on a                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. Blocks should be connected together using the                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> method on                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> blocks, which will invoke the                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> method on the corresponding target.  
  
##  \<a name="target_block__process_input_messages_method">\</a>  target_block::process_input_messages Method  
 Processes messages that are received as inputs.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
##  \<a name="target_block__process_message_method">\</a>  target_block::process_message Method  
 When overridden in a derived class, processes a message that was accepted by this                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="target_block__propagate_method">\</a>  target_block::propagate Method  
 Asynchronously passes a message from a source block to this target block.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if either the                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> parameter is                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
##  \<a name="target_block__propagate_message_method">\</a>  target_block::propagate_message Method  
 When overridden in a derived class, this method asynchronously passes a message from an                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object. It is invoked by the                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="target_block__register_filter_method">\</a>  target_block::register_filter Method  
 Registers a filter method that will be invoked on every message received.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The filter method.  
  
##  \<a name="target_block__remove_sources_method">\</a>  target_block::remove_sources Method  
 Unlinks all sources after waiting for outstanding asynchronous send operations to complete.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 All target blocks should call this routine to remove the sources in their destructor.  
  
##  \<a name="target_block__send_method">\</a>  target_block::send Method  
 Synchronously passes a message from a source block to this target block.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if either the                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> parameter is                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
 Using the                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> method outside of message initiation and to propagate messages within a network is dangerous and can lead to deadlock.  
  
 When                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> returns, the message has either already been accepted, and transferred into the target block, or it has been declined by the target.  
  
##  \<a name="target_block__send_message_method">\</a>  target_block::send_message Method  
 When overridden in a derived class, this method synchronously passes a message from an                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object. It is invoked by the                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
### Remarks  
 By default, this block returns                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> unless overridden by a derived class.  
  
##  \<a name="target_block__sync_send_method">\</a>  target_block::sync_send Method  
 Synchronously send a message for processing.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to the message being sent.  
  
##  \<a name="target_block__target_block_constructor">\</a>  target_block::target_block Constructor  
 Constructs a                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="target_block___dtortarget_block_destructor">\</a>  target_block::~target_block Destructor  
 Destroys the                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
##  \<a name="target_block__unlink_source_method">\</a>  target_block::unlink_source Method  
 Unlinks a specified source block from this                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> block that is to be unlinked.  
  
##  \<a name="target_block__unlink_sources_method">\</a>  target_block::unlink_sources Method  
 Unlinks all source blocks from this                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="target_block__wait_for_async_sends_method">\</a>  target_block::wait_for_async_sends Method  
 Waits for all asynchronous propagations to complete.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 This method is used by message block destructors to ensure all asynchronous operations have had time to finish before destroying the block.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [ITarget Class](../vs140/itarget-class.md)