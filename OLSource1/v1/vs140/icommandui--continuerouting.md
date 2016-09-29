---
title: "ICommandUI::ContinueRouting"
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
  - "ContinueRouting"
  - "ICommandUI.ContinueRouting"
  - "ICommandUI::ContinueRouting"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ContinueRouting method"
ms.assetid: 71b59aa5-6c96-4eef-ba85-7f31da1bff1f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandUI::ContinueRouting
Tells the command routing mechanism to continue routing the current message down the chain of handlers.  
  
## Syntax  
  
```  
void ContinueRouting( );  
```  
  
## Remarks  
 This is an advanced member function that should be used in conjunction with an [ON_COMMAND_EX](../vs140/on_command_ex.md) handler that returns `FALSE`. For more information, see Technical Note [TN006: Message Maps](../vs140/tn006--message-maps.md).  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandUI Interface](../vs140/icommandui-interface.md)   
 [ON_COMMAND_EX](../vs140/on_command_ex.md)