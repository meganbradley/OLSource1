---
title: "CWinApp::GetApplicationRestartFlags"
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
  - "GetApplicationRestartFlags"
  - "CWinApp.GetApplicationRestartFlags"
  - "CWinApp::GetApplicationRestartFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetApplicationRestartFlags method"
ms.assetid: 83661f1e-d295-44a8-8ae1-b5d45d1e62cc
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::GetApplicationRestartFlags
Returns the flags for the restart manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The flags for the restart manager. The default implementation returns 0.  
  
## Remarks  
 The flags for the restart manager have no effect with the default implementation. They are provided for future use.  
  
 You set the flags when you register the application with the restart manager by using [CWinApp::RegisterWithRestartManager](../vs140/cwinapp--registerwithrestartmanager.md).  
  
 The possible values for the restart manager flags are as follows:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::RegisterWithRestartManager](../vs140/cwinapp--registerwithrestartmanager.md)