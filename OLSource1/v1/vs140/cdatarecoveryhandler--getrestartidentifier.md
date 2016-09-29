---
title: "CDataRecoveryHandler::GetRestartIdentifier"
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
  - "CDataRecoveryHandler.GetRestartIdentifier"
  - "CDataRecoveryHandler::GetRestartIdentifier"
  - "GetRestartIdentifier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRestartIdentifier method"
ms.assetid: 2cd60166-8ebd-4943-9364-69eaf05ba73e
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::GetRestartIdentifier
Retrieves the unique restart identifier for the application.  
  
## Syntax  
  
```  
virtual CString GetRestartIdentifier() const;  
```  
  
## Return Value  
 The unique restart identifier.  
  
## Remarks  
 The restart identifier is unique for each execution of the application.  
  
 The `CDataRecoveryHandler` stores information in the registry about the currently open documents. When the restart manager exits an application and restarts it, it supplies the restart identifier to the `CDataRecoveryHandler`. The `CDataRecoveryHandler` uses the restart identifier to retrieve the list of previously open documents. This enables the `CDataRecoveryHandler` to try to find and restore autosaved files.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::SetRestartIdentifier](../vs140/cdatarecoveryhandler--setrestartidentifier.md)