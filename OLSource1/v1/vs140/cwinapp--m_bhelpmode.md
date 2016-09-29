---
title: "CWinApp::m_bHelpMode"
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
  - "m_bHelpMode"
  - "CWinApp.m_bHelpMode"
  - "CWinApp::m_bHelpMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bHelpMode"
  - "CWinApp class, data members"
ms.assetid: cfa7a8f5-fcda-40ce-84e4-4ae6eb95e0b1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_bHelpMode
**TRUE** if the application is in Help context mode (conventionally invoked with SHIFT + F1); otherwise **FALSE**.  
  
## Syntax  
  
```  
  
BOOL m_bHelpMode;  
  
```  
  
## Remarks  
 In Help context mode, the cursor becomes a question mark and the user can move it about the screen. Examine this flag if you want to implement special handling when in the Help mode. `m_bHelpMode` is a public variable of type **BOOL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)