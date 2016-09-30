---
title: "CWinApp::m_pszExeName"
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
  - "CWinApp::m_pszExeName"
  - "CWinApp.m_pszExeName"
  - "m_pszExeName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pszExeName"
  - "CWinApp class, data members"
ms.assetid: bc04e7c3-97dc-444e-bfa3-5fae75ba76e4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_pszExeName
Contains the name of the application's executable file without an extension.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Unlike [m_pszAppName](../vs140/cwinapp--m_pszappname.md), this name cannot contain blanks. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a public variable of type **const char\***.  
  
> [!NOTE]
>  If you assign a value to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, it must be dynamically allocated on the heap. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> destructor calls **free**( ) with this pointer. You many want to use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>( ) run-time library function to do the allocating. Also, free the memory associated with the current pointer before assigning a new value. For example:  
  
 [!code[NVC_MFCWindowing#58](../vs140/codesnippet/CPP/cwinapp--m_pszexename_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)