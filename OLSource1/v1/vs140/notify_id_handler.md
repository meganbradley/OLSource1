---
title: "NOTIFY_ID_HANDLER"
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
  - "NOTIFY_ID_HANDLER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NOTIFY_ID_HANDLER macro"
ms.assetid: 1fd8bd36-c368-4d69-8743-15e9f12b0928
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NOTIFY_ID_HANDLER
Similar to [NOTIFY_HANDLER](../vs140/notify_handler.md), but maps a [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) message based only on the control identifier.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The identifier of the control sending the message.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The name of the message-handler function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [NOTIFY_CODE_HANDLER](../vs140/notify_code_handler.md)   
 [NOTIFY_RANGE_HANDLER](../vs140/notify_range_handler.md)   
 [COMMAND_ID_HANDLER](../vs140/command_id_handler.md)   
 [MESSAGE_HANDLER](../vs140/message_handler.md)