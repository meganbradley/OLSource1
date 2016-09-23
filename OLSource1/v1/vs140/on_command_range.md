---
title: "ON_COMMAND_RANGE"
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
  - ON_COMMAND_RANGE
dev_langs: 
  - C++
helpviewer_keywords: 
  - ON_COMMAND_RANGE macro
  - message map ranges
ms.assetid: c52719fc-dd6e-48c9-af79-383f48d608e0
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ON_COMMAND_RANGE
Use this macro to map a contiguous range of command IDs to a single message handler function.  
  
## Syntax  
  
```  
  
ON_COMMAND_RANGE(  
id1  
,   
id2  
,   
memberFxn )  
```  
  
#### Parameters  
 *id1*  
 Command ID at the beginning of a contiguous range of command IDs.  
  
 `id2`  
 Command ID at the end of a contiguous range of command IDs.  
  
 `memberFxn`  
 The name of the message-handler function to which the commands are mapped.  
  
## Remarks  
 The range of IDs starts with *id1* and ends with `id2`.  
  
 Use `ON_COMMAND_RANGE` to map a range of command IDs to one member function. Use [ON_COMMAND](../vs140/on_command.md) to map a single command to a member function. Only one message-map entry can match a given command ID. That is, you can't map a command to more than one handler. For more information on mapping message ranges, see [Handlers for Message-Map Ranges](../vs140/handlers-for-message-map-ranges.md).  
  
 There is no automatic support for message map ranges, so you must place the macro yourself.  
  
## Example  
 [!code[NVC_MFCListView#12](../vs140/codesnippet/CPP/on_command_range_1.cpp)]
  
  
## Requirements  
 **Header:** afxmsg_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_UPDATE_COMMAND_UI_RANGE](../vs140/on_update_command_ui_range.md)   
 [ON_CONTROL_RANGE](../vs140/on_control_range.md)   
 [ON_COMMAND](../vs140/on_command.md)