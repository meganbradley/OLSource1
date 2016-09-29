---
title: "Application Information and Management"
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
  - "vc.mfc.macros"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "applications [MFC], managing"
ms.assetid: b72f4154-24db-4e75-bca3-6873e2459c15
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Application Information and Management
When you write an application, you create a single [CWinApp](../VS_csharp/cwinapp-class.md)-derived object. At times, you may want to get information about this object from outside the `CWinApp`-derived object.  
  
 The Microsoft Foundation Class Library provides the following global functions to help you accomplish these tasks:  
  
### Application Information and Management Functions  
  
|||  
|-|-|  
|[AfxBeginThread](../VS_csharp/afxbeginthread.md)|Creates a new thread.|  
|[AfxEndThread](../VS_csharp/afxendthread.md)|Terminates the current thread.|  
|[AfxFreeLibrary](../VS_csharp/afxfreelibrary.md)|Decrements the reference count of the loaded dynamic-link library (DLL) module; when the reference count reaches zero, the module is unmapped.|  
|[AfxGetApp](../VS_csharp/afxgetapp.md)|Returns a pointer to the application's single `CWinApp` object.|  
|[AfxGetAppName](../VS_csharp/afxgetappname.md)|Returns a string that contains the application's name.|  
|[AfxGetInstanceHandle](../VS_csharp/afxgetinstancehandle.md)|Returns an `HINSTANCE` representing this instance of the application.|  
|[AfxGetMainWnd](../VS_csharp/afxgetmainwnd.md)|Returns a pointer to the current "main" window of a non-OLE application, or the in-place frame window of a server application.|  
|[AfxGetPerUserRegistration](../VS_csharp/afxgetperuserregistration.md)|Use this function to determine whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.|  
|[AfxGetResourceHandle](../VS_csharp/afxgetresourcehandle.md)|Returns an `HINSTANCE` to the source of the application's default resources. Use this to access the application's resources directly.|  
|[AfxGetThread](../VS_csharp/afxgetthread.md)|Retrieves a pointer to the current [CWinThread](../VS_csharp/cwinthread-class.md) object.|  
|[AfxInitRichEdit](../VS_csharp/afxinitrichedit.md)|Initializes the version 1.0 rich edit control for the application.|  
|[AfxInitRichEdit2](../VS_csharp/afxinitrichedit2.md)|Initializes the version 2.0 and later rich edit control for the application.|  
|[AfxLoadLibrary](../VS_csharp/afxloadlibrary.md)|Maps a DLL module and returns a handle that can be used to obtain the address of a DLL function.|  
|[AfxRegisterClass](../VS_csharp/afxregisterclass.md)|Registers a window class in a DLL that uses MFC.|  
|[AfxRegisterWndClass](../VS_csharp/afxregisterwndclass.md)|Registers a Windows window class to supplement those registered automatically by MFC.|  
|[AfxSetPerUserRegistration](../VS_csharp/afxsetperuserregistration.md)|Sets whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.|  
|[AfxSetResourceHandle](../VS_csharp/afxsetresourcehandle.md)|Sets the `HINSTANCE` handle where the default resources of the application are loaded.|  
|[AfxSocketInit](../VS_csharp/afxsocketinit.md)|Called in a `CWinApp::InitInstance` override to initialize Windows Sockets.|  
|[AfxWinInit](../VS_csharp/afxwininit.md)|Called by the MFC-supplied `WinMain` function, as part of the [CWinApp](../VS_csharp/cwinapp-class.md) initialization of a GUI-based application, to initialize MFC. Must be called directly for console applications that use MFC.|  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [CWinApp Class](../VS_csharp/cwinapp-class.md)