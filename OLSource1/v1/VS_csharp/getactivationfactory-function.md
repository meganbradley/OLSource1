---
title: "GetActivationFactory Function"
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
  - "module/Microsoft::WRL::Details::GetActivationFactory"
  - "client/ABI::Windows::Foundation::GetActivationFactory"
  - "client/Windows::Foundation::GetActivationFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActivationFactory function"
ms.assetid: 5736d285-6beb-42aa-8788-e261c0010afe
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetActivationFactory Function
Retrieves an activation factory for the type specified by the template parameter.  
  
## Syntax  
  
```  
template<  
   typename T  
>  
inline HRESULT GetActivationFactory(  
   _In_ HSTRING activatableClassId,  
   _Out_ Microsoft::WRL::Details::ComPtrRef<T> factory  
);  
```  
  
#### Parameters  
 `T`  
 A template parameter that specifies the type of the activation factory.  
  
 `activatableClassId`  
 The name of the class that the activation factory can produce.  
  
 `factory`  
 When this operation completes, a reference to the activation factory for type `T`.  
  
## Return Value  
 S_OK if successful; otherwise, an error HRESULT that indicates why this operation failed.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Windows::Foundation  
  
## See Also  
 [Foundation Namespace](../VS_csharp/windows--foundation-namespace.md)