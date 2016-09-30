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
As of ATL 7.0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Indicates whether the type library will be registered. The default value is **FALSE**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Points to the CLSID of the object to be registered. If **NULL** (the default value), all objects in the object map will be registered.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 Depending on the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter, updates the system registry for a single class object or for all objects in the object map.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is **TRUE**, the type library information will also be updated.  
  
 See [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) for information on how to add an entry to the object map.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will be called automatically by **DLLRegisterServer** for a DLL or by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for an EXE run with the **/RegServer** command line option.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)   
 [CComModule::UnregisterServer](../vs140/ccommodule--unregisterserver.md)