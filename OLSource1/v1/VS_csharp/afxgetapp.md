---
title: "AfxGetApp"
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
  - "AfxGetApp"
  - "AFXWIN/AfxGetApp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxGetApp function"
ms.assetid: dd869fe6-157c-4317-a624-1e92830d7f83
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxGetApp
The pointer returned by this function can be used to access application information such as the main message-dispatch code or the topmost window.  
  
## Syntax  
  
```  
  
CWinApp* AFXAPI AfxGetApp( );   
```  
  
## Return Value  
 A pointer to the single `CWinApp` object for the application.  
  
## Remarks  
 If this method returns NULL, it might indicate that the application’s main window has not been fully initialized yet. It might also indicate a problem.  
  
## Example  
 [!code[NVC_MFCWindowing#126](../VS_csharp/codesnippet/CPP/afxgetapp_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)