---
title: "CreateClassFactory Function"
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
  - "module/Microsoft::WRL::Details::CreateClassFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateClassFactory function"
ms.assetid: 772d5d1b-8872-4745-81ca-521a39564713
caps.latest.revision: 6
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CreateClassFactory Function
Creates a factory that produces instances of the specified class.  
  
## Syntax  
  
```cpp  
  
template<typename Factory>  
inline HRESULT STDMETHODCALLTYPE CreateClassFactory(  
   _In_ unsigned int *flags,   
   _In_ const CreatorMap* entry,   
   REFIID riid,   
   _Outptr_ IUnknown **ppFactory  
) throw();  
  
```  
  
#### Parameters  
 `flags`  
 A combination of one or more [RuntimeClassType](../vs140/runtimeclasstype-enumeration.md) enumeration values.  
  
 `entry`  
 Pointer to a [CreatorMap](../vs140/creatormap-structure.md) that contains initialization and registration information about parameter `riid`.  
  
 `riid`  
 Reference to an interface ID.  
  
 `ppFactory`  
 If this operation completes successfully, a pointer to a class factory.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Remarks  
 An assert error is emitted if template parameter `Factory` doesn't derive from interface IClassFactory.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Details Namespace](../vs140/microsoft--wrl--wrappers--details-namespace.md)