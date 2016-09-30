---
title: "CWinApp::m_pszAppName"
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
  - "m_pszAppName"
  - "CWinApp.m_pszAppName"
  - "CWinApp::m_pszAppName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pszAppName"
  - "CWinApp class, data members"
ms.assetid: f0f7ff5c-176a-4c8a-9fb8-889fce314718
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_pszAppName
Specifies the name of the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The application name can come from the parameter passed to the [CWinApp](../vs140/cwinapp--cwinapp.md) constructor, or, if not specified, to the resource string with the ID of **AFX_IDS_APP_TITLE**. If the application name is not found in the resource, it comes from the program's .EXE filename.  
  
 Returned by the global function [AfxGetAppName](../vs140/afxgetappname.md). <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a public variable of type **const char\***.  
  
> [!NOTE]
>  If you assign a value to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, it must be dynamically allocated on the heap. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> destructor calls **free**( ) with this pointer. You many want to use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>( ) run-time library function to do the allocating. Also, free the memory associated with the current pointer before assigning a new value. For example:  
  
 [!code[NVC_MFCWindowing#57](../vs140/codesnippet/CPP/cwinapp--m_pszappname_1.cpp)]  
  
## Example  
 [!code[NVC_MFCWindowing#65](../vs140/codesnippet/CPP/cwinapp--m_pszappname_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)