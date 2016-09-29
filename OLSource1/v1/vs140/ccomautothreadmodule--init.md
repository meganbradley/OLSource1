---
title: "CComAutoThreadModule::Init"
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
  - "ATL.CComAutoThreadModule.Init"
  - "CComAutoThreadModule::Init"
  - "CComAutoThreadModule.Init"
  - "ATL::CComAutoThreadModule::Init"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Init method"
ms.assetid: c4471fcd-34db-4ec4-a2bd-d8605e98307f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoThreadModule::Init
As of ATL 7.0, `CComAutoThreadModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
      HRESULT Init(  
   _ATL_OBJMAP_ENTRY* p,  
   HINSTANCE h,  
   const GUID* plibid = NULL,  
   int nThreads = GetDefaultThreads( )  
);  
```  
  
#### Parameters  
 `p`  
 [in] A pointer to an array of object map entries.  
  
 `h`  
 [in] The `HINSTANCE` passed to **DLLMain** or `WinMain`.  
  
 `plibid`  
 [in] A pointer to the LIBID of the type library associated with the project.  
  
 `nThreads`  
 [in] The number of threads to be created. By default, `nThreads` is the value returned by [GetDefaultThreads](../vs140/ccomautothreadmodule--getdefaultthreads.md).  
  
## Remarks  
 Initializes data members and creates the number of threads specified by `nThreads`.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComAutoThreadModule Class](../vs140/ccomautothreadmodule-class.md)   
 [CComAutoThreadModule::m_nThreads](../vs140/ccomautothreadmodule--m_nthreads.md)