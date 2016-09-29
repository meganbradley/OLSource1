---
title: "RoInitializeWrapper Class"
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
  - "corewrappers/Microsoft::WRL::Wrappers::RoInitializeWrapper"
dev_langs: 
  - "C++"
ms.assetid: 4055fbe0-63a7-4c06-b5a0-414fda5640e5
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RoInitializeWrapper Class
Initializes the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
class RoInitializeWrapper  
```  
  
## Remarks  
 RoInitializeWrapper is a convenience that initializes the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] and returns an HRESULT that indicates whether the operation was successful.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[RoInitializeWrapper::RoInitializeWrapper](../VS_csharp/roinitializewrapper--roinitializewrapper-constructor.md)|Initializes a new instance of the RoInitializeWrapper class.|  
|[RoInitializeWrapper::~RoInitializeWrapper](../VS_csharp/roinitializewrapper--~roinitializewrapper-destructor.md)|Destroys the current instance of the RoInitializeWrapper class.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[HRESULT()](../VS_csharp/roinitializewrapper--hresult---operator.md)|Retrieves the HRESULT produced by the RoInitializeWrapper constructor.|  
  
## Inheritance Hierarchy  
 `RoInitializeWrapper`  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Wrappers Namespace](../VS_csharp/microsoft--wrl--wrappers-namespace.md)