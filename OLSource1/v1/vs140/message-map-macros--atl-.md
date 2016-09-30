---
title: "Message Map Macros (ATL)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: eefdd546-8934-4a30-b263-9c06a8addcbd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Message Map Macros (ATL)
These macros define message maps and entries.  
  
|||  
|-|-|  
|[ALT_MSG_MAP](../vs140/alt_msg_map.md)|Marks the beginning of an alternate message map.|  
|[BEGIN_MSG_MAP](../vs140/begin_msg_map.md)|Marks the beginning of the default message map.|  
|[CHAIN_MSG_MAP_ALT](../vs140/chain_msg_map_alt.md)|Chains to an alternate message map in the base class.|  
|[CHAIN_MSG_MAP_ALT_MEMBER](../vs140/chain_msg_map_alt_member.md)|Chains to an alternate message map in a data member of the class.|  
|[CHAIN_MSG_MAP](../vs140/chain_msg_map.md)|Chains to the default message map in the base class.|  
|[CHAIN_MSG_MAP_DYNAMIC](../vs140/chain_msg_map_dynamic.md)|Chains to the message map in another class at run time.|  
|[CHAIN_MSG_MAP_MEMBER](../vs140/chain_msg_map_member.md)|Chains to the default message map in a data member of the class.|  
|[COMMAND_CODE_HANDLER](../vs140/command_code_handler.md)|Maps a **WM_COMMAND** message to a handler function, based on the notification code.|  
|[COMMAND_HANDLER](../vs140/command_handler.md)|Maps a **WM_COMMAND** message to a handler function, based on the notification code and the identifier of the menu item, control, or accelerator.|  
|[COMMAND_ID_HANDLER](../vs140/command_id_handler.md)|Maps a **WM_COMMAND** message to a handler function, based on the identifier of the menu item, control, or accelerator.|  
|[COMMAND_RANGE_CODE_HANDLER](../vs140/command_range_code_handler.md)|Maps a **WM_COMMAND** message to a handler function, based on the notification code and a contiguous range of control identifiers.|  
|[COMMAND_RANGE_HANDLER](../vs140/command_range_handler.md)|Maps a **WM_COMMAND** message to a handler function, based on a contiguous range of control identifiers.|  
|[DECLARE_EMPTY_MSG_MAP](../vs140/declare_empty_msg_map.md)|Implements an empty message map.|  
|[DEFAULT_REFLECTION_HANDLER](../vs140/default_reflection_handler.md)|Provides a default handler for reflected messages that are not handled otherwise.|  
|[END_MSG_MAP](../vs140/end_msg_map.md)|Marks the end of a message map.|  
|[FORWARD_NOTIFICATIONS](../vs140/forward_notifications.md)|Forwards notification messages to the parent window.|  
|[MESSAGE_HANDLER](../vs140/message_handler.md)|Maps a Windows message to a handler function.|  
|[MESSAGE_RANGE_HANDLER](../vs140/message_range_handler.md)|Maps a contiguous range of Windows messages to a handler function.|  
|[NOTIFY_CODE_HANDLER](../vs140/notify_code_handler.md)|Maps a **WM_NOTIFY** message to a handler function, based on the notification code.|  
|[NOTIFY_HANDLER](../vs140/notify_handler.md)|Maps a **WM_NOTIFY** message to a handler function, based on the notification code and the control identifier.|  
|[NOTIFY_ID_HANDLER](../vs140/notify_id_handler.md)|Maps a **WM_NOTIFY** message to a handler function, based on the control identifier.|  
|[NOTIFY_RANGE_CODE_HANDLER](../vs140/notify_range_code_handler.md)|Maps a **WM_NOTIFY** message to a handler function, based on the notification code and a contiguous range of control identifiers.|  
|[NOTIFY_RANGE_HANDLER](../vs140/notify_range_handler.md)|Maps a **WM_NOTIFY** message to a handler function, based on a contiguous range of control identifiers.|  
|[REFLECT_NOTIFICATIONS](../vs140/reflect_notifications.md)|Reflects notification messages back to the window that sent them.|  
|[REFLECTED_COMMAND_CODE_HANDLER](../vs140/reflected_command_code_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on the notification code.|  
|[REFLECTED_COMMAND_HANDLER](../vs140/reflected_command_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on the notification code and the identifier of the menu item, control, or accelerator.|  
|[REFLECTED_COMMAND_ID_HANDLER](../vs140/reflected_command_id_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on the identifier of the menu item, control, or accelerator.|  
|[REFLECTED_COMMAND_RANGE_CODE_HANDLER](../vs140/reflected_command_range_code_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on the notification code and a contiguous range of control identifiers.|  
|[REFLECTED_COMMAND_RANGE_HANDLER](../vs140/reflected_command_range_handler.md)|Maps a reflected **WM_COMMAND** message to a handler function, based on a contiguous range of control identifiers.|  
|[REFLECTED_NOTIFY_CODE_HANDLER](../vs140/reflected_notify_code_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on the notification code.|  
|[REFLECTED_NOTIFY_HANDLER](../vs140/reflected_notify_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on the notification code and the control identifier.|  
|[REFLECTED_NOTIFY_ID_HANDLER](../vs140/reflected_notify_id_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on the control identifier.|  
|[REFLECTED_NOTIFY_RANGE_CODE_HANDLER](../vs140/reflected_notify_range_code_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on the notification code and a contiguous range of control identifiers.|  
|[REFLECTED_NOTIFY_RANGE_HANDLER](../vs140/reflected_notify_range_handler.md)|Maps a reflected **WM_NOTIFY** message to a handler function, based on a contiguous range of control identifiers.|  
  
## See Also  
 [Macros](../vs140/atl-macros.md)