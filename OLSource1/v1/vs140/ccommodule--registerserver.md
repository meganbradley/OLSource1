---
title: "CComModule::RegisterServer"
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
  - "CComModule::RegisterServer"
  - "ATL::CComModule::RegisterServer"
  - "ATL.CComModule.RegisterServer"
  - "CComModule.RegisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterServer method"
ms.assetid: 3a777be5-b41e-4e2c-afc5-ad25414f117a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::RegisterServer
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
      HRESULT RegisterServer(  
   BOOL bRegTypeLib = FALSE,  
   const CLSID* pCLSID = NULL   
) throw( );  
```  
  
#### Parameters  
 `bRegTypeLib`  
 [in] Indicates whether the type library will be registered. The default value is **FALSE**.  
  
 `pCLSID`  
 [in] Points to the CLSID of the object to be registered. If **NULL** (the default value), all objects in the object map will be registered.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 Depending on the `pCLSID` parameter, updates the system registry for a single class object or for all objects in the object map.  
  
 If `bRegTypeLib` is **TRUE**, the type library information will also be updated.  
  
 See [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) for information on how to add an entry to the object map.  
  
 `RegisterServer` will be called automatically by **DLLRegisterServer** for a DLL or by `WinMain` for an EXE run with the **/RegServer** command line option.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)   
 [CComModule::UnregisterServer](../vs140/ccommodule--unregisterserver.md)