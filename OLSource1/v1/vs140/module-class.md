---
title: "Module Class"
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
  - "module/Microsoft::WRL::Module"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Module class"
ms.assetid: dd67e3b8-c2e1-4f53-8c0f-565a140ba649
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module Class
Represents a collection of related objects.  
  
## Syntax  
  
```  
  
template<  
   ModuleType moduleType  
>  
class Module;  
  
template<>  
class Module<InProc> : public Details::ModuleBase;  
  
template<>  
class Module<OutOfProc> : public Module<InProc>;  
```  
  
#### Parameters  
 `moduleType`  
 A combination of one or more [ModuleType](../vs140/moduletype-enumeration.md) enumeration values.  
  
## Members  
  
### Protected Classes  
  
|Name|Description|  
|----------|-----------------|  
|[Module::GenericReleaseNotifier Class](../vs140/module--genericreleasenotifier-class.md)|Invokes an event handler when the last object in the current module is released. The event handler is specified by on a lambda, functor, or pointer-to-function.|  
|[Module::MethodReleaseNotifier Class](../vs140/module--methodreleasenotifier-class.md)|Invokes an event handler when the last object in the current module is released. The event handler is specified by an object and its pointer-to-a-method member.|  
|[Module::ReleaseNotifier Class](../vs140/module--releasenotifier-class.md)|Invokes an event handler when the last object in a module is released.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[Module::~Module Destructor](../vs140/module--~module-destructor.md)|Deinitializes the current instance of the Module class.|  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[Module::Module Constructor](../vs140/module--module-constructor.md)|Initializes a new instance of the Module class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[Module::Create Method](../vs140/module--create-method.md)|Creates an instance of a module.|  
|[Module::DecrementObjectCount Method](../vs140/module--decrementobjectcount-method.md)|Decrements the number of objects tracked by the module.|  
|[Module::GetActivationFactory Method](../vs140/module--getactivationfactory-method.md)|Gets an activation factory for the module.|  
|[Module::GetClassObject Method](../vs140/module--getclassobject-method.md)|Retreives a cache of class factories.|  
|[Module::GetModule Method](../vs140/module--getmodule-method.md)|Creates an instance of a module.|  
|[Module::GetObjectCount Method](../vs140/module--getobjectcount-method.md)|Retrieves the number of objects managed by this module.|  
|[Module::IncrementObjectCount Method](../vs140/module--incrementobjectcount-method.md)|Increments the number of objects tracked by the module.|  
|[Module::RegisterCOMObject Method](../vs140/module--registercomobject-method.md)|Registers one or more COM objects so other applications can connect to them.|  
|[Module::RegisterObjects Method](../vs140/module--registerobjects-method.md)|Registers COM or [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] objects so other applications can connect to them.|  
|[Module::RegisterWinRTObject Method](../vs140/module--registerwinrtobject-method.md)|Registers one or more [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] objects so other applications can connect to them.|  
|[Module::Terminate Method](../vs140/module--terminate-method.md)|Causes all factories instantiated by the module to shut down.|  
|[Module::UnregisterCOMObject Method](../vs140/module--unregistercomobject-method.md)|Unregisters one or more COM objects, which prevents other applications from connecting to them.|  
|[Module::UnregisterObjects Method](../vs140/module--unregisterobjects-method.md)|Unregisters the objects in the specified module so that other applications cannot connect to them.|  
|[Module::UnregisterWinRTObject Method](../vs140/module--unregisterwinrtobject-method.md)|Unregisters one or more [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] objects so that other applications cannot connect to them.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[Module::Create Method](../vs140/module--create-method.md)|Creates an instance of a module.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[Module::objectCount_ Data Member](../vs140/module--objectcount_-data-member.md)|Keeps track of how many classes have been created with the [Make](../vs140/make-function.md) function.|  
|[Module::releaseNotifier_ Data Member](../vs140/module--releasenotifier_-data-member.md)|Holds a pointer to a ReleaseNotifier object.|  
  
### Macros  
  
|||  
|-|-|  
|[ActivatableClass](../vs140/activatableclass-macros.md)|Populates an internal cache that contains a factory that can create an instance of the specified class. This macro specifies default factory and group ID parameters.|  
|[ActivatableClassWithFactory](../vs140/activatableclass-macros.md)|Populates an internal cache that contains a factory that can create an instance of the specified class. This macro enables you to specify a particular factory parameter.|  
|[ActivatableClassWithFactoryEx](../vs140/activatableclass-macros.md)|Populates an internal cache that contains a factory that can create an instance of the specified class. This macro enables you to specify particular factory and group ID parameters.|  
  
## Inheritance Hierarchy  
 `ModuleBase`  
  
 `Module`  
  
 `Module`  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)