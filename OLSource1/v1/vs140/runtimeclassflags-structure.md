---
title: "RuntimeClassFlags Structure"
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
  - "implements/Microsoft::WRL::RuntimeClassFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RuntimeClassFlags structure"
ms.assetid: 7098d605-bd14-4d51-82f4-3def8296a938
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeClassFlags Structure
Contains the type for an instance of a [RuntimeClass](../vs140/runtimeclass-class.md).  
  
## Syntax  
  
```  
template <  
   unsigned int flags  
>  
struct RuntimeClassFlags;  
```  
  
#### Parameters  
 `flags`  
 A [RuntimeClassType Enumeration](../vs140/runtimeclasstype-enumeration.md) value.  
  
## Members  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[RuntimeClassFlags::value Constant](../vs140/runtimeclassflags--value-constant.md)|Contains a [RuntimeClassType Enumeration](../vs140/runtimeclasstype-enumeration.md) value.|  
  
## Inheritance Hierarchy  
 `RuntimeClassFlags`  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)