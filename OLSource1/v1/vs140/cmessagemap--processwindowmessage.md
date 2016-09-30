---
title: "CMessageMap::ProcessWindowMessage"
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
  - "ATL.CMessageMap.ProcessWindowMessage"
  - "ATL::CMessageMap::ProcessWindowMessage"
  - "ProcessWindowMessage"
  - "CMessageMap.ProcessWindowMessage"
  - "CMessageMap::ProcessWindowMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ProcessWindowMessage method"
ms.assetid: 0d8a3cf2-a9b2-45eb-a985-9e316a73a00b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMessageMap::ProcessWindowMessage
Accesses the message map identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The handle to the window receiving the message.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The message sent to the window.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] The result of the message processing.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The identifier of the message map that will process the message. The default message map, declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md), is identified by 0. An alternate message map, declared with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md), is identified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Return Value  
 **TRUE** if the message is fully handled; otherwise, **FALSE**.  
  
## Remarks  
 Called by the window procedure of a [CContainedWindow](../vs140/ccontainedwindowt-class.md) object or of an object that is dynamically chaining to the message map.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CMessageMap Class](../vs140/cmessagemap-class.md)   
 [CHAIN_MSG_MAP_DYNAMIC](../vs140/chain_msg_map_dynamic.md)