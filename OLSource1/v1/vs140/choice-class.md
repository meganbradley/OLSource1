---
title: "choice Class"
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
  - "agents/concurrency::choice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "choice class"
ms.assetid: 4157a539-d5c2-4161-b1ab-536ce2888397
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice Class
A             <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> messaging block is a multi-source, single-target block that represents a control-flow interaction with a set of sources. The choice block will wait for any one of multiple sources to produce a message and will propagate the index of the source that produced the message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>-based type representing the payloads of the input sources.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|A type alias for                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[choice::choice Constructor](#choice__choice_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> messaging block.|  
|[choice::~choice Destructor](#choice___dtorchoice_destructor)|Destroys the                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> messaging block.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[choice::accept Method](#choice__accept_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> block, transferring ownership to the caller.|  
|[choice::acquire_ref Method](#choice__acquire_ref_method)|Acquires a reference count on this                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> messaging block, to prevent deletion.|  
|[choice::consume Method](#choice__consume_method)|Consumes a message previously offered by this                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> messaging block and successfully reserved by the target, transferring ownership to the caller.|  
|[choice::has_value Method](#choice__has_value_method)|Checks whether this                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> messaging block has been initialized with a value yet.|  
|[choice::index Method](#choice__index_method)|Returns an index into the                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> representing the element selected by the                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> messaging block.|  
|[choice::link_target Method](#choice__link_target_method)|Links a target block to this                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> messaging block.|  
|[choice::release Method](#choice__release_method)|Releases a previous successful message reservation.|  
|[choice::release_ref Method](#choice__release_ref_method)|Releases a reference count on this                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> messaging block.|  
|[choice::reserve Method](#choice__reserve_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> messaging block.|  
|[choice::unlink_target Method](#choice__unlink_target_method)|Unlinks a target block from this                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> messaging block.|  
|[choice::unlink_targets Method](#choice__unlink_targets_method)|Unlinks all targets from this                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> messaging block. (Overrides                                         [ISource::unlink_targets](../vs140/isource-class.md#isource__unlink_targets_method).)|  
|[choice::value Method](#choice__value_method)|Gets the message whose index was selected by the                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> messaging block.|  
  
## Remarks  
 The choice block ensures that only one of the incoming messages is consumed.  
  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="choice__accept_method">\</a>  choice::accept Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> block, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> method.  
  
### Return Value  
 A pointer to the message that the caller now has ownership of.  
  
##  \<a name="choice__acquire_ref_method">\</a>  choice::acquire_ref Method  
 Acquires a reference count on this                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> messaging block, to prevent deletion.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling this method.  
  
### Remarks  
 This method is called by an                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object that is being linked to this source during the                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> method.  
  
##  \<a name="choice__choice_constructor">\</a>  choice::choice Constructor  
 Constructs a                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> of sources for the choice.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> messaging block to copy from. Note that the original object is orphaned, making this a move constructor.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> parameters.  
  
 Move construction is not performed under a lock, which means that it is up to the user to make sure that there are no light-weight tasks in flight at the time of moving. Otherwise, numerous races can occur, leading to exceptions or inconsistent state.  
  
##  \<a name="choice___dtorchoice_destructor">\</a>  choice::~choice Destructor  
 Destroys the                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="choice__consume_method">\</a>  choice::consume Method  
 Consumes a message previously offered by this                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> messaging block and successfully reserved by the target, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> of the reserved                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> method.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> method is similar to                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, but must always be preceded by a call to                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> that returned                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
##  \<a name="choice__has_value_method">\</a>  choice::has_value Method  
 Checks whether this                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> messaging block has been initialized with a value yet.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if the block has received a value,                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="choice__index_method">\</a>  choice::index Method  
 Returns an index into the                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> representing the element selected by the                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The message index.  
  
### Remarks  
 The message payload can be extracted using the                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> method.  
  
##  \<a name="choice__link_target_method">\</a>  choice::link_target Method  
 Links a target block to this                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to an                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> block to link to this                                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> messaging block.  
  
##  \<a name="choice__release_method">\</a>  choice::release Method  
 Releases a previous successful message reservation.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object being released.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> method.  
  
##  \<a name="choice__release_ref_method">\</a>  choice::release_ref Method  
 Releases a reference count on this                 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling this method.  
  
### Remarks  
 This method is called by an                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object that is being unlinked from this source. The source block is allowed to release any resources reserved for the target block.  
  
##  \<a name="choice__reserve_method">\</a>  choice::reserve Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object being reserved.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> method.  
  
### Return Value  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> otherwise. Reservations can fail for many reasons, including: the message was already reserved or accepted by another target, the source could deny reservations, and so forth.  
  
### Remarks  
 After you call                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, if it succeeds, you must call either                         <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> in order to take or give up possession of the message, respectively.  
  
##  \<a name="choice__unlink_target_method">\</a>  choice::unlink_target Method  
 Unlinks a target block from this                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A pointer to an                                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> block to unlink from this                                 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> messaging block.  
  
##  \<a name="choice__unlink_targets_method">\</a>  choice::unlink_targets Method  
 Unlinks all targets from this                 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 This method does not need to be called from the destructor because destructor for the internal                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> block will unlink properly.  
  
##  \<a name="choice__value_method">\</a>  choice::value Method  
 Gets the message whose index was selected by the                 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The type of the message payload.  
  
### Return Value  
 The payload of the message.  
  
### Remarks  
 Because a                         <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> messaging block can take inputs with different payload types, you must specify the type of the payload at the point of retrieval. You can determine the type based on the result of the                         <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> method.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [join Class](../vs140/join-class.md)   
 [single_assignment Class](../vs140/single_assignment-class.md)   
 [make_choice Function](concurrency_namespace_Functions)   
 [tuple Class](../vs140/tuple-class.md)