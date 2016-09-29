---
title: "SimpleActivationFactory::ActivateInstance Method"
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
  - "module/Microsoft::WRL::SimpleActivationFactory::ActivateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActivateInstance method"
ms.assetid: 4f836e51-5a6c-4bad-b871-9f25199298b4
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SimpleActivationFactory::ActivateInstance Method
Creates an instance of the specified interface.  
  
## Syntax  
  
```  
STDMETHOD(  
   ActivateInstance  
)(_Deref_out_ IInspectable **ppvObject);  
```  
  
#### Parameters  
 `ppvObject`  
 When this operation completes, pointer to an instance of the object specified by the `Base` class template parameter.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Remarks  
 If __WRL_STRICT\_\_ is defined, an assert error is emitted if the base class specified in the class template parameter isn't derived from [RuntimeClass](../vs140/runtimeclass-class.md), or isn't configured with the WinRt or WinRtClassicComMix [RuntimeClassType](../vs140/runtimeclasstype-enumeration.md) enumeration value.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [SimpleActivationFactory Class](../vs140/simpleactivationfactory-class.md)