---
title: "BEGIN_MSG_MAP"
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
  - "BEGIN_MSG_MAP"
  - "ATL::BEGIN_MSG_MAP"
  - "ATL.BEGIN_MSG_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_MSG_MAP macro"
  - "message maps, ATL"
ms.assetid: 8bbb5af9-18b1-48c6-880e-166f599ee554
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_MSG_MAP
Marks the beginning of the default message map.  
  
## Syntax  
  
```  
  
BEGIN_MSG_MAP( theClass )  
```  
  
#### Parameters  
 `theClass`  
 [in] The name of the class containing the message map.  
  
## Remarks  
 [CWindowImpl::WindowProc](../Topic/CWindowImpl::WindowProc.md) uses the default message map to process messages sent to the window. The message map directs messages either to the appropriate handler function or to another message map.  
  
 The following macros map a message to a handler function. This function must be defined in `theClass`.  
  
|Macro|Description|  
|-----------|-----------------|  
|[MESSAGE_HANDLER](../VS_csharp/message_handler.md)|Maps a Windows message to a handler function.|  
|[MESSAGE_RANGE_HANDLER](../VS_csharp/message_range_handler.md)|Maps a contiguous range of Windows messages to a handler function.|  
|[COMMAND_HANDLER](../VS_csharp/command_handler.md)|Maps a **WM_COMMAND** message to a handler function, based on the notification code and the identifier of the menu item, control, or accelerator.|  
|[COMMAND_ID_HANDLER](../VS_csharp/command_id_handler.md)|Maps a **WM_COMMAND** message to a handler function, based on the identifier of the menu item, control, or accelerator.|  
|[COMMAND_CODE_HANDLER](../VS_csharp/command_handler.md)|Maps a **WM_COMMAND** message to a handler function, based on the notification code.|  
|[COMMAND_RANGE_HANDLER](../VS_csharp/command_range_handler.md)|Maps a contiguous range of **WM_COMMAND** messages to a handler function, based on the identifier of the menu item, control, or accelerator.|  
|[NOTIFY_HANDLER](../VS_csharp/notify_handler.md)|Maps a **WM_NOTIFY** message to a handler function, based on the notification code and the control identifier.|  
|[NOTIFY_ID_HANDLER](../VS_csharp/notify_id_handler.md)|Maps a **WM_NOTIFY** message to a handler function, based on the control identifier.|  
|[NOTIFY_CODE_HANDLER](../VS_csharp/notify_code_handler.md)|Maps a **WM_NOTIFY** message to a handler function, based on the notification code.|  
|[NOTIFY_RANGE_HANDLER](../VS_csharp/notify_range_handler.md)|Maps a contiguous range of **WM_NOTIFY** messages to a handler function, based on the control identifier.|  
  
 The following macros direct messages to another message map. This process is called "chaining."  
  
|Macro|Description|  
|-----------|-----------------|  
|[CHAIN_MSG_MAP](../VS_csharp/chain_msg_map.md)|Chains to the default message map in the base class.|  
|[CHAIN_MSG_MAP_MEMBER](../VS_csharp/chain_msg_map_member.md)|Chains to the default message map in a data member of the class.|  
|[CHAIN_MSG_MAP_ALT](../VS_csharp/chain_msg_map_alt.md)|Chains to an alternate message map in the base class.|  
|[CHAIN_MSG_MAP_ALT_MEMBER](../VS_csharp/chain_msg_map_alt_member.md)|Chains to an alternate message map in a data member of the class.|  
|[CHAIN_MSG_MAP_DYNAMIC](../VS_csharp/chain_msg_map_dynamic.md)|Chains to the default message map in another class at run time.|  
  
 The following macros direct "reflected" messages from the parent window. For example, a control normally sends notification messages to its parent window for processing, but the parent window can reflect the message back to the control.  
  
|Macro|Description|  
|-----------|-----------------|  
|[REFLECTED_COMMAND_HANDLER](../VS_csharp/reflected_command_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on the notification code and the identifier of the menu item, control, or accelerator.|  
|[REFLECTED_COMMAND_ID_HANDLER](../VS_csharp/reflected_command_id_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on the identifier of the menu item, control, or accelerator.|  
|[REFLECTED_COMMAND_CODE_HANDLER](../VS_csharp/reflected_command_code_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on the notification code.|  
|[REFLECTED_COMMAND_RANGE_HANDLER](../VS_csharp/reflected_command_range_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on a contiguous range of control identifiers.|  
|[REFLECTED_COMMAND_RANGE_CODE_HANDLER](../VS_csharp/reflected_command_range_code_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on the notification code and a contiguous range of control identifiers.|  
|[REFLECTED_NOTIFY_HANDLER](../VS_csharp/reflected_notify_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on the notification code and the control identifier.|  
|[REFLECTED_NOTIFY_ID_HANDLER](../VS_csharp/reflected_notify_id_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on the control identifier.|  
|[REFLECTED_NOTIFY_CODE_HANDLER](../VS_csharp/reflected_notify_code_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on the notification code.|  
|[REFLECTED_NOTIFY_RANGE_HANDLER](../VS_csharp/reflected_notify_range_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on a contiguous range of control identifiers.|  
|[REFLECTED_NOTIFY_RANGE_CODE_HANDLER](../VS_csharp/reflected_notify_range_code_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on the notification code and a contiguous range of control identifiers.|  
  
## Example  
 [!code[NVC_ATL_Windowing#102](../VS_csharp/codesnippet/CPP/begin_msg_map_1.h)]  
  
 When a `CMyExtWindow` object receives a `WM_PAINT` message, the message is directed to `CMyExtWindow::OnPaint` for the actual processing. If `OnPaint` indicates the message requires further processing, the message will then be directed to the default message map in `CMyBaseWindow`.  
  
 In addition to the default message map, you can define an alternate message map with [ALT_MSG_MAP](../VS_csharp/alt_msg_map.md). Always begin a message map with `BEGIN_MSG_MAP`. You can then declare subsequent alternate message maps. The following example shows the default message map and one alternate message map, each containing one handler function:  
  
 [!code[NVC_ATL_Windowing#98](../VS_csharp/codesnippet/CPP/begin_msg_map_2.h)]  
  
 The next example shows two alternate message maps. The default message map is empty.  
  
 [!code[NVC_ATL_Windowing#99](../VS_csharp/codesnippet/CPP/begin_msg_map_3.h)]  
  
 The [END_MSG_MAP](../VS_csharp/end_msg_map.md) macro marks the end of the message map. Note that there is always exactly one instance of `BEGIN_MSG_MAP` and `END_MSG_MAP`.  
  
 For more information about using message maps in ATL, see [Message Maps](../VS_csharp/message-maps--atl-.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../VS_csharp/message-map-macros--atl-.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [CMessageMap Class](../VS_csharp/cmessagemap-class.md)   
 [CDynamicChain Class](../VS_csharp/cdynamicchain-class.md)