---
title: "DHTMLEDITING_CMD_ENTRY_FUNC_TYPE"
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
  - AFXHTML/DHTMLEDITING_CMD_ENTRY_FUNC_TYPE
  - DHTMLEDITING_CMD_ENTRY_FUNC_TYPE
dev_langs: 
  - C++
helpviewer_keywords: 
  - DHTMLEDITING_CMD_ENTRY_FUNC_TYPE macro
ms.assetid: 02a59d60-ddab-459e-b4ca-9650f8d2fc32
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DHTMLEDITING_CMD_ENTRY_FUNC_TYPE
Maps a command ID to an HTML editing command, message handler, and user interface element.  
  
## Syntax  
  
```  
  
DHTMLEDITING_CMD_ENTRY_FUNC_TYPE(  
cmdID  
,   
dhtmlcmdID  
,   
member_func_name  
,   
elemType  
)  
  
```  
  
#### Parameters  
 `cmdID`  
 The command ID (such as **ID_EDIT_COPY**).  
  
 `dhtmlcmdID`  
 The HTML editing command to which `cmdID` maps (such as **IDM_COPY**).  
  
 `member_func_name`  
 The name of the message-handler function to which the command is mapped.  
  
 `elemType`  
 The user interface element type; one of **AFX_UI_ELEMTYPE_NORMAL**, **AFX_UI_ELEMTYPE_CHECKBOX**, or **AFX_UI_ELEMTYPE_RADIO**.  
  
## Example  
 See [HTMLEdit Sample](../vs140/visual-c---samples.md).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DHTML Editing Command Maps](../vs140/dhtml-editing-command-maps.md)   
 [DHTMLEDITING_CMD_ENTRY](../vs140/dhtmlediting_cmd_entry.md)   
 [DHTMLEDITING_CMD_ENTRY_FUNC](../vs140/dhtmlediting_cmd_entry_func.md)   
 [DHTMLEDITING_CMD_ENTRY_TYPE](../vs140/dhtmlediting_cmd_entry_type.md)