---
title: "AfxOleInit"
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
  - "AFXDISP/AfxOleInit"
  - "AfxOleInit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleInit function"
  - "OLE initialization"
ms.assetid: 1f423a68-55fe-4685-9588-a31f370dfd4a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleInit
Initializes OLE support for the application.  
  
## Syntax  
  
```  
  
BOOL AFXAPI AfxOleInit( );  
```  
  
## Return Value  
 Nonzero if successful; 0 if initialization fails, possibly because incorrect versions of the OLE system DLLs are installed.  
  
## Remarks  
 Call this function to initialize the OLE support for an MFC application. When this function is called, the following actions occur:  
  
-   Initializes the COM library on the current apartment of the calling application. For more information, see [OleInitialize](http://msdn.microsoft.com/library/windows/desktop/ms690134).  
  
-   Creates a message filter object, implementing the [IMessageFilter](http://msdn.microsoft.com/library/windows/desktop/ms693740) interface. This message filter can be accessed with a call to [AfxOleGetMessageFilter](../vs140/afxolegetmessagefilter.md).  
  
> [!NOTE]
>  If **AfxOleInit** is called from an MFC DLL, the call will fail. The failure occurs because the function assumes that, if it is called from a DLL, the OLE system was previously initialized by the calling application.  
  
> [!NOTE]
>  MFC applications must be initialized as single threaded apartment (STA). If you call [CoInitializeEx](http://msdn.microsoft.com/library/windows/desktop/ms695279) in your `InitInstance` override, specify `COINIT_APARTMENTTHREADED` (rather than `COINIT_MULTITHREADED`). For more information, see PRB: MFC Application Stops Responding When You Initialize the Application as a Multithreaded Apartment (828643) at [http://support.microsoft.com/default.aspx?scid=kb;en-us;828643](http://support.microsoft.com/default.aspx?scid=kb;en-us;828643).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxMessageBox](../vs140/afxmessagebox.md)