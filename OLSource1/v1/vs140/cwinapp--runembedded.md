---
title: "CWinApp::RunEmbedded"
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
  - "RunEmbedded"
  - "CWinApp::RunEmbedded"
  - "CWinApp.RunEmbedded"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RunEmbedded method"
  - "CWinApp class, operations"
  - "embedded applications, running"
  - "applications [MFC], running"
ms.assetid: af9dedcb-a6e9-4f58-9c6e-394a5412370b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::RunEmbedded
Call this function to determine whether the "**/Embedding**" or "**-Embedding**" option is present, which indicates whether the server application was launched by a client application.  
  
## Syntax  
  
```  
  
BOOL RunEmbedded( );  
```  
  
## Return Value  
 Nonzero if the option was found; otherwise 0.  
  
## Remarks  
 If present, the option is removed from the command line. For more information on embedding, see the article [Servers: Implementing a Server](../vs140/servers--implementing-a-server.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::RunAutomated](../vs140/cwinapp--runautomated.md)