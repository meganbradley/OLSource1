---
title: "source_block Class"
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
  - "agents/concurrency::source_block"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "source_block class"
ms.assetid: fbdd4146-e8d0-42e8-b714-fe633f69ffbf
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block Class
The             <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class is an abstract base class for source-only blocks. The class provides basic link management functionality as well as common error checks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Link registry to be used for holding the target links.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Processor type for message processing.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|The iterator to walk the connected targets.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[source_block::source_block Constructor](#source_block__source_block_constructor)|Constructs a                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[source_block::~source_block Destructor](#source_block___dtorsource_block_destructor)|Destroys the                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[source_block::accept Method](#source_block__accept_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object, transferring ownership to the caller.|  
|[source_block::acquire_ref Method](#source_block__acquire_ref_method)|Acquires a reference count on this                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object, to prevent deletion.|  
|[source_block::consume Method](#source_block__consume_method)|Consumes a message previously offered by this                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object and successfully reserved by the target, transferring ownership to the caller.|  
|[source_block::link_target Method](#source_block__link_target_method)|Links a target block to this                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.|  
|[source_block::release Method](#source_block__release_method)|Releases a previous successful message reservation.|  
|[source_block::release_ref Method](#source_block__release_ref_method)|Releases a reference count on this                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.|  
|[source_block::reserve Method](#source_block__reserve_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.|  
|[source_block::unlink_target Method](#source_block__unlink_target_method)|Unlinks a target block from this                                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.|  
|[source_block::unlink_targets Method](#source_block__unlink_targets_method)|Unlinks all target blocks from this                                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object. (Overrides                                         [ISource::unlink_targets](../vs140/isource-class.md#isource__unlink_targets_method).)|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[source_block::accept_message Method](#source_block__accept_message_method)|When overridden in a derived class, accepts an offered message by the source. Message blocks should override this method to validate the                                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and return a message.|  
|[source_block::async_send Method](#source_block__async_send_method)|Asynchronously queues up messages and starts a propagation task, if this has not been done already|  
|[source_block::consume_message Method](#source_block__consume_message_method)|When overridden in a derived class, consumes a message that was previously reserved.|  
|[source_block::enable_batched_processing Method](#source_block__enable_batched_processing_method)|Enables batched processing for this block.|  
|[source_block::initialize_source Method](#source_block__initialize_source_method)|Initializes the                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> within this                                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
|[source_block::link_target_notification Method](#source_block__link_target_notification_method)|A callback that notifies that a new target has been linked to this                                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.|  
|[source_block::process_input_messages Method](#source_block__process_input_messages_method)|Process input messages. This is only useful for propagator blocks, which derive from source_block|  
|[source_block::propagate_output_messages Method](#source_block__propagate_output_messages_method)|Propagate messages to targets.|  
|[source_block::propagate_to_any_targets Method](#source_block__propagate_to_any_targets_method)|When overridden in a derived class, propagates the given message to any or all of the linked targets. This is the main propagation routine for message blocks.|  
|[source_block::release_message Method](#source_block__release_message_method)|When overridden in a derived class, releases a previous message reservation.|  
|[source_block::remove_targets Method](#source_block__remove_targets_method)|Removes all target links for this source block. This should be called from the destructor.|  
|[source_block::reserve_message Method](#source_block__reserve_message_method)|When overridden in a derived class, reserves a message previously offered by this                                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.|  
|[source_block::resume_propagation Method](#source_block__resume_propagation_method)|When overridden in a derived class, resumes propagation after a reservation has been released.|  
|[source_block::sync_send Method](#source_block__sync_send_method)|Synchronously queues up messages and starts a propagation task, if this has not been done already.|  
|[source_block::unlink_target_notification Method](#source_block__unlink_target_notification_method)|A callback that notifies that a target has been unlinked from this                                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
|[source_block::wait_for_outstanding_async_sends Method](#source_block__wait_for_outstanding_async_sends_method)|Waits for all asynchronous propagations to complete. This propagator-specific spin wait is used in destructors of message blocks to make sure that all asynchronous propagations have time to finish before destroying the block.|  
  
## Remarks  
 Message blocks should derive from this block to take advantage of link management and synchronization provided by this class.  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="source_block__accept_method">\</a>  source_block::accept Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> method.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 The                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> method is called by a target while a message is being offered by this                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> block. The message pointer returned may be different from the one passed into the                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> method of the                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> block, if this source decides to make a copy of the message.  
  
##  \<a name="source_block__accept_message_method">\</a>  source_block::accept_message Method  
 When overridden in a derived class, accepts an offered message by the source. Message blocks should override this method to validate the                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and return a message.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The runtime object identity of the                                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A pointer to the message that the caller now has ownership of.  
  
### Remarks  
 To transfer ownership, the original message pointer should be returned. To maintain ownership, a copy of message payload needs to be made and returned.  
  
##  \<a name="source_block__acquire_ref_method">\</a>  source_block::acquire_ref Method  
 Acquires a reference count on this                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object, to prevent deletion.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This method is called by an                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object that is being linked to this source during the                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> method.  
  
##  \<a name="source_block__async_send_method">\</a>  source_block::async_send Method  
 Asynchronously queues up messages and starts a propagation task, if this has not been done already  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to a                                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object to asynchronously send.  
  
##  \<a name="source_block__consume_method">\</a>  source_block::consume Method  
 Consumes a message previously offered by this                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object and successfully reserved by the target, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> of the reserved                                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> method.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
 The method throws a                         [bad_target](../vs140/bad_target-class.md) exception if the parameter                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> does not represent the target that called                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
 The                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> method is similar to                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, but must always be preceded by a call to                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> that returned                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
##  \<a name="source_block__consume_message_method">\</a>  source_block::consume_message Method  
 When overridden in a derived class, consumes a message that was previously reserved.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object being consumed.  
  
### Return Value  
 A pointer to the message that the caller now has ownership of.  
  
### Remarks  
 Similar to                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, but is always preceded by a call to                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
##  \<a name="source_block__enable_batched_processing_method">\</a>  source_block::enable_batched_processing Method  
 Enables batched processing for this block.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="source_block__initialize_source_method">\</a>  source_block::initialize_source Method  
 Initializes the                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> within this                 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The scheduler to be used for scheduling tasks.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The schedule group to be used for scheduling tasks.  
  
##  \<a name="source_block__link_target_method">\</a>  source_block::link_target Method  
 Links a target block to this                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A pointer to an                                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> block to link to this                                 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter                         <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is                         <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
##  \<a name="source_block__link_target_notification_method">\</a>  source_block::link_target_notification Method  
 A callback that notifies that a new target has been linked to this                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="source_block__process_input_messages_method">\</a>  source_block::process_input_messages Method  
 Process input messages. This is only useful for propagator blocks, which derive from source_block  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  
##  \<a name="source_block__propagate_output_messages_method">\</a>  source_block::propagate_output_messages Method  
 Propagate messages to targets.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="source_block__propagate_to_any_targets_method">\</a>  source_block::propagate_to_any_targets Method  
 When overridden in a derived class, propagates the given message to any or all of the linked targets. This is the main propagation routine for message blocks.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A pointer to the message that is to be propagated.  
  
##  \<a name="source_block__release_method">\</a>  source_block::release Method  
 Releases a previous successful message reservation.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> of the reserved                                 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> method.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter                         <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is                         <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
 The method throws a                         [bad_target](../vs140/bad_target-class.md) exception if the parameter                         <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> does not represent the target that called                         <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
##  \<a name="source_block__release_message_method">\</a>  source_block::release_message Method  
 When overridden in a derived class, releases a previous message reservation.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object being released.  
  
##  \<a name="source_block__release_ref_method">\</a>  source_block::release_ref Method  
 Releases a reference count on this                 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling this method.  
  
### Remarks  
 This method is called by an                         <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object that is being unlinked from this source. The source block is allowed to release any resources reserved for the target block.  
  
##  \<a name="source_block__remove_targets_method">\</a>  source_block::remove_targets Method  
 Removes all target links for this source block. This should be called from the destructor.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="source_block__reserve_method">\</a>  source_block::reserve Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> method.  
  
### Return Value  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> otherwise. Reservations can fail for many reasons, including: the message was already reserved or accepted by another target, the source could deny reservations, and so forth.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter                         <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> is                         <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
 After you call                         <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>, if it succeeds, you must call either                         <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> in order to take or give up possession of the message, respectively.  
  
##  \<a name="source_block__reserve_message_method">\</a>  source_block::reserve_message Method  
 When overridden in a derived class, reserves a message previously offered by this                 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> object being reserved.  
  
### Return Value  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 After                         <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> is called, if it returns                         <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>, either                         <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> must be called to either take or release ownership of the message.  
  
##  \<a name="source_block__resume_propagation_method">\</a>  source_block::resume_propagation Method  
 When overridden in a derived class, resumes propagation after a reservation has been released.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="source_block__source_block_constructor">\</a>  source_block::source_block Constructor  
 Constructs a                 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="source_block___dtorsource_block_destructor">\</a>  source_block::~source_block Destructor  
 Destroys the                 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
##  \<a name="source_block__sync_send_method">\</a>  source_block::sync_send Method  
 Synchronously queues up messages and starts a propagation task, if this has not been done already.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 A pointer to a                                 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> object to synchronously send.  
  
##  \<a name="source_block__unlink_target_method">\</a>  source_block::unlink_target Method  
 Unlinks a target block from this                 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 A pointer to an                                 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> block to unlink from this                                 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter                         <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> is                         <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
##  \<a name="source_block__unlink_target_notification_method">\</a>  source_block::unlink_target_notification Method  
 A callback that notifies that a target has been unlinked from this                 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> block that was unlinked.  
  
##  \<a name="source_block__unlink_targets_method">\</a>  source_block::unlink_targets Method  
 Unlinks all target blocks from this                 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="source_block__wait_for_outstanding_async_sends_method">\</a>  source_block::wait_for_outstanding_async_sends Method  
 Waits for all asynchronous propagations to complete. This propagator-specific spin wait is used in destructors of message blocks to make sure that all asynchronous propagations have time to finish before destroying the block.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [ISource Class](../vs140/isource-class.md)