---
title: "CWinApp::OnFilePrintSetup"
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
  - "CWinApp.OnFilePrintSetup"
  - "CWinApp::OnFilePrintSetup"
  - "OnFilePrintSetup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, command handlers"
  - "OnFilePrintSetup method"
  - "File print setup"
ms.assetid: 1a8acb9c-97d7-4887-8fac-8c497bd52085
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::OnFilePrintSetup
Implements the **ID_FILE_PRINT_SETUP** command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You must add an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement to your <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class message map to enable this member function. If enabled, this function handles execution of the File Print command.  
  
 For information on default behavior and guidance on how to override this member function, see [Technical Note 22](../vs140/tn022--standard-commands-implementation.md).  
  
## Example  
 [!code[NVC_MFCWindowing#49](../vs140/codesnippet/CPP/cwinapp--onfileprintsetup_1.cpp)]  
  
 [!code[NVC_MFCWindowing#50](../vs140/codesnippet/CPP/cwinapp--onfileprintsetup_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnFileNew](../vs140/cwinapp--onfilenew.md)