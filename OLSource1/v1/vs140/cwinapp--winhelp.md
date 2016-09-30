---
title: "CWinApp::WinHelp"
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
  - "CWinApp::WinHelp"
  - "CWinApp.WinHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "WinHelp method"
ms.assetid: 8cfcb0bc-6b2f-4108-be6e-ce1d38defea0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::WinHelp
Call this member function to invoke the WinHelp application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies additional data. The value used depends on the value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the type of help requested. For a list of possible values and how they affect the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter, see the [WinHelp](http://msdn.microsoft.com/library/windows/desktop/bb762267) Windows function.  
  
## Remarks  
 The framework also calls this function to invoke the WinHelp application.  
  
 The framework will automatically close the WinHelp application when your application terminates.  
  
## Example  
 [!code[NVC_MFCWindowing#53](../vs140/codesnippet/CPP/cwinapp--winhelp_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnContextHelp](../vs140/cwinapp--oncontexthelp.md)   
 [CWinApp::OnHelpUsing](../vs140/cwinapp--onhelpusing.md)   
 [CWinApp::OnHelp](../vs140/cwinapp--onhelp.md)   
 [CWinApp::OnHelpIndex](../vs140/cwinapp--onhelpindex.md)   
 [WinHelp](http://msdn.microsoft.com/library/windows/desktop/bb762267)