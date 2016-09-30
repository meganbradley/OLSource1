---
title: "ISource Class"
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
  - "agents/concurrency::ISource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ISource class"
ms.assetid: c7b73463-42f6-4dcc-801a-81379b12d35a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISource Class
The             <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class is the interface for all source blocks. Source blocks propagate messages to             <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The data type of the payload within the messages produced by the source block.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|A type alias for                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[ISource::~ISource Destructor](#isource___dtorisource_destructor)|Destroys the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ISource::accept Method](#isource__accept_method)|When overridden in a derived class, accepts a message that was offered by this                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> block, transferring ownership to the caller.|  
|[ISource::acquire_ref Method](#isource__acquire_ref_method)|When overridden in a derived class, acquires a reference count on this                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> block, to prevent deletion.|  
|[ISource::consume Method](#isource__consume_method)|When overridden in a derived class, consumes a message previously offered by this                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> block and successfully reserved by the target, transferring ownership to the caller.|  
|[ISource::link_target Method](#isource__link_target_method)|When overridden in a derived class, links a target block to this                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> block.|  
|[ISource::release Method](#isource__release_method)|When overridden in a derived class, releases a previous successful message reservation.|  
|[ISource::release_ref Method](#isource__release_ref_method)|When overridden in a derived class, releases a reference count on this                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> block.|  
|[ISource::reserve Method](#isource__reserve_method)|When overridden in a derived class, reserves a message previously offered by this                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> block.|  
|[ISource::unlink_target Method](#isource__unlink_target_method)|When overridden in a derived class, unlinks a target block from this                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> block, if found to be previously linked.|  
|[ISource::unlink_targets Method](#isource__unlink_targets_method)|When overridden in a derived class, unlinks all target blocks from this                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> block.|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="isource__accept_method">\</a>  ISource::accept Method  
 When overridden in a derived class, accepts a message that was offered by this                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> block, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method.  
  
### Return Value  
 A pointer to the message that the caller now has ownership of.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method is called by a target while a message is being offered by this                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> block. The message pointer returned may be different from the one passed into the                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method of the                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> block, if this source decides to make a copy of the message.  
  
##  \<a name="isource__acquire_ref_method">\</a>  ISource::acquire_ref Method  
 When overridden in a derived class, acquires a reference count on this                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> block, to prevent deletion.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling this method.  
  
### Remarks  
 This method is called by an                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object that is being linked to this source during the                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> method.  
  
##  \<a name="isource__consume_method">\</a>  ISource::consume Method  
 When overridden in a derived class, consumes a message previously offered by this                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> block and successfully reserved by the target, transferring ownership to the caller.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> of the reserved                                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> method.  
  
### Return Value  
 A pointer to the                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> method is similar to                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, but must always be preceded by a call to                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> that returned                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
##  \<a name="isource___dtorisource_destructor">\</a>  ISource::~ISource Destructor  
 Destroys the                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="isource__link_target_method">\</a>  ISource::link_target Method  
 When overridden in a derived class, links a target block to this                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A pointer to the target block being linked to this                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> block.  
  
##  \<a name="isource__release_method">\</a>  ISource::release Method  
 When overridden in a derived class, releases a previous successful message reservation.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> of the reserved                                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> method.  
  
##  \<a name="isource__release_ref_method">\</a>  ISource::release_ref Method  
 When overridden in a derived class, releases a reference count on this                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling this method.  
  
### Remarks  
 This method is called by an                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object that is being unlinked from this source. The source block is allowed to release any resources reserved for the target block.  
  
##  \<a name="isource__reserve_method">\</a>  ISource::reserve Method  
 When overridden in a derived class, reserves a message previously offered by this                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> of the offered                                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the                                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> method.  
  
### Return Value  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> if the message was successfully reserved,                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> otherwise. Reservations can fail for many reasons, including: the message was already reserved or accepted by another target, the source could deny reservations, and so forth.  
  
### Remarks  
 After you call                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, if it succeeds, you must call either                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> in order to take or give up possession of the message, respectively.  
  
##  \<a name="isource__unlink_target_method">\</a>  ISource::unlink_target Method  
 When overridden in a derived class, unlinks a target block from this                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> block, if found to be previously linked.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A pointer to the target block being unlinked from this                                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> block.  
  
##  \<a name="isource__unlink_targets_method">\</a>  ISource::unlink_targets Method  
 When overridden in a derived class, unlinks all target blocks from this                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [ITarget Class](../vs140/itarget-class.md)