---
title: "RoInitializeWrapper::~RoInitializeWrapper Destructor"
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
  - "corewrappers/Microsoft::WRL::Wrappers::RoInitializeWrapper::~RoInitializeWrapper"
dev_langs: 
  - "C++"
ms.assetid: afef4c1f-ffde-4cd2-8654-8de4182eb5f4
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RoInitializeWrapper::~RoInitializeWrapper Destructor
Uninitializes the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```cpp  
~RoInitializeWrapper()  
```  
  
## Remarks  
 The RoInitializeWrapper class invokes Windows::Foundation::Uninitialize().  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [RoInitialize Class](../VS_csharp/handlet-class.md)