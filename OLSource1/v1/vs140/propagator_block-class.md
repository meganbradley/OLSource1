---
title: "propagator_block Class"
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
  - "agents/concurrency::propagator_block"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagator_block class"
ms.assetid: 86aa75fd-eda5-42aa-aadf-25c0c1c9742d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# propagator_block Class
The             <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class is an abstract base class for message blocks that are both a source and target. It combines the functionality of both the             <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and             <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> classes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The link registry to be used for holding the target links.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The link registry to be used for holding the source links.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The processor type for message processing.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The type of the iterator for the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> for this                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[propagator_block::propagator_block Constructor](#propagator_block__propagator_block_constructor)|Constructs a                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
|[propagator_block::~propagator_block Destructor](#propagator_block___dtorpropagator_block_destructor)|Destroys a                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[propagator_block::propagate Method](#propagator_block__propagate_method)|Asynchronously passes a message from a source block to this target block.|  
|[propagator_block::send Method](#propagator_block__send_method)|Synchronously initiates a message to this block. Called by an                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> block. When this function completes, the message will already have propagated into the block.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[propagator_block::decline_incoming_messages Method](#propagator_block__decline_incoming_messages_method)|Indicates to the block that new messages should be declined.|  
|[propagator_block::initialize_source_and_target Method](#propagator_block__initialize_source_and_target_method)|Initializes the base object. Specifically, the                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object needs to be initialized.|  
|[propagator_block::link_source Method](#propagator_block__link_source_method)|Links a specified source block to this                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.|  
|[propagator_block::process_input_messages Method](#propagator_block__process_input_messages_method)|Process input messages. This is only useful for propagator blocks, which derive from source_block (Overrides                                         [source_block::process_input_messages](../vs140/source_block-class.md#source_block__process_input_messages_method).)|  
|[propagator_block::propagate_message Method](#propagator_block__propagate_message_method)|When overridden in a derived class, this method asynchronously passes a message from an                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object. It is invoked by the                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method, when called by a source block.|  
|[propagator_block::register_filter Method](#propagator_block__register_filter_method)|Registers a filter method that will be invoked on every received message.|  
|[propagator_block::remove_network_links Method](#propagator_block__remove_network_links_method)|Removes all the source and target network links from this                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[propagator_block::send_message Method](#propagator_block__send_message_method)|When overridden in a derived class, this method synchronously passes a message from an                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> block to this                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object. It is invoked by the                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method, when called by a source block.|  
|[propagator_block::unlink_source Method](#propagator_block__unlink_source_method)|Unlinks a specified source block from this                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[propagator_block::unlink_sources Method](#propagator_block__unlink_sources_method)|Unlinks all source blocks from this                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object. (Overrides                                         [ITarget::unlink_sources](../vs140/itarget-class.md#itarget__unlink_sources_method).)|  
  
## Remarks  
 To avoid multiple inheritance, the                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class inherits from the                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> class and                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> abstract class. Most of the functionality in the                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> class is replicated here.  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 [ITarget](../vs140/itarget-class.md)  
  
 [source_block](../vs140/source_block-class.md)  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="propagator_block__decline_incoming_messages_method">\</a>  propagator_block::decline_incoming_messages Method  
 Indicates to the block that new messages should be declined.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 This method is called by the destructor to ensure that new messages are declined while destruction is in progress.  
  
##  \<a name="propagator_block__initialize_source_and_target_method">\</a>  propagator_block::initialize_source_and_target Method  
 Initializes the base object. Specifically, the                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object needs to be initialized.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The scheduler to be used for scheduling tasks.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The schedule group to be used for scheduling tasks.  
  
##  \<a name="propagator_block__link_source_method">\</a>  propagator_block::link_source Method  
 Links a specified source block to this                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> block that is to be linked.  
  
##  \<a name="propagator_block__process_input_messages_method">\</a>  propagator_block::process_input_messages Method  
 Process input messages. This is only useful for propagator blocks, which derive from source_block  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
##  \<a name="propagator_block__propagate_method">\</a>  propagator_block::propagate Method  
 Asynchronously passes a message from a source block to this target block.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> method is invoked on a target block by a linked source block. It queues up an asynchronous task to handle the message, if one is not already queued or executing.  
  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if either the                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> parameter is                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
##  \<a name="propagator_block__propagate_message_method">\</a>  propagator_block::propagate_message Method  
 When overridden in a derived class, this method asynchronously passes a message from an                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object. It is invoked by the                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
##  \<a name="propagator_block__propagator_block_constructor">\</a>  propagator_block::propagator_block Constructor  
 Constructs a                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="propagator_block___dtorpropagator_block_destructor">\</a>  propagator_block::~propagator_block Destructor  
 Destroys a                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="propagator_block__register_filter_method">\</a>  propagator_block::register_filter Method  
 Registers a filter method that will be invoked on every received message.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The filter method.  
  
##  \<a name="propagator_block__remove_network_links_method">\</a>  propagator_block::remove_network_links Method  
 Removes all the source and target network links from this                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="propagator_block__send_method">\</a>  propagator_block::send Method  
 Synchronously initiates a message to this block. Called by an                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> block. When this function completes, the message will already have propagated into the block.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
### Remarks  
 This method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if either the                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> parameter is                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
##  \<a name="propagator_block__send_message_method">\</a>  propagator_block::send_message Method  
 When overridden in a derived class, this method synchronously passes a message from an                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> block to this                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object. It is invoked by the                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> method, when called by a source block.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
### Remarks  
 By default, this block returns                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> unless overridden by a derived class.  
  
##  \<a name="propagator_block__unlink_source_method">\</a>  propagator_block::unlink_source Method  
 Unlinks a specified source block from this                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> block that is to be unlinked.  
  
##  \<a name="propagator_block__unlink_sources_method">\</a>  propagator_block::unlink_sources Method  
 Unlinks all source blocks from this                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [source_block Class](../vs140/source_block-class.md)   
 [ITarget Class](../vs140/itarget-class.md)