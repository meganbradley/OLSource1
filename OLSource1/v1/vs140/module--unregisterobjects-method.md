---
title: "Module::UnregisterObjects Method"
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
  - "module/Microsoft::WRL::Module::UnregisterObjects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnregisterObjects method"
ms.assetid: 3d8119a7-991d-45e9-b8c5-ed36c0be0332
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module::UnregisterObjects Method
Unregisters the objects in the specified module so that other applications cannot connect to them.  
  
## Syntax  
  
```  
HRESULT UnregisterObjects(  
   ModuleBase* module,  
   const wchar_t* serverName);  
```  
  
#### Parameters  
 `module`  
 Pointer to a module.  
  
 `serverName`  
 A qualifying name that specifies a subset of objects affected by this operation.  
  
## Return Value  
 S_OK if this operation is successful; otherwise, an error HRESULT that indicates the reason this operation failed.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)