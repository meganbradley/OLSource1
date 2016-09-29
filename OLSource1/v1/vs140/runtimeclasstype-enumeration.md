---
title: "RuntimeClassType Enumeration"
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
  - "implements/Microsoft::WRL::RuntimeClassType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RuntimeClassType enumeration"
ms.assetid: d380712d-672e-4ea9-b7c5-cf9fa7dbb770
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeClassType Enumeration
Specifies the type of [RuntimeClass](../vs140/runtimeclass-class.md) instance that is supported.  
  
## Syntax  
  
```  
enum RuntimeClassType;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`ClassicCom`|A classic COM runtime class.|  
|`Delegate`|Equivalent to **ClassicCom**.|  
|`InhibitFtmBase`|Disables `FtmBase` support while `__WRL_CONFIGURATION_LEGACY__` is not defined.|  
|`InhibitWeakReference`|Disables weak reference support.|  
|`WinRt`|A [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] class.|  
|`WinRtClassicComMix`|A combination of `WinRt` and `ClassicCom`.|  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)