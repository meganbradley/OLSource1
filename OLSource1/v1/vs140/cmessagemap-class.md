---
title: "CMessageMap Class"
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
  - "CMessageMap"
  - "ATL.CMessageMap"
  - "ATL::CMessageMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMessageMap class"
  - "message maps, ATL"
  - "ATL, message handlers"
ms.assetid: 1f97bc16-a8a0-4cf0-b90f-1778813a5c8e
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMessageMap Class
This class allows an object's message maps to be access by another object.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMessageMap::ProcessWindowMessage](../vs140/cmessagemap--processwindowmessage.md)|Accesses a message map in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived class.|  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an abstract base class that allows an object's message maps to be accessed by another object. In order for an object to expose its message maps, its class must derive from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 ATL uses <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to support contained windows and dynamic message map chaining. For example, any class containing a [CContainedWindow](../vs140/ccontainedwindowt-class.md) object must derive from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The following code is taken from the [SUBEDIT](../vs140/visual-c---samples.md) sample. Through [CComControl](../vs140/ccomcontrol-class.md), the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class automatically derives from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATL_Windowing#90](../vs140/codesnippet/CPP/cmessagemap-class_1.h)]  
  
 Because the contained window, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, will use a message map in the containing class, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> derives from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 For more information about message maps, see [Message Maps](../vs140/message-maps--atl-.md) in the article "ATL Window Classes."  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="cmessagemap__processwindowmessage">\</a>  CMessageMap::ProcessWindowMessage  
 Accesses the message map identified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>-derived class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [in] The handle to the window receiving the message.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [in] The message sent to the window.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 [out] The result of the message processing.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [in] The identifier of the message map that will process the message. The default message map, declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md), is identified by 0. An alternate message map, declared with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md), is identified by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
### Return Value  
 **TRUE** if the message is fully handled; otherwise,                         **FALSE**.  
  
### Remarks  
 Called by the window procedure of a [CContainedWindow](../vs140/ccontainedwindowt-class.md) object or of an object that is dynamically chaining to the message map.  
  
## See Also  
 [CDynamicChain Class](../vs140/cdynamicchain-class.md)   
 [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)   
 [ALT_MSG_MAP](../vs140/alt_msg_map.md)   
 [Class Overview](../vs140/atl-class-overview.md)