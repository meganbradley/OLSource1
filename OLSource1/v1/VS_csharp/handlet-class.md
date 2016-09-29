---
title: "HandleT Class"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HandleT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HandleT class"
ms.assetid: 3822b32a-a426-4d94-a54d-919d4df60ee2
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HandleT Class
Represents a handle to an object.  
  
## Syntax  
  
```  
template <  
   typename HandleTraits  
>  
class HandleT;  
```  
  
#### Parameters  
 `HandleTraits`  
 An instance of the [HandleTraits](../VS_csharp/handletraits-structure.md) stucture that defines common characteristics of a handle.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`Traits`|A synonym for `HandleTraits`.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[HandleT::HandleT Constructor](../VS_csharp/handlet--handlet-constructor.md)|Initializes a new instance of the HandleT class.|  
|[HandleT::~HandleT Destructor](../VS_csharp/handlet--~handlet-destructor.md)|Deinitializes an instance of the HandleT class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[HandleT::Attach Method](../VS_csharp/handlet--attach-method.md)|Associates the specified handle with the current HandleT object.|  
|[HandleT::Close Method](../VS_csharp/handlet--close-method.md)|Closes the current HandleT object.|  
|[HandleT::Detach Method](../VS_csharp/handlet--detach-method.md)|Disassociates the current HandleT object from its underlying handle.|  
|[HandleT::Get Method](../VS_csharp/handlet--get-method.md)|Gets the value of the underlying handle.|  
|[HandleT::IsValid Method](../VS_csharp/handlet--isvalid-method.md)|Indicates whether the current HandleT object represents a handle.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[HandleT::InternalClose Method](../VS_csharp/handlet--internalclose-method.md)|Closes the current HandleT object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[HandleT::operator= Operator](../VS_csharp/handlet--operator=-operator.md)|Moves the value of the specified HandleT object to the current HandleT object.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[HandleT::handle_ Data Member](../VS_csharp/handlet--handle_-data-member.md)|Contains the handle that is represented by the HandleT object.|  
  
## Inheritance Hierarchy  
 `HandleT`  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Wrappers Namespace](../VS_csharp/microsoft--wrl--wrappers-namespace.md)