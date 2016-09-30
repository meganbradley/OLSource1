---
title: "COMMAND_RANGE_CODE_HANDLER"
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
  - "COMMAND_RANGE_CODE_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COMMAND_RANGE_CODE_HANDLER macro"
ms.assetid: 67b57ab4-ed20-4d49-b58b-7d978dcc580a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COMMAND_RANGE_CODE_HANDLER
Similar to [COMMAND_RANGE_HANDLER](../vs140/command_range_handler.md), but maps [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) messages with a specific notification code from a range of controls to a single handler function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Marks the beginning of a contiguous range of control identifiers.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Marks the end of a contiguous range of control identifiers.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The notification code.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The name of the message-handler function.  
  
## Remarks  
 This range is based on the identifier of the menu item, control, or accelerator sending the message.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [COMMAND_ID_HANDLER](../vs140/command_id_handler.md)   
 [COMMAND_CODE_HANDLER](../vs140/command_code_handler.md)   
 [MESSAGE_RANGE_HANDLER](../vs140/message_range_handler.md)   
 [NOTIFY_RANGE_HANDLER](../vs140/notify_range_handler.md)