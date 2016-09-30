---
title: "CWinApp::m_pszHelpFilePath"
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
  - "CWinApp::m_pszHelpFilePath"
  - "m_pszHelpFilePath"
  - "CWinApp.m_pszHelpFilePath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pszHelpFilePath"
  - "CWinApp class, data members"
ms.assetid: 75708044-a495-4578-9388-cb3c2e9a4121
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_pszHelpFilePath
Contains the path to the application's Help file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 By default, the framework initializes <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to the name of the application with ".HLP" appended. To change the name of the help file, set <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to point to a string that contains the complete name of the desired help file. A convenient place to do this is in the application's [InitInstance](../vs140/cwinapp--initinstance.md) function. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a public variable of type **const char\***.  
  
> [!NOTE]
>  If you assign a value to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, it must be dynamically allocated on the heap. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> destructor calls **free**( ) with this pointer. You many want to use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>( ) run-time library function to do the allocating. Also, free the memory associated with the current pointer before assigning a new value. For example:  
  
 [!code[NVC_MFCWindowing#59](../vs140/codesnippet/CPP/cwinapp--m_pszhelpfilepath_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)