---
title: "multitype_join Class"
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
  - "agents/concurrency::multitype_join"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "multitype_join class"
ms.assetid: 236e87a0-4867-49fd-869a-bef4010e49a7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multitype_join Class
A             <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> messaging block is a multi-source, single-target messaging block that combines together messages of different types from each of its sources and offers a tuple of the combined messages to its targets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> payload type of the messages joined and propagated by the block.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The kind of                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> block this is, either                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|A type alias for                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[multitype_join::multitype_join Constructor](#multitype_join__multitype_join_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> messaging block.|  
|[multitype_join::~multitype_join Destructor](#multitype_join___dtormultitype_join_destructor)|Destroys the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> messaging block.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[multitype_join::accept Method](#multitype_join__accept_method)|Accepts a message that was offered by this                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> block, transferring ownership to the caller.|  
|[multitype_join::acquire_ref Method](#multitype_join__acquire_ref_method)|Acquires a reference count on this                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> messaging block, to prevent deletion.|  
|[multitype_join::consume Method](#multitype_join__consume_method)|Consumes a message previously offered by the                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> messaging block and successfully reserved by the target, transferring ownership to the caller.|  
|[multitype_join::link_target Method](#multitype_join__link_target_method)|Links a target block to this                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> messaging block.|  
|[multitype_join::release Method](#multitype_join__release_method)|Releases a previous successful message reservation.|  
|[multitype_join::release_ref Method](#multitype_join__release_ref_method)|Releases a reference count on this                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> messaging block.|  
|[multitype_join::reserve Method](#multitype_join__reserve_method)|Reserves a message previously offered by this                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> messaging block.|  
|[multitype_join::unlink_target Method](#multitype_join__unlink_target_method)|Unlinks a target block from this                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> messaging block.|  
|[multitype_join::unlink_targets Method](#multitype_join__unlink_targets_method)|Unlinks all targets from this                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> messaging block. (Overrides                                         [ISource::unlink_targets](../vs140/isource-class.md#isource__unlink_targets_method).)|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 [ISource](../vs140/isource-class.md)  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="multitype_join__accept_method">\</a>  multitype_join::accept Method  
 Accepts a message that was offered by this                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method.  
  
### Return Value  
 A pointer to the message that the caller now has ownership of.  
  
##  \<a name="multitype_join__acquire_ref_method">\</a>  multitype_join::acquire_ref Method  
 Acquires a reference count on this                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> messaging block, to prevent deletion.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling this method.  
  
### Remarks  
 This method is called by an                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object that is being linked to this source during the                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method.  
  
##  \<a name="multitype_join__consume_method">\</a>  multitype_join::consume Method  
 Consumes a message previously offered by the                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> messaging block and successfully reserved by the target, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> of the reserved                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> method.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> method is similar to                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, but must always be preceded by a call to                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> that returned                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="multitype_join__link_target_method">\</a>  multitype_join::link_target Method  
 Links a target block to this                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A pointer to an                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> block to link to this                                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> messaging block.  
  
##  \<a name="multitype_join__multitype_join_constructor">\</a>  multitype_join::multitype_join Constructor  
 Constructs a                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> of sources for this                                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> messaging block.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> messaging block to copy from. Note that the original object is orphaned, making this a move constructor.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> parameters.  
  
 Move construction is not performed under a lock, which means that it is up to the user to make sure that there are no light-weight tasks in flight at the time of moving. Otherwise, numerous races can occur, leading to exceptions or inconsistent state.  
  
##  \<a name="multitype_join___dtormultitype_join_destructor">\</a>  multitype_join::~multitype_join Destructor  
 Destroys the                 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="multitype_join__release_method">\</a>  multitype_join::release Method  
 Releases a previous successful message reservation.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object being released.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> method.  
  
##  \<a name="multitype_join__release_ref_method">\</a>  multitype_join::release_ref Method  
 Releases a reference count on this                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling this method.  
  
### Remarks  
 This method is called by an                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object that is being unlinked from this source. The source block is allowed to release any resources reserved for the target block.  
  
##  \<a name="multitype_join__reserve_method">\</a>  multitype_join::reserve Method  
 Reserves a message previously offered by this                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> of the                                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object being reserved.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> method.  
  
### Return Value  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> otherwise. Reservations can fail for many reasons, including: the message was already reserved or accepted by another target, the source could deny reservations, and so forth.  
  
### Remarks  
 After you call                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, if it succeeds, you must call either                         <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> in order to take or give up possession of the message, respectively.  
  
##  \<a name="multitype_join__unlink_target_method">\</a>  multitype_join::unlink_target Method  
 Unlinks a target block from this                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 A pointer to an                                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> block to unlink from this                                 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> messaging block.  
  
##  \<a name="multitype_join__unlink_targets_method">\</a>  multitype_join::unlink_targets Method  
 Unlinks all targets from this                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [choice Class](../vs140/choice-class.md)   
 [join Class](../vs140/join-class.md)   
 [join_type Enumeration](concurrency_namespace_Enumerations)   
 [make_join Function](concurrency_namespace_Functions)   
 [make_greedy_join Function](concurrency_namespace_Functions)   
 [tuple Class](../vs140/tuple-class.md)