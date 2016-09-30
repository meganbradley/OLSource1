---
title: "AfxGetInstanceHandle"
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
  - "AfxGetInstanceHandle"
  - "AFXWIN/AfxGetInstanceHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxGetInstanceHandle function"
ms.assetid: 3a2c97b9-e65c-4921-8f62-c7045f867732
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxGetInstanceHandle
This function allows you to retrieve the instance handle of the current application.  
  
## Syntax  
  
```  
  
HINSTANCE AFXAPI AfxGetInstanceHandle( );  
```  
  
## Return Value  
 An `HINSTANCE` to the current instance of the application. If called from within a DLL linked with the USRDLL version of MFC, an `HINSTANCE` to the DLL is returned.  
  
## Remarks  
 `AfxGetInstanceHandle` always returns the `HINSTANCE` of your executable file (.EXE) unless it is called from within a DLL linked with the USRDLL version of MFC. In this case, it returns an `HINSTANCE` to the DLL.  
  
## Example  
 [!code[NVC_MFCWindowing#128](../vs140/codesnippet/CPP/afxgetinstancehandle_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxGetResourceHandle](../vs140/afxgetresourcehandle.md)   
 [AfxSetResourceHandle](../vs140/afxsetresourcehandle.md)