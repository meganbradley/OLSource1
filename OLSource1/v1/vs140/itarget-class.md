---
title: "ITarget Class"
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
  - "agents/concurrency::ITarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ITarget class"
ms.assetid: 5678db25-112a-4f72-be13-42e16b67c48b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITarget Class
The             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class is the interface for all target blocks. Target blocks consume messages offered to them by             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The data type of the payload within the messages accepted by the target block.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The signature of any method used by the block that returns a                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value to determine whether an offered message should be accepted.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|A type alias for                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[ITarget::~ITarget Destructor](#itarget___dtoritarget_destructor)|Destroys the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ITarget::propagate Method](#itarget__propagate_method)|When overridden in a derived class, asynchronously passes a message from a source block to this target block.|  
|[ITarget::send Method](#itarget__send_method)|When overridden in a derived class, synchronously passes a message to the target block.|  
|[ITarget::supports_anonymous_source Method](#itarget__supports_anonymous_source_method)|When overridden in a derived class, returns true or false depending on whether the message block accepts messages offered by a source that is not linked to it. If the overridden method returns                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the target cannot postpone an offered message, as consumption of a postponed message at a later time requires the source to be identified in its sourse link registry.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ITarget::link_source Method](#itarget__link_source_method)|When overridden in a derived class, links a specified source block to this                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> block.|  
|[ITarget::unlink_source Method](#itarget__unlink_source_method)|When overridden in a derived class, unlinks a specified source block from this                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> block.|  
|[ITarget::unlink_sources Method](#itarget__unlink_sources_method)|When overridden in a derived class, unlinks all source blocks from this                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> block.|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="itarget___dtoritarget_destructor">\</a>  ITarget::~ITarget Destructor  
 Destroys the                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="itarget__link_source_method">\</a>  ITarget::link_source Method  
 When overridden in a derived class, links a specified source block to this                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> block being linked to this                                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> block.  
  
### Remarks  
 This function should not be called directly on an                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> block. Blocks should be connected together using the                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method on                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> blocks, which will invoke the                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method on the corresponding target.  
  
##  \<a name="itarget__propagate_method">\</a>  ITarget::propagate Method  
 When overridden in a derived class, asynchronously passes a message from a source block to this target block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if either the                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter is                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
##  \<a name="itarget__send_method">\</a>  ITarget::send Method  
 When overridden in a derived class, synchronously passes a message to the target block.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to the                                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A pointer to the source block offering the message.  
  
### Return Value  
 A                         [message_status](concurrency_namespace_Enumerations) indication of what the target decided to do with the message.  
  
### Remarks  
 The method throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if either the                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter is                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 Using the                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method outside of message initiation and to propagate messages within a network is dangerous and can lead to deadlock.  
  
 When                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> returns, the message has either already been accepted, and transferred into the target block, or it has been declined by the target.  
  
##  \<a name="itarget__supports_anonymous_source_method">\</a>  ITarget::supports_anonymous_source Method  
 When overridden in a derived class, returns true or false depending on whether the message block accepts messages offered by a source that is not linked to it. If the overridden method returns                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, the target cannot postpone an offered message, as consumption of a postponed message at a later time requires the source to be identified in its sourse link registry.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if the block can accept message from a source that is not linked to it                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="itarget__unlink_source_method">\</a>  ITarget::unlink_source Method  
 When overridden in a derived class, unlinks a specified source block from this                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> block being unlinked from this                                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> block.  
  
### Remarks  
 This function should not be called directly on an                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> block. Blocks should be disconnected using the                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> methods on                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> blocks, which will invoke the                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> method on the corresponding target.  
  
##  \<a name="itarget__unlink_sources_method">\</a>  ITarget::unlink_sources Method  
 When overridden in a derived class, unlinks all source blocks from this                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [ISource Class](../vs140/isource-class.md)