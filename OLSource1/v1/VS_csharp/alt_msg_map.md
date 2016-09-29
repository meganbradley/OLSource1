---
title: "ALT_MSG_MAP"
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
  - "ATL.ALT_MSG_MAP"
  - "ALT_MSG_MAP"
  - "ATL::ALT_MSG_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ALT_MSG_MAP macro"
ms.assetid: 2c8871bf-abc0-4d52-bcf7-6b2ab9eb5af8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ALT_MSG_MAP
Marks the beginning of an alternate message map.  
  
## Syntax  
  
```  
  
ALT_MSG_MAP( msgMapID )  
```  
  
#### Parameters  
 `msgMapID`  
 [in] The message map identifier.  
  
## Remarks  
 ATL identifies each message map by a number. The default message map (declared with the `BEGIN_MSG_MAP` macro) is identified by 0. An alternate message map is identified by `msgMapID`.  
  
 Message maps are used to process messages sent to a window. For example, [CContainedWindow](../VS_csharp/ccontainedwindowt-class.md) allows you to specify the identifier of a message map in the containing object. [CContainedWindow::WindowProc](../Topic/CContainedWindowT::WindowProc.md) then uses this message map to direct the contained window's messages either to the appropriate handler function or to another message map. For a list of macros that declare handler functions, see [BEGIN_MSG_MAP](../VS_csharp/begin_msg_map.md).  
  
 Always begin a message map with `BEGIN_MSG_MAP`. You can then declare subsequent alternate message maps.  
  
 The [END_MSG_MAP](../VS_csharp/end_msg_map.md) macro marks the end of the message map. Note that there is always exactly one instance of `BEGIN_MSG_MAP` and `END_MSG_MAP`.  
  
 For more information about using message maps in ATL, see [Message Maps](../VS_csharp/message-maps--atl-.md).  
  
## Example  
 The following example shows the default message map and one alternate message map, each containing one handler function:  
  
 [!code[NVC_ATL_Windowing#98](../VS_csharp/codesnippet/CPP/alt_msg_map_1.h)]  
  
 The next example shows two alternate message maps. The default message map is empty.  
  
 [!code[NVC_ATL_Windowing#99](../VS_csharp/codesnippet/CPP/alt_msg_map_2.h)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../VS_csharp/message-map-macros--atl-.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [MESSAGE_HANDLER](../VS_csharp/message_handler.md)   
 [CMessageMap Class](../VS_csharp/cmessagemap-class.md)   
 [CDynamicChain Class](../VS_csharp/cdynamicchain-class.md)