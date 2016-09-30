---
title: "COccManager::OnEvent"
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
  - "COccManager.OnEvent"
  - "COccManager::OnEvent"
  - "OnEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, overridables"
  - "OnEvent method"
ms.assetid: 273badaf-8de1-4444-a00c-6a262eb7277a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::OnEvent
Called by the framework to handle the specified event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pCmdTarget*  
 A pointer to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object attempting to handle the event  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resource ID of the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The event being handled.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If not **NULL**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> fills in the **pTarget** and **pmf** members of the **AFX_CMDHANDLERINFO** structure instead of dispatching the command. Typically, this parameter should be **NULL**.  
  
## Return Value  
 Nonzero if the event was handled, otherwise zero.  
  
## Remarks  
 Override this function to customize the default event-handling process.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)