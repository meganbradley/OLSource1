---
title: "CWinApp::ExitInstance"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWinApp::ExitInstance
  - CWinApp.ExitInstance
dev_langs: 
  - C++
helpviewer_keywords: 
  - exiting applications
  - CWinApp class, overridables
  - ExitInstance method
ms.assetid: b4ddbbee-88eb-41cf-91b5-03cf5791d747
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::ExitInstance
Called by the framework from within the **Run** member function to exit this instance of the application.  
  
## Syntax  
  
```  
  
virtual int ExitInstance( );  
```  
  
## Return Value  
 The application's exit code; 0 indicates no errors, and values greater than 0 indicate an error. This value is used as the return value from `WinMain`.  
  
## Remarks  
 Do not call this member function from anywhere but within the **Run** member function.  
  
 The default implementation of this function writes framework options to the application's .INI file. Override this function to clean up when your application terminates.  
  
## Example  
 [!code[NVC_MFCWindowing#39](../vs140/codesnippet/CPP/cwinapp--exitinstance_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::Run](../vs140/cwinapp--run.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)