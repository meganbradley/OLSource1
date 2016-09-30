---
title: "ICommandSource::AddCommandRangeHandler"
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
  - "ICommandSource.AddCommandRangeHandler"
  - "AddCommandRangeHandler"
  - "ICommandSource::AddCommandRangeHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCommandRangeHandler method"
ms.assetid: f86cc4ea-acac-4523-8225-20a7fb182cec
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandSource::AddCommandRangeHandler
Adds a group of command handlers to a command source object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The beginning index of the command ID range.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The ending index of the command ID range.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A handle to the message handler method to which the commands are mapped.  
  
## Remarks  
 This method maps a contiguous range of command IDs to a single message handler and adds it to the command source object. This is used for handling a group of related buttons with one method.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandSource Interface](../vs140/icommandsource-interface.md)   
 [ICommandSource::RemoveCommandRangeHandler](../vs140/icommandsource--removecommandrangehandler.md)