---
title: "CDynamicChain Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CDynamicChain"
  - "ATL.CDynamicChain"
  - "CDynamicChain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message maps, chaining"
  - "chaining message maps"
  - "CDynamicChain class"
ms.assetid: f084b2be-0e77-4836-973d-ae278a1e9da8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicChain Class
This class provides methods supporting the dynamic chaining of message maps.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDynamicChain::CDynamicChain](../vs140/cdynamicchain--cdynamicchain.md)|The constructor.|  
|[CDynamicChain::~CDynamicChain](../vs140/cdynamicchain--~cdynamicchain.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDynamicChain::CallChain](../vs140/cdynamicchain--callchain.md)|Directs a Windows message to another object's message map.|  
|[CDynamicChain::RemoveChainEntry](../vs140/cdynamicchain--removechainentry.md)|Removes a message map entry from the collection.|  
|[CDynamicChain::SetChainEntry](../vs140/cdynamicchain--setchainentry.md)|Adds a message map entry to the collection or modifies an existing entry.|  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> manages a collection of message maps, enabling a Windows message to be directed, at run time, to another object's message map.  
  
 To add support for dynamic chaining of message maps, do the following:  
  
-   Derive your class from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. In the message map, specify the [CHAIN_MSG_MAP_DYNAMIC](../vs140/chain_msg_map_dynamic.md) macro to chain to another object's default message map.  
  
-   Derive every class you want to chain to from [CMessageMap](../vs140/cmessagemap-class.md). <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> allows an object to expose its message maps to other objects.  
  
-   Call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to identify which object and which message map you want to chain to.  
  
 For example, suppose your class is defined as follows:  
  
 [!code[NVC_ATL_Windowing#88](../vs140/codesnippet/CPP/cdynamicchain-class_1.h)]  
  
 The client then calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>:  
  
 [!code[NVC_ATL_Windowing#89](../vs140/codesnippet/CPP/cdynamicchain-class_2.cpp)]  
  
 where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the chained object and is an instance of a class derived from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Now, if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> receives a message that is not handled by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the window procedure directs the message to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>'s default message map.  
  
 For more information about message map chaining, see [Message Maps](../vs140/message-maps--atl-.md) in the article "ATL Window Classes."  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="cdynamicchain__callchain">\</a>  CDynamicChain::CallChain  
 Directs the Windows message to another object's message map.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 [in] The unique identifier associated with the chained object and its message map.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 [in] The handle to the window receiving the message.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [in] The message sent to the window.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 [out] The result of the message processing.  
  
### Return Value  
 **TRUE** if the message is fully processed; otherwise,                         **FALSE**.  
  
### Remarks  
 For the window procedure to invoke <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, you must specify the [CHAIN_MSG_MAP_DYNAMIC](../vs140/chain_msg_map_dynamic.md) macro in your message map. For an example, see the [CDynamicChain](../vs140/cdynamicchain-class.md) overview.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> requires a previous call to [SetChainEntry](../vs140/cdynamicchain--setchainentry.md) to associate the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> value with an object and its message map.  
  
##  \<a name="cdynamicchain__cdynamicchain">\</a>  CDynamicChain::CDynamicChain  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="cdynamicchain___dtorcdynamicchain">\</a>  CDynamicChain::~CDynamicChain  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources.  
  
##  \<a name="cdynamicchain__removechainentry">\</a>  CDynamicChain::RemoveChainEntry  
 Removes the specified message map from the collection.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 [in] The unique identifier associated with the chained object and its message map. You originally define this value through a call to [SetChainEntry](../vs140/cdynamicchain--setchainentry.md).  
  
### Return Value  
 **TRUE** if the message map is successfully removed from the collection. Otherwise,                         **FALSE**.  
  
##  \<a name="cdynamicchain__setchainentry">\</a>  CDynamicChain::SetChainEntry  
 Adds the specified message map to the collection.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 [in] The unique identifier associated with the chained object and its message map.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [in] A pointer to the chained object declaring the message map. This object must derive from [CMessageMap](../vs140/cmessagemap-class.md).  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 [in] The identifier of the message map in the chained object. The default value is 0, which identifies the default message map declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md). To specify an alternate message map declared with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md), pass <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Return Value  
 **TRUE** if the message map is successfully added to the collection. Otherwise,                         **FALSE**.  
  
### Remarks  
 If the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> value already exists in the collection, its associated object and message map are replaced by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, respectively. Otherwise, a new entry is added.  
  
## See Also  
 [CWindowImpl Class](../vs140/cwindowimpl-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)