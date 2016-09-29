---
title: "BEGIN_RDX_MAP"
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
  - "ATL::BEGIN_RDX_MAP"
  - "ATL.BEGIN_RDX_MAP"
  - "BEGIN_RDX_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_RDX_MAP macro"
ms.assetid: 95bbba6a-d550-4e36-8e6e-1c619d9e660d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_RDX_MAP
Marks the beginning of the Registry Data Exchange map.  
  
## Syntax  
  
```  
  
BEGIN_RDX_MAP  
  
```  
  
## Remarks  
 The following macros are used within the Registry Data Exchange map to read and write entries in the system registry:  
  
|Macro|Description|  
|-----------|-----------------|  
|[RDX_BINARY](../VS_csharp/rdx_binary.md)|Associates the specified registry entry with a specified member variable of type BYTE.|  
|[RDX_DWORD](../VS_csharp/rdx_dword.md)|Associates the specified registry entry with a specified member variable of type DWORD.|  
|[RDX_CSTRING_TEXT](../VS_csharp/rdx_cstring_text.md)|Associates the specified registry entry with a specified member variable of type CString.|  
|[RDX_TEXT](../VS_csharp/rdx_text.md)|Associates the specified registry entry with a specified member variable of type TCHAR.|  
  
 The global function [RegistryDataExchange](../VS_csharp/registrydataexchange.md), or the member function of the same name created by the `BEGIN_RDX_MAP` and `END_RDX_MAP` macros, should be used whenever your code needs to exchange data between the system registry and the variables specified in the RDX map.  
  
## Requirements  
 **Header:** atlplus.h  
  
## See Also  
 [Registry Data Exchange Macros](../VS_csharp/registry-data-exchange-macros.md)