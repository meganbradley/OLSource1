---
title: "DHTMLEDITING_CMD_ENTRY_TYPE"
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
  - "AFXHTML/DHTMLEDITING_CMD_ENTRY_TYPE"
  - "DHTMLEDITING_CMD_ENTRY_TYPE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTMLEDITING_CMD_ENTRY_TYPE macro"
ms.assetid: 140fa0e8-3019-472f-9acf-8015ca76d7ce
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DHTMLEDITING_CMD_ENTRY_TYPE
Maps a command ID to an HTML editing command and user interface element.  
  
## Syntax  
  
```  
  
DHTMLEDITING_CMD_ENTRY_TYPE(  
cmdID  
,   
dhtmlcmdID  
,   
elemType  
)  
  
```  
  
#### Parameters  
 `cmdID`  
 The command ID (such as **ID_EDIT_COPY**).  
  
 `dhtmlcmdID`  
 The HTML editing command to which `cmdID` maps (such as **IDM_COPY**).  
  
 `elemType`  
 The user interface element type; one of **AFX_UI_ELEMTYPE_NORMAL**, **AFX_UI_ELEMTYPE_CHECKBOX**, or **AFX_UI_ELEMTYPE_RADIO**.  
  
## Example  
 See [HTMLEdit Sample](../VS_csharp/visual-c---samples.md).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DHTML Editing Command Maps](../VS_csharp/dhtml-editing-command-maps.md)   
 [DHTMLEDITING_CMD_ENTRY](../VS_csharp/dhtmlediting_cmd_entry.md)   
 [DHTMLEDITING_CMD_ENTRY_FUNC](../VS_csharp/dhtmlediting_cmd_entry_func.md)   
 [DHTMLEDITING_CMD_ENTRY_FUNC_TYPE](../VS_csharp/dhtmlediting_cmd_entry_func_type.md)