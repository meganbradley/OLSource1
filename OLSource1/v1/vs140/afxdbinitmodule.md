---
title: "AfxDbInitModule"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxDbInitModule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxDbInitModule function"
ms.assetid: a0c95dcd-9679-426a-994a-5908e9dc0ee1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxDbInitModule
For MFC database (or DAO) support from a regular DLL that is dynamically linked to MFC, add a call to this function in your regular DLL's **CWinApp::InitInstance** function to initialize the MFC database DLL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Make sure this call occurs before any base-class call or any added code which accesses the MFC database DLL. The MFC database DLL is an extension DLL; in order for an extension DLL to get wired into a **CDynLinkLibrary** chain, it must create a **CDynLinkLibrary** object in the context of every module that will be using it. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> creates the **CDynLinkLibrary** object in your regular DLL's context so that it gets wired into the **CDynLinkLibrary** object chain of the regular DLL.  
  
## Requirements  
 **Header:** \<afxdll_.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)