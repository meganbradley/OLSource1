---
title: "CComModule::UnregisterServer"
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
  - "UnregisterServer"
  - "CComModule::UnregisterServer"
  - "ATL::CComModule::UnregisterServer"
  - "ATL.CComModule.UnregisterServer"
  - "CComModule.UnregisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnregisterServer method"
ms.assetid: 41a97389-2edb-4ee7-983a-1d697c5c7554
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::UnregisterServer
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
      HRESULT UnregisterServer(  
   const CLSID* pCLSID = NULL  
) throw ( );  
inline HRESULT UnregisterServer(  
   BOOL bUnRegTypeLib,  
   const CLSID* pCLSID = NULL  
) throw ( );  
```  
  
#### Parameters  
 `bUnRegTypeLib`  
 If **TRUE**, the type library is also unregistered.  
  
 `pCLSID`  
 Points to the CLSID of the object to be unregistered. If **NULL** (the default value), all objects in the object map will be unregistered.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 Depending on the `pCLSID` parameter, unregisters either a single class object or all objects in the object map.  
  
 `UnregisterServer` will be called automatically by **DLLUnregisterServer** for a DLL or by `WinMain` for an EXE run with the **/UnregServer** command line option.  
  
 See [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) for information on how to add an entry to the object map.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)   
 [CComModule::RegisterServer](../vs140/ccommodule--registerserver.md)