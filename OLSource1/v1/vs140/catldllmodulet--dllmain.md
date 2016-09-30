---
title: "CAtlDllModuleT::DllMain"
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
  - "ATL.CAtlDllModuleT<T>.DllMain"
  - "DllMain"
  - "CAtlDllModuleT<T>.DllMain"
  - "ATL.CAtlDllModuleT.DllMain"
  - "ATL::CAtlDllModuleT::DllMain"
  - "ATL::CAtlDllModuleT<T>::DllMain"
  - "CAtlDllModuleT.DllMain"
  - "CAtlDllModuleT<T>::DllMain"
  - "CAtlDllModuleT::DllMain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DllMain method"
ms.assetid: 0defbd20-f8dc-4772-9b4d-1f272249510d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlDllModuleT::DllMain
The optional entry point into a dynamic-link library (DLL).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If set to DLL_PROCESS_ATTACH, the DLL_THREAD_ATTACH and DLL_THREAD_DETACH notification calls are disabled.  
  
 *lpReserved*  
 Reserved.  
  
## Return Value  
 Always returns TRUE.  
  
## Remarks  
 Disabling the DLL_THREAD_ATTACH and DLL_THREAD_DETACH notification calls can be a useful optimization for multithreaded applications that have many DLLs, that frequently create and delete threads, and whose DLLs do not need these thread-level notifications of attachment/detachment.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlDllModuleT Class](../vs140/catldllmodulet-class.md)   
 [DisableThreadLibraryCalls](http://msdn.microsoft.com/library/windows/desktop/ms682579)   
 [DllMain](http://msdn.microsoft.com/library/windows/desktop/ms682583)