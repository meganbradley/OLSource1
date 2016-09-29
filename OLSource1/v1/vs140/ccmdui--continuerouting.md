---
title: "CCmdUI::ContinueRouting"
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
  - "CCmdUI::ContinueRouting"
  - "ON_COMMAND_EX"
  - "CCmdUI.ContinueRouting"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_COMMAND_EX"
  - "CCmdUI class, operations"
  - "ContinueRouting method"
ms.assetid: a29701f7-55e3-4d55-a0b4-e8aa44584626
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdUI::ContinueRouting
Call this member function to tell the command-routing mechanism to continue routing the current message down the chain of handlers.  
  
## Syntax  
  
```  
  
void ContinueRouting( );  
```  
  
## Remarks  
 This is an advanced member function that should be used in conjunction with an `ON_COMMAND_EX` handler that returns **FALSE**. For more information, see [Technical Note 6](../vs140/tn006--message-maps.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdUI Class](../vs140/ccmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)