---
title: "CWinApp::m_pszProfileName"
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
  - "CWinApp::m_pszProfileName"
  - "CWinApp.m_pszProfileName"
  - "m_pszProfileName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pszProfileName"
  - "CWinApp class, data members"
ms.assetid: 53f35c1f-b7f9-45f2-a8d9-556b4a1b9f91
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_pszProfileName
Contains the name of the application's .INI file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a public variable of type **const char\***.  
  
> [!NOTE]
>  If you assign a value to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, it must be dynamically allocated on the heap. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> destructor calls **free**( ) with this pointer. You many want to use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>( ) run-time library function to do the allocating. Also, free the memory associated with the current pointer before assigning a new value. For example:  
  
 [!code[NVC_MFCWindowing#60](../vs140/codesnippet/CPP/cwinapp--m_pszprofilename_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::GetProfileString](../vs140/cwinapp--getprofilestring.md)   
 [CWinApp::GetProfileInt](../vs140/cwinapp--getprofileint.md)   
 [CWinApp::WriteProfileInt](../vs140/cwinapp--writeprofileint.md)   
 [CWinApp::WriteProfileString](../vs140/cwinapp--writeprofilestring.md)