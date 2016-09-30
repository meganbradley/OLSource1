---
title: "MODULE_INFO"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MODULE_INFO"
helpviewer_keywords: 
  - "MODULE_INFO structure"
ms.assetid: f2e06180-1ab3-4eb5-a428-7994cceb61b6
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# MODULE_INFO
Describes a particular module (DLL, EXE, or assembly).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 dwValidFields  
 A combination of flags from the [MODULE_INFO_FIELDS](../vs140/module_info_fields.md) enumeration that specifies which fields are filled out.  
  
 m_bstrName  
 The module name.  
  
 m_bstrUrl  
 The module URL.  
  
 m_bstrVersion  
 The module version.  
  
 m_bstrDebugMessage  
 An optional message about the module, for example, "Symbols cannot be loaded."  
  
 m_addrLoadAddress  
 The module load address.  
  
 m_addrPreferredLoadAddress  
 The preferred load address of the module.  
  
 m_dwSize  
 The module size.  
  
 m_dwLoadOrder  
 The module load order.  
  
 m_TimeStamp  
 The time the symbol file was last modified.  
  
 m_bstrUrlSymbolLocation  
 The location of the symbol file (for example, ".\\") specified in the module. Used as a starting location to find symbols for a module.  
  
 m_dwModuleFlags  
 A combination of flags from the [MODULE_FLAGS](../vs140/module_flags.md) enumeration that describes the module.  
  
## Remarks  
 This structure is passed to the [IDebugModule2::GetInfo](../vs140/idebugmodule2--getinfo.md) method where it is filled in.  
  
 This structure corresponds to each module listed in the **Modules** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [MODULE_INFO_FIELDS](../vs140/module_info_fields.md)   
 [MODULE_FLAGS](../vs140/module_flags.md)   
 [IDebugModule2::GetInfo](../vs140/idebugmodule2--getinfo.md)