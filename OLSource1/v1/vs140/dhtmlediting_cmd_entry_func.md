---
title: "DHTMLEDITING_CMD_ENTRY_FUNC"
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
  - "DHTMLEDITING_CMD_ENTRY_FUNC"
  - "AFXHTML/DHTMLEDITING_CMD_ENTRY_FUNC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTMLEDITING_CMD_ENTRY_FUNC macro"
ms.assetid: a9c086f7-3615-4f2c-ad4b-969efd6b6580
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTMLEDITING_CMD_ENTRY_FUNC
Maps a command ID to an HTML editing command and message handler.  
  
## Syntax  
  
```  
  
DHTMLEDITING_CMD_ENTRY_FUNC(  
cmdID  
,   
dhtmlcmdID  
,   
member_func_name  
)  
  
```  
  
#### Parameters  
 `cmdID`  
 The command ID (such as **ID_EDIT_COPY**).  
  
 `dhtmlcmdID`  
 The HTML editing command to which `cmdID` maps (such as **IDM_COPY**).  
  
 `member_func_name`  
 The name of the message-handler function to which the command is mapped.  
  
## Example  
 See [HTMLEdit Sample](../vs140/visual-c---samples.md).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Editing Command Maps](../vs140/dhtml-editing-command-maps.md)   
 [DHTMLEDITING_CMD_ENTRY](../vs140/dhtmlediting_cmd_entry.md)   
 [DHTMLEDITING_CMD_ENTRY_FUNC_TYPE](../vs140/dhtmlediting_cmd_entry_func_type.md)   
 [DHTMLEDITING_CMD_ENTRY_TYPE](../vs140/dhtmlediting_cmd_entry_type.md)