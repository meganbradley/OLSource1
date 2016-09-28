---
title: "CWinApp::OnFileOpen"
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
  - "OnFileOpen"
  - "CWinApp.OnFileOpen"
  - "CWinApp::OnFileOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "commands [C++], to open files"
  - "CWinApp class, command handlers"
  - "OnFileOpen method"
  - "File open command"
ms.assetid: eb02fa35-0c0a-40e0-92c9-396706d76cb4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::OnFileOpen
Implements the `ID_FILE_OPEN` command.  
  
## Syntax  
  
```  
  
afx_msg void OnFileOpen( );  
```  
  
## Remarks  
 You must add an `ON_COMMAND( ID_FILE_OPEN, OnFileOpen )` statement to your `CWinApp` class message map to enable this member function. If enabled, this function handles execution of the File Open command.  
  
 For information on default behavior and guidance on how to override this member function, see [Technical Note 22](../vs140/tn022--standard-commands-implementation.md).  
  
## Example  
 [!code[NVC_MFCWindowing#49](../vs140/codesnippet/CPP/cwinapp--onfileopen_1.cpp)]  
  
 [!code[NVC_MFCWindowing#50](../vs140/codesnippet/CPP/cwinapp--onfileopen_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnFileNew](../vs140/cwinapp--onfilenew.md)