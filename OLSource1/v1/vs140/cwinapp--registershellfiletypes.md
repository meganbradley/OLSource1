---
title: "CWinApp::RegisterShellFileTypes"
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
  - "CWinApp::RegisterShellFileTypes"
  - "CWinApp.RegisterShellFileTypes"
  - "RegisterShellFileTypes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, initialization"
  - "RegisterShellFileTypes method"
  - "registering file types"
  - "Shell, registering file types"
ms.assetid: 483950ad-959c-4c5c-84e7-a1123fb81e71
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::RegisterShellFileTypes
Call this member function to register all of your application's document types with the Windows File Manager.  
  
## Syntax  
  
```  
void RegisterShellFileTypes(  
   BOOL bCompat = FALSE   
);  
```  
  
#### Parameters  
 [in] `bCompat`  
 `TRUE` adds registration entries for shell commands Print and Print To, allowing a user to print files directly from the shell, or by dragging the file to a printer object. It also adds a DefaultIcon key. By default, this parameter is `FALSE` for backward compatibility.  
  
## Remarks  
 This allows the user to open a data file created by your application by double-clicking it from within File Manager. Call `RegisterShellFileTypes` after you call [AddDocTemplate](../vs140/cwinapp--adddoctemplate.md) for each of the document templates in your application. Also call the [EnableShellOpen](../vs140/cwinapp--enableshellopen.md) member function when you call `RegisterShellFileTypes`.  
  
 `RegisterShellFileTypes` iterates through the list of [CDocTemplate](../vs140/cdoctemplate-class.md) objects that the application maintains and, for each document template, adds entries to the registration database that Windows maintains for file associations. File Manager uses these entries to open a data file when the user double-clicks it. This eliminates the need to ship a .REG file with your application.  
  
> [!NOTE]
>  `RegisterShellFileTypes` only works if the user runs the program with administrator rights. If the program does not have administrator rights, it cannot alter registry keys.  
  
 If the registration database already associates a given filename extension with another file type, no new association is created. See the `CDocTemplate` class for the format of strings necessary to register this information.  
  
## Requirements  
 **Header**: afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [CWinApp::EnableShellOpen](../vs140/cwinapp--enableshellopen.md)   
 [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md)