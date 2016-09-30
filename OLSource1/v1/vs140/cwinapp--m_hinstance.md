---
title: "CWinApp::m_hInstance"
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
  - "CWinApp::m_hInstance"
  - "CWinApp.m_hInstance"
  - "m_hInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_hInstance"
  - "CWinApp class, data members"
ms.assetid: 7344f586-6956-4c36-9131-af8cced9eb67
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_hInstance
Corresponds to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter passed by Windows to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data member is a handle to the current instance of the application running under Windows. This is returned by the global function [AfxGetInstanceHandle](../vs140/afxgetinstancehandle.md). <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a public variable of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCWindowing#55](../vs140/codesnippet/CPP/cwinapp--m_hinstance_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)