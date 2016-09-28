---
title: "ComPtrRefBase Class"
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
  - "client/Microsoft::WRL::Details::ComPtrRefBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ComPtrRefBase class"
ms.assetid: 6d344c1a-cc13-4a3f-8a0d-f167ccb9348f
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtrRefBase Class
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
template <  
   typename T  
>  
class ComPtrRefBase;  
```  
  
#### Parameters  
 `T`  
 A [ComPtr<T\>](../vs140/comptr-class.md) type or a type derived from it, not merely the interface represented by the ComPtr.  
  
## Remarks  
 Represents the base class for the [ComPtrRef](../vs140/comptrref-class.md) class.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`InterfaceType`|A synonym for the type of template parameter `T`.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[ComPtrRefBase::operator IInspectable** Operator](../vs140/comptrrefbase--operator-iinspectable---operator.md)|Casts the current [ptr_](../vs140/comptrrefbase--ptr_-data-member.md) data member to a pointer-to-a-pointer-to the IInspectable interface.|  
|[ComPtrRefBase::operator IUnknown** Operator](../vs140/comptrrefbase--operator-iunknown---operator.md)|Casts the current [ptr_](../vs140/comptrrefbase--ptr_-data-member.md) data member to a pointer-to-a-pointer-to the IUnknown interface.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[ComPtrRefBase::ptr_ Data Member](../vs140/comptrrefbase--ptr_-data-member.md)|Pointer to the type specified by the current template parameter.|  
  
## Inheritance Hierarchy  
 `ComPtrRefBase`  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)