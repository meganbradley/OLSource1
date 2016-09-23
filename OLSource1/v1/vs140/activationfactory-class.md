---
title: "ActivationFactory Class"
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
  - module/Microsoft::WRL::ActivationFactory
dev_langs: 
  - C++
helpviewer_keywords: 
  - ActivationFactory class
ms.assetid: 5faddf1f-43b6-4f8a-97de-8c9d3ae1e1ff
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ActivationFactory Class
Enables one or more classes to be activated by the Windows Runtime.  
  
## Syntax  
  
```  
template <  
   typename I0 = Details::Nil,  
   typename I1 = Details::Nil,  
   typename I2 = Details::Nil  
>  
class ActivationFactory : public Details::RuntimeClass<typename Details::InterfaceListHelper<IActivationFactory, I0, I1, I2, Details::Nil>::TypeT, RuntimeClassFlags<WinRt | InhibitWeakReference>, false>;  
```  
  
#### Parameters  
 `I0`  
 The zeroth interface.  
  
 `I1`  
 The first interface.  
  
 `I2`  
 The second interface.  
  
## Remarks  
 ActivationFactory provides registration methods and basic functionality for the IActivationFactory interface. ActivationFactory also enables you to provide a custom factory implementation.  
  
 The following code fragment symbolically illustrates how to use ActivationFactory.  
  
 [!code[wrl-microsoft__wrl__activationfactory#1](../vs140/codesnippet/CPP/activationfactory-class_1.cpp)]
  
  
 The following code fragment shows how to use the [Implements](../vs140/implements-structure.md) structure to specify more than three interface IDs.  
  
 `struct MyFactory : ActivationFactory<Implements<I1, I2, I3>, I4, I5>;`  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[ActivationFactory::ActivationFactory Constructor](../vs140/activationfactory--activationfactory-constructor.md)|Initializes the ActivationFactory class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ActivationFactory::AddRef Method](../vs140/activationfactory--addref-method.md)|Increments the reference count of the current ActivationFactory object.|  
|[ActivationFactory::GetIids Method](../vs140/activationfactory--getiids-method.md)|Retrieves an array of implemented interface IDs.|  
|[ActivationFactory::GetRuntimeClassName Method](../vs140/activationfactory--getruntimeclassname-method.md)|Gets the runtime class name of the object that the current ActivationFactory instantiates.|  
|[ActivationFactory::GetTrustLevel Method](../vs140/activationfactory--gettrustlevel-method.md)|Gets the trust level of the object that the current ActivationFactory instantiates.|  
|[ActivationFactory::QueryInterface Method](../vs140/activationfactory--queryinterface-method.md)|Retrieves a pointer to the specified interface.|  
|[ActivationFactory::Release Method](../vs140/activationfactory--release-method.md)|Decrements the reference count of the current ActivationFactory object.|  
  
## Inheritance Hierarchy  
 `I0`  
  
 `ChainInterfaces`  
  
 `I0`  
  
 `RuntimeClassBase`  
  
 `ImplementsHelper`  
  
 `DontUseNewUseMake`  
  
 `RuntimeClassFlags`  
  
 `RuntimeClassBaseT`  
  
 `RuntimeClass`  
  
 `ActivationFactory`  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)