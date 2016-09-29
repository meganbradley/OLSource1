---
title: "ModuleType Enumeration"
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
  - "module/Microsoft::WRL::ModuleType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ModuleType enumeration"
ms.assetid: 61a763af-a5a4-451d-8b40-815af507fcde
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ModuleType Enumeration
Specifies whether a module should support an in-process server or an out-of-process server.  
  
## Syntax  
  
```  
enum ModuleType;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`InProc`|An in-process server.|  
|`OutOfProc`|An out-of-process server.|  
|`DisableCaching`|Disable caching mechanism on Module.|  
|`InProcDisableCaching`|Combination of `InProc` and `DisableCaching`.|  
|`OutOfProcDisableCaching`|Combination of `OutOfProc` and `DisableCaching`.|  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)