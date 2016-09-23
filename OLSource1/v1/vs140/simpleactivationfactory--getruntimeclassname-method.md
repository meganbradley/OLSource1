---
title: "SimpleActivationFactory::GetRuntimeClassName Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - module/Microsoft::WRL::SimpleActivationFactory::GetRuntimeClassName
dev_langs: 
  - C++
ms.assetid: 3aa07487-9a42-46f8-8893-37ba6315e50b
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# SimpleActivationFactory::GetRuntimeClassName Method
Gets the runtime class name of an instance of the class specified by the `Base` class template parameter.  
  
## Syntax  
  
```  
STDMETHOD(  
   GetRuntimeClassName  
)(_Out_ HSTRING* runtimeName);  
```  
  
#### Parameters  
 `runtimeName`  
 When this operation completes, the runtime class name.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Remarks  
 If __WRL_STRICT\_\_ is defined, an assert error is emitted if the class specified by the `Base` class template parameter isn't derived from [RuntimeClass](../vs140/runtimeclass-class.md), or isn't configured with the WinRt or WinRtClassicComMix [RuntimeClassType](../vs140/runtimeclasstype-enumeration.md) enumeration value.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [SimpleActivationFactory Class](../vs140/simpleactivationfactory-class.md)