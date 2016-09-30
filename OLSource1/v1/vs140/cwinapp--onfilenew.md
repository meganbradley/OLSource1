---
title: "CWinApp::OnFileNew"
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
  - "OnFileNew"
  - "CWinApp::OnFileNew"
  - "CWinApp.OnFileNew"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "New File command"
  - "CWinApp class, command handlers"
  - "OnFileNew method"
ms.assetid: ddf79290-2ef7-4715-a1b9-256d3a52e741
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::OnFileNew
Implements the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You must add an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement to your <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class message map to enable this member function. If enabled, this function handles execution of the File New command.  
  
 See [Technical Note 22](../vs140/tn022--standard-commands-implementation.md) for information on default behavior and guidance on how to override this member function.  
  
## Example  
 [!code[NVC_MFCWindowing#49](../vs140/codesnippet/CPP/cwinapp--onfilenew_1.cpp)]  
  
 [!code[NVC_MFCWindowing#50](../vs140/codesnippet/CPP/cwinapp--onfilenew_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnFileOpen](../vs140/cwinapp--onfileopen.md)