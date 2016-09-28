---
title: "CWinApp::m_pDataRecoveryHandler"
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
  - "m_pDataRecoveryHandler"
  - "CWinApp::m_pDataRecoveryHandler"
  - "CWinApp.m_pDataRecoveryHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pDataRecoveryHandler"
  - "CWinApp class, data members"
ms.assetid: a52d6c8e-59cd-46c7-bce9-51b8a2e77713
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_pDataRecoveryHandler
Pointer to the data recovery handler for the application.  
  
## Syntax  
  
```  
CDataRecoveryHandler* m_pDataRecoveryHandler;  
```  
  
## Remarks  
 The data recovery handler of an application monitors open documents and autosaves them. The framework uses the data recovery handler to restore autosaved files when an application restarts after it exits unexpectedly. For more information, see [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)