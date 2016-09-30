---
title: "CAtlComModule::UnRegisterTypeLib"
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
  - "ATL::CAtlComModule::UnRegisterTypeLib"
  - "CAtlComModule::UnRegisterTypeLib"
  - "CAtlComModule.UnRegisterTypeLib"
  - "ATL.CAtlComModule.UnRegisterTypeLib"
  - "UnRegisterTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnRegisterTypeLib method"
ms.assetid: dc64f1e8-e3a2-4b39-9215-b5c23816c3d0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlComModule::UnRegisterTypeLib
Call this method to unregister a type library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 String in the format "\\\N", where N is the integer index of the TYPELIB resource.  
  
## Remarks  
 Removes information about a type library from the system registry. If the module instance contains multiple type libraries, use the first version of this method to specify which type library should be used.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlComModule Class](../vs140/catlcommodule-class.md)   
 [CAtlComModule::RegisterTypeLib](../vs140/catlcommodule--registertypelib.md)