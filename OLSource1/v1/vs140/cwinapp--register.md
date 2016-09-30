---
title: "CWinApp::Register"
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
  - "CWinApp.Register"
  - "CWinApp::Register"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Register method"
ms.assetid: 624d6071-4fef-44cf-b53a-bf8cdbfccf00
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::Register
Performs any registration tasks not handled by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero on success; otherwise 0.  
  
## Remarks  
 The default implementation simply returns TRUE. Override this function to provide any customized registration steps.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::RegisterShellFileTypes](../vs140/cwinapp--registershellfiletypes.md)