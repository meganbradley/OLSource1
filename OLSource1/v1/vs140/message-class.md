---
title: "message Class"
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
  - "agents/concurrency::message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message class"
ms.assetid: 3e1f3505-6c0c-486c-8191-666d0880ec62
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message Class
The basic message envelope containing the data payload being passed between messaging blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The data type of the payload within the message.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|A type alias for                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[message::message Constructor](#message__message_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[message::~message Destructor](#message___dtormessage_destructor)|Destroys the                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[message::add_ref Method](#message__add_ref_method)|Adds to the reference count for the                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. Used for message blocks that need reference counting to determine message lifetimes.|  
|[message::msg_id Method](#message__msg_id_method)|Returns the ID of the                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[message::remove_ref Method](#message__remove_ref_method)|Subtracts from the reference count for the                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. Used for message blocks that need reference counting to determine message lifetimes.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[message::payload Data Member](#message__payload_data_member)|The payload of the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 For more information, see                 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="message__add_ref_method">\</a>  message::add_ref Method  
 Adds to the reference count for the                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object. Used for message blocks that need reference counting to determine message lifetimes.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The new value of the reference count.  
  
##  \<a name="message__message_constructor">\</a>  message::message Constructor  
 Constructs a                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The payload of this message.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The unique ID of this message.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A reference or pointer to a                                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The constructor that takes a pointer to a                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object as an argument throws an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
##  \<a name="message___dtormessage_destructor">\</a>  message::~message Destructor  
 Destroys the                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="message__msg_id_method">\</a>  message::msg_id Method  
 Returns the ID of the                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> of the                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
##  \<a name="message__payload_data_member">\</a>  message::payload Data Member  
 The payload of the                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="message__remove_ref_method">\</a>  message::remove_ref Method  
 Subtracts from the reference count for the                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object. Used for message blocks that need reference counting to determine message lifetimes.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The new value of the reference count.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)