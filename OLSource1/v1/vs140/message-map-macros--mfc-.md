---
title: "Message Map Macros (MFC)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vc.mfc.messages
dev_langs: 
  - C++
helpviewer_keywords: 
  - message map macros
  - Windows messages [C++], declaration
  - demarcating Windows messages
  - message maps [C++], macros
  - message maps [C++], declaration and demarcation
  - message mapping macros
  - ranges, message map
  - message map ranges
ms.assetid: 531b15ce-32b5-4ca0-a849-bb519616c731
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Message Map Macros (MFC)
To support message maps, MFC supplies the following macros:  
  
### Message-Map Declaration and Demarcation Macros  
  
|||  
|-|-|  
|[DECLARE_MESSAGE_MAP](../vs140/declare_message_map.md)|Declares that a message map will be used in a class to map messages to functions (must be used in the class declaration).|  
|[BEGIN_MESSAGE_MAP](../vs140/begin_message_map.md)|Begins the definition of a message map (must be used in the class implementation).|  
|[END_MESSAGE_MAP](../vs140/end_message_map.md)|Ends the definition of a message map (must be used in the class implementation).|  
  
### Message-Mapping Macros  
  
|||  
|-|-|  
|[ON_COMMAND](../vs140/on_command.md)|Indicates which function will handle a specified command message.|  
|[ON_CONTROL](../vs140/on_control.md)|Indicates which function will handle a specified control-notification message.|  
|[ON_MESSAGE](../vs140/on_message.md)|Indicates which function will handle a user-defined message.|  
|[ON_OLECMD](../vs140/on_olecmd.md)|Indicates which function will handle a menu command from a DocObject or its container.|  
|[ON_REGISTERED_MESSAGE](../vs140/on_registered_message.md)|Indicates which function will handle a registered user-defined message.|  
|[ON_REGISTERED_THREAD_MESSAGE](../vs140/on_registered_thread_message.md)|Indicates which function will handle a registered user-defined message when you have a `CWinThread` class.|  
|[ON_THREAD_MESSAGE](../vs140/on_thread_message.md)|Indicates which function will handle a user-defined message when you have a `CWinThread` class.|  
|[ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md)|Indicates which function will handle a specified user-interface update command message.|  
  
### Message-Map Range Macros  
  
|||  
|-|-|  
|[ON_COMMAND_RANGE](../vs140/on_command_range.md)|Indicates which function will handle the range of command IDs specified in the first two parameters to the macro.|  
|[ON_UPDATE_COMMAND_UI_RANGE](../vs140/on_update_command_ui_range.md)|Indicates which update handler will handle the range of command IDs specified in the first two parameters to the macro.|  
|[ON_CONTROL_RANGE](../vs140/on_control_range.md)|Indicates which function will handle notifications from the range of control IDs specified in the second and third parameters to the macro. The first parameter is a control-notification message, such as **BN_CLICKED**.|  
  
 For more information on message maps, the message-map declaration and demarcation macros, and the message-mapping macros, see [Message Maps](../vs140/message-maps--mfc-.md) and [Message Handling and Mapping Topics](../vs140/message-handling-and-mapping.md). For more information about message-map ranges, see [Handlers for Message-Map Ranges](../vs140/handlers-for-message-map-ranges.md).  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)