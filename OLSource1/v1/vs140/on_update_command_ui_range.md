---
title: "ON_UPDATE_COMMAND_UI_RANGE"
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
  - "ON_UPDATE_COMMAND_UI_RANGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_UPDATE_COMMAND_UI_RANGE macro"
  - "message mapping macros"
ms.assetid: b7105bf1-44ad-4b00-b947-31478f964729
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_UPDATE_COMMAND_UI_RANGE
Maps a contiguous range of command IDs to a single update message handler function.  
  
## Syntax  
  
```  
  
ON_UPDATE_COMMAND_UI_RANGE(  
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
 The name of the update message-handler function to which the commands are mapped.  
  
## Remarks  
 Update message handlers update the state of menu items and toolbar buttons associated with the command. The range of IDs starts with *id1* and ends with `id2`.  
  
 There is no automatic support for message map ranges, so you must place the macro yourself.  
  
## Requirements  
 **Header:** afxmsg_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_COMMAND_RANGE](../vs140/on_command_range.md)   
 [ON_CONTROL_RANGE](../vs140/on_control_range.md)