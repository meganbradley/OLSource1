---
title: "ICommandSource::RemoveCommandHandler"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - RemoveCommandHandler
  - ICommandSource::RemoveCommandHandler
  - ICommandSource.RemoveCommandHandler
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveCommandHandler method
ms.assetid: 2d0c6aba-57cf-4b75-b5a7-3902ab0fbcbd
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ICommandSource::RemoveCommandHandler
Removes a command handler from a command source object.  
  
## Syntax  
  
```  
void RemoveCommandHandler(  
   unsigned int cmdID  
);  
```  
  
#### Parameters  
 `cmdID`  
 The command ID.  
  
## Remarks  
 This method removes the command handler mapped to `cmdID` from the command source object.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandSource Interface](../vs140/icommandsource-interface.md)   
 [ICommandSource::AddCommandHandler](../vs140/icommandsource--addcommandhandler.md)