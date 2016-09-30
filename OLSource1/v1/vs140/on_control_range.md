---
title: "ON_CONTROL_RANGE"
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
  - "ON_CONTROL_RANGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_CONTROL_RANGE macro"
  - "message mapping macros"
ms.assetid: 46f0e1bb-569b-4b8b-9b80-89701d1cd7fd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_CONTROL_RANGE
Use this macro to map a contiguous range of control IDs to a single message handler function for a specified Windows notification message, such as **BN_CLICKED**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The notification code to which your handler is responding.  
  
 *id1*  
 Command ID at the beginning of a contiguous range of control IDs.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Command ID at the end of a contiguous range of control IDs.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the message-handler function to which the controls are mapped.  
  
## Remarks  
 The range of IDs starts with *id1* and ends with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The handler is called for the specified notification coming from any of the mapped controls.  
  
 There is no automatic support for message map ranges, so you must place the macro yourself.  
  
 For more information on implementing handler functions for a range of control IDs, refer to [Handlers for Message-Map Ranges](../vs140/handlers-for-message-map-ranges.md).  
  
## Requirements  
 **Header:** afxmsg_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_UPDATE_COMMAND_UI_RANGE](../vs140/on_update_command_ui_range.md)   
 [ON_COMMAND_RANGE](../vs140/on_command_range.md)