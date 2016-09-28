---
title: "ICommandSource::PostCommand"
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
  - "ICommandSource.PostCommand"
  - "ICommandSource::PostCommand"
  - "PostCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PostCommand method"
ms.assetid: b5c721bf-223a-4d3b-bd2d-287ea11dfaca
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandSource::PostCommand
Posts a message without waiting for it to be processed.  
  
## Syntax  
  
```  
void PostCommand(   
   unsigned int command   
);  
```  
  
#### Parameters  
 `command`  
 The command ID of the message to be posted.  
  
## Remarks  
 This method asynchronously posts the message mapped to the ID specified by `command`. It calls [CWnd::PostMessage](../vs140/cwnd--postmessage.md) to place the message in the window's message queue and then returns without waiting for the corresponding window to process the message.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandSource Interface](../vs140/icommandsource-interface.md)   
 [ICommandSource::SendCommand](../vs140/icommandsource--sendcommand.md)