---
title: "AfxWinInit"
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
  - AFXWIN/AfxWinInit
  - AfxWinInit
dev_langs: 
  - C++
helpviewer_keywords: 
  - initializing MFC
  - AfxWinInit function
  - MFC, initializing
ms.assetid: 7ae6d68d-c200-433c-88f7-ece5b7cfbe7d
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxWinInit
This function is called by the MFC-supplied `WinMain` function, as part of the [CWinApp](../vs140/cwinapp-class.md) initialization of a GUI-based application, to initialize MFC.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxWinInit(  
   HINSTANCE hInstance,  
   HINSTANCE hPrevInstance,  
   LPTSTR lpCmdLine,  
   int nCmdShow   
);  
```  
  
#### Parameters  
 `hInstance`  
 The handle of the currently running module.  
  
 *hPrevInstance*  
 A handle to a previous instance of the application. For a Win32-based application, this parameter is always **NULL**.  
  
 `lpCmdLine`  
 Points to a null-terminated string specifying the command line for the application.  
  
 `nCmdShow`  
 Specifies how the main window of a GUI application would be shown.  
  
## Remarks  
 For a console application, which does not use the MFC-supplied `WinMain` function, you must call `AfxWinInit` directly to initialize MFC.  
  
 If you call `AfxWinInit` yourself, you should declare an instance of a `CWinApp` class. For a console application, you might choose not to derive your own class from `CWinApp` and instead use an instance of `CWinApp` directly. This technique is appropriate if you decide to leave all functionality for your application in your implementation of **main**.  
  
> [!NOTE]
>  When it creates an activation context for an assembly, MFC uses a manifest resource provided by the user module. The activation context is created in `AfxWinInit`. For more information, see [Support for Activation Contexts in the MFC Module State](../vs140/support-for-activation-contexts-in-the-mfc-module-state.md).  
  
## Example  
 [!code[NVC_MFC_AfxWinInit#1](../vs140/codesnippet/CPP/afxwininit_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [CWinApp: The Application Class](../vs140/cwinapp--the-application-class.md)   
 [main: Program Startup](../vs140/main--program-startup.md)   
 [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559)