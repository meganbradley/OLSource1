---
title: "AtlModuleRegisterTypeLib"
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
  - "ATL.AtlModuleRegisterTypeLib"
  - "ATL::AtlModuleRegisterTypeLib"
  - "AtlModuleRegisterTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlModuleRegisterTypeLib function"
ms.assetid: 095cf576-f122-4a05-89e3-0e1d12f8ccc8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlModuleRegisterTypeLib
Registers a type library.  
  
 **Note** This function is obsolete in Visual C++ .NET 2002 and later but is available for backward compatibility with projects created with previous versions of Visual C++.  
  
## Syntax  
  
```  
  
      ATLAPI AtlModuleRegisterTypeLib(  
   _ATL_MODULE* pM,  
   LPCOLESTR lpszIndex   
);  
```  
  
#### Parameters  
 `pM`  
 Pointer to a `CComModule` class or derived class.  
  
 `lpszIndex`  
 String in the format "\\\N", where N is the integer index of the type library resource. Can be NULL if no index is required.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This function is obsolete. Instead, use its replacement, [AtlRegisterTypeLib](../vs140/atlregistertypelib.md).  
  
 This helper function is used by [CComModule::RegisterTypeLib](../vs140/ccommodule--registertypelib.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Server Registration Global Functions](../vs140/server-registration-global-functions.md)   
 [CComModule::RegisterTypeLib](../vs140/ccommodule--registertypelib.md)