---
title: "CWinApp::CWinApp"
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
  - "CWinApp.CWinApp"
  - "CWinApp::CWinApp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, constructors"
ms.assetid: c0d716b3-5ea9-43ce-8398-ababcaed7d49
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::CWinApp
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and passes <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to be stored as the application name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A null-terminated string that contains the application name that Windows uses. If this argument is not supplied or is **NULL**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses the resource string **AFX_IDS_APP_TITLE** or the filename of the executable file.  
  
## Remarks  
 You should construct one global object of your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived class. You can have only one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object in your application. The constructor stores a pointer to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object so that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can call the object's member functions to initialize and run the application.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)