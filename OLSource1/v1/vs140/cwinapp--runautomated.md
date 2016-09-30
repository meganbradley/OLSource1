---
title: "CWinApp::RunAutomated"
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
  - "CWinApp.RunAutomated"
  - "RunAutomated"
  - "CWinApp::RunAutomated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "applications [MFC], running"
  - "RunAutomated method"
ms.assetid: 5405b99d-d8d9-47c1-ac8f-21af9d11bd1d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::RunAutomated
Call this function to determine whether the "**/Automation**" or "**-Automation**" option is present, which indicates whether the server application was launched by a client application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the option was found; otherwise 0.  
  
## Remarks  
 If present, the option is removed from the command line. For more information on OLE Automation, see the article [Automation Servers](../vs140/automation-servers.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::RunEmbedded](../vs140/cwinapp--runembedded.md)