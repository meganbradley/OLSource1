---
title: "CAsyncMonikerFile::Open"
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
  - "CAsyncMonikerFile.Open"
  - "CAsyncMonikerFile::Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open method"
ms.assetid: 3c9f7ee0-5b33-4ae5-a442-1afb84d0a3fb
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncMonikerFile::Open
Call this member function to open a file asynchronously.  
  
## Syntax  
  
```  
  
      virtual BOOL Open(  
   LPCTSTR lpszURL,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   IMoniker* pMoniker,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   LPCTSTR lpszURL,  
   IBindHost* pBindHost,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   IMoniker* pMoniker,  
   IBindHost* pBindHost,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   LPCTSTR lpszURL,  
   IServiceProvider* pServiceProvider,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   IMoniker* pMoniker,  
   IServiceProvider* pServiceProvider,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   LPCTSTR lpszURL,  
   IUnknown* pUnknown,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   IMoniker* pMoniker,  
   IUnknown* pUnknown,  
   CFileException* pError = NULL   
);  
```  
  
#### Parameters  
 `lpszURL`  
 A pointer to file to be opened asynchronously. The file can be any valid URL or filename.  
  
 `pError`  
 A pointer to the file exceptions. In the event of an error, it will be set to the cause.  
  
 `pMoniker`  
 A pointer to the asynchronous moniker interface `IMoniker`, a precise moniker that is the combination of the document's own moniker, which you can retrieve with **IOleClientSite::GetMoniker(** *OLEWHICHMK_CONTAINER* **)**, and a moniker created from the path name. The control can use this moniker to bind, but this is not the moniker the control should save.  
  
 *pBindHost*  
 A pointer to the `IBindHost` interface that will be used to create the moniker from a potentially relative pathname. If the bind host is invalid or does not provide a moniker, the call defaults to **Open(** `lpszFileName`**,**`pError`**)**. For a description of the `IBindHost` interface, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pServiceProvider`  
 A pointer to the `IServiceProvider` interface. If the service provider is invalid or fails to provide the service for `IBindHost`, the call defaults to **Open(** `lpszFileName`**,**`pError`**)**.  
  
 *pUnknown*  
 A pointer to the **IUnknown** interface. If `IServiceProvider` is found, the function queries for `IBindHost`. If the service provider is invalid or fails to provide the service for `IBindHost`, the call defaults to **Open(** `lpszFileName`**,**`pError`**)**.  
  
## Return Value  
 Nonzero if the file is opened successfully; otherwise 0.  
  
## Remarks  
 This call initiates the binding process.  
  
 You can use a URL or a filename for the `lpszURL` parameter. For example:  
  
 [!code[NVC_MFCWinInet#6](../vs140/codesnippet/CPP/casyncmonikerfile--open_1.cpp)]  
  
 – or –  
  
 [!code[NVC_MFCWinInet#7](../vs140/codesnippet/CPP/casyncmonikerfile--open_2.cpp)]  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CAsyncMonikerFile Class](../vs140/casyncmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncMonikerFile::CAsyncMonikerFile](../vs140/casyncmonikerfile--casyncmonikerfile.md)