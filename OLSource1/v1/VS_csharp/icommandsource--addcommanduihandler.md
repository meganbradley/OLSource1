---
title: "ICommandSource::AddCommandUIHandler"
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
  - "AddCommandUIHandler"
  - "ICommandSource.AddCommandUIHandler"
  - "ICommandSource::AddCommandUIHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCommandUIHandler method"
ms.assetid: f0c9523b-fc75-4721-bc7b-8c6e7e00539a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandSource::AddCommandUIHandler
Adds a user interface command message handler to a command source object.  
  
## Syntax  
  
```  
void AddCommandUIHandler(   
   unsigned int cmdID,   
   CommandUIHandler^ cmdUIHandler   
);  
```  
  
#### Parameters  
 `cmdID`  
 The command ID.  
  
 `cmdUIHandler`  
 A handle to the user interface command message handler method.  
  
## Remarks  
 This method adds the user interface command message handler `cmdHandler` to the command source object and maps the handler to `cmdID`.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandSource Interface](../VS_csharp/icommandsource-interface.md)   
 [ICommandSource::RemoveCommandUIHandler](../VS_csharp/icommandsource--removecommanduihandler.md)