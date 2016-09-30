---
title: "CAtlComModule::RegisterTypeLib"
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
  - "CAtlComModule::RegisterTypeLib"
  - "CAtlComModule.RegisterTypeLib"
  - "RegisterTypeLib"
  - "ATL.CAtlComModule.RegisterTypeLib"
  - "ATL::CAtlComModule::RegisterTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterTypeLib method"
ms.assetid: bb3125f0-50f8-4e6b-bb88-3067e401ff1a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlComModule::RegisterTypeLib
Call this method to register a type library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 String in the format "\\\N", where N is the integer index of the TYPELIB resource.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Adds information about a type library to the system registry. If the module instance contains multiple type libraries, use the first version of this method to specify which type library should be used.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlComModule Class](../vs140/catlcommodule-class.md)   
 [CAtlComModule::UnRegisterTypeLib](../vs140/catlcommodule--unregistertypelib.md)