---
title: "CMFCToolBar::IsCommandRarelyUsed"
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
  - "CMFCToolBar::IsCommandRarelyUsed"
  - "CMFCToolBar.IsCommandRarelyUsed"
  - "IsCommandRarelyUsed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsCommandRarelyUsed method"
ms.assetid: eb1ffd32-1956-461d-a7d9-0aa82eb1a4e3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsCommandRarelyUsed
Determines whether a command is rarely used.  
  
## Syntax  
  
```  
static BOOL IsCommandRarelyUsed(  
   UINT uiCmd   
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 Specifies the command to check.  
  
## Return Value  
 `TRUE` if the specified command is rarely used; otherwise `FALSE`.  
  
## Remarks  
 The `IsCommandRarelyUsed` method returns `FALSE` when one or more of the following conditions occur:  
  
-   The specified command belongs to the list of basic commands  
  
-   The specified command is one of the standard commands  
  
-   The framework is in customization mode  
  
-   The list of basic commands is empty  
  
-   More than 20% of command calls are calls to the specified command.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)