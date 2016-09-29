---
title: "CMFCToolBar::IsBasicCommand"
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
  - "CMFCToolBar::IsBasicCommand"
  - "CMFCToolBar.IsBasicCommand"
  - "IsBasicCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsBasicCommand method"
ms.assetid: 84ad9cc1-105a-4a4a-ac92-1ff819aeb623
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsBasicCommand
Determines whether a command is on the list of basic commands.  
  
## Syntax  
  
```  
static BOOL IsBasicCommand(  
   UINT uiCmd   
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 Specifies the command to check.  
  
## Return Value  
 `TRUE` if the specified command belongs to the list of basic commands; otherwise `FALSE`.  
  
## Remarks  
 This static method determines whether the command specified by `uiCmd` belongs to the global list of basic commands. You can change the list of basic commands by calling [CMFCToolBar::AddBasicCommand](../vs140/cmfctoolbar--addbasiccommand.md) or [CMFCToolBar::SetBasicCommands](../vs140/cmfctoolbar--setbasiccommands.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)