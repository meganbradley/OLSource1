---
title: "AfxOleInitModule"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AfxOleInitModule
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxOleInitModule function
ms.assetid: c19bf8ed-f398-4cd0-b23f-6ef379485403
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxOleInitModule
For OLE support from a regular DLL that is dynamically linked to MFC, call this function in your regular DLL's `CWinApp::InitInstance` function to initialize the MFC OLE DLL.  
  
## Syntax  
  
```  
  
void AFXAPI AfxOleInitModule( );  
```  
  
## Remarks  
 The MFC OLE DLL is an extension DLL; in order for an extension DLL to get wired into a **CDynLinkLibrary** chain, it must create a **CDynLinkLibrary** object in the context of every module that will be using it. `AfxOleInitModule` creates the **CDynLinkLibrary** object in your regular DLL's context so that it gets wired into the **CDynLinkLibrary** object chain of the regular DLL.  
  
 If you are building an OLE control and are using `COleControlModule`, you should not call **AfxOleInitModule** because the `InitInstance` member function for `COleControlModule` calls `AfxOleInitModule`.  
  
## Requirements  
 **Header**: <afxdll_.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxMessageBox](../vs140/afxmessagebox.md)