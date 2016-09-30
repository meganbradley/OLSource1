---
title: "ICommandSource::SendCommand"
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
  - "ICommandSource::SendCommand"
  - "SendCommand"
  - "ICommandSource.SendCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SendCommand method"
ms.assetid: be347ba3-a9d7-48a4-9020-86d0be0f8956
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandSource::SendCommand
Sends a message and waits for it to be processed before returning.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID of the message to be sent.  
  
## Remarks  
 This method synchronously sends the message mapped to the ID specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. It calls [CWnd::SendMessage](../vs140/cwnd--sendmessage.md) to place the message in the window's message queue and waits until that window procedure has processed the message before returning.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandSource Interface](../vs140/icommandsource-interface.md)   
 [ICommandSource::PostCommand](../vs140/icommandsource--postcommand.md)