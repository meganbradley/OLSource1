---
title: "ICommandSource::RemoveCommandRangeUIHandler"
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
  - "ICommandSource::RemoveCommandRangeUIHandler"
  - "RemoveCommandRangeUIHandler"
  - "ICommandSource.RemoveCommandRangeUIHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveCommandRangeUIHandler method"
ms.assetid: c6d3e36c-f1fa-4b0a-bedf-1a64fd19f8a5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandSource::RemoveCommandRangeUIHandler
Removes a group of user interface command message handlers from a command source object.  
  
## Syntax  
  
```  
void RemoveCommandRangeUIHandler(  
   unsigned int cmdIDMin,  
   unsigned int cmdIDMax  
);  
```  
  
#### Parameters  
 `cmdIDMin`  
 The beginning index of the command ID range.  
  
 `cmdIDMax`  
 The ending index of the command ID range.  
  
## Remarks  
 This method removes a group of user interface command message handlers, mapped to the command IDs specifed by `cmdIDMin` and `cmdIDMax`, from the command source object.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandSource Interface](../VS_csharp/icommandsource-interface.md)   
 [ICommandSource::AddCommandRangeUIHandler](../VS_csharp/icommandsource--addcommandrangeuihandler.md)