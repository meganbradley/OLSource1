---
title: "ICommandSource::AddCommandRangeUIHandler"
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
  - "AddCommandRangeUIHandler"
  - "ICommandSource::AddCommandRangeUIHandler"
  - "ICommandSource.AddCommandRangeUIHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCommandRangeUIHandler method"
ms.assetid: b8560b1b-67d4-45a4-b5ba-ae1ea5d98bfd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandSource::AddCommandRangeUIHandler
Adds a group of user interface command message handlers to a command source object.  
  
## Syntax  
  
```  
void AddCommandRangeUIHandler(   
   unsigned int cmdIDMin,   
   unsigned int cmdIDMax,   
   CommandUIHandler^ cmdUIHandler   
);  
```  
  
#### Parameters  
 `cmdIDMin`  
 The beginning index of the command ID range.  
  
 `cmdIDMax`  
 The ending index of the command ID range.  
  
 `cmdHandler`  
 A handle to the message handler method to which the commands are mapped.  
  
## Remarks  
 This method maps a contiguous range of command IDs to a single user interface command message handler and adds it to the command source object. This is used for handling a group of related buttons with one method.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandSource Interface](../vs140/icommandsource-interface.md)   
 [ICommandSource::RemoveCommandRangeUIHandler](../vs140/icommandsource--removecommandrangeuihandler.md)