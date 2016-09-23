---
title: "Microsoft::WRL::Details Namespace"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - C++
ms.assetid: d71fe149-d804-4c6f-961d-43fe21ef8630
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Microsoft::WRL::Details Namespace
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
namespace Microsoft::WRL::Details;  
```  
  
## Members  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[ComPtrRef Class](../vs140/comptrref-class.md)|Represents a reference to an object of type ComPtr<T\>.|  
|[ComPtrRefBase Class](../vs140/comptrrefbase-class.md)|Represents the base class for the [ComPtrRef](../vs140/comptrref-class.md) class.|  
|[DontUseNewUseMake Class](../vs140/dontusenewusemake-class.md)|Prevents using operator `new` in `RuntimeClass`. Consequently, you must use the [Make function](../vs140/make-function.md) instead.|  
|[EventTargetArray Class](../vs140/eventtargetarray-class.md)|Represents an array of event handlers.|  
|[MakeAllocator Class](../vs140/makeallocator-class.md)|Allocates memory for an activatable class, with or without weak reference support.|  
|[ModuleBase Class](../vs140/modulebase-class.md)|Represents the base class of the [Module](../vs140/module-class.md) classes.|  
|[RemoveIUnknown Class](../vs140/removeiunknown-class.md)|Makes a type that is equivalent to an `IUnknown`-based type, but has non-virtual `QueryInterface`, `AddRef`, and `Release` methods.|  
|[WeakReference Class](../vs140/weakreference-class.md)|Represents a *weak reference* that can be used with the Windows Runtime or classic COM. A weak reference represents an object that might or might not be accessible.|  
  
### Structures  
  
|Name|Description|  
|----------|-----------------|  
|[ArgTraits Structure](../vs140/argtraits-structure.md)|Declares a specified delegate interface and an anonymous member function that has a specified number of parameters.|  
|[ArgTraitsHelper Structure](../vs140/argtraitshelper-structure.md)|Helps define common characteristics of delegate arguments.|  
|[BoolStruct Structure](../vs140/boolstruct-structure.md)|Defines whether a ComPtr is managing the object lifetime of an interface. BoolStruct is used internally by the [BoolType()](../vs140/comptr--operator-microsoft--wrl--details--booltype-operator.md) operator.|  
|[CreatorMap Structure](../vs140/creatormap-structure.md)|Contains information about how to initialize, register, and unregister objects.|  
|[DerefHelper Structure](../vs140/derefhelper-structure.md)|Represent a dereferenced pointer to the `T*` template parameter.|  
|[EnableIf Structure](../vs140/enableif-structure.md)|Defines a data member of the type specified by the second template parameter if the first template parameter evaluates to `true`.|  
|[FactoryCache Structure](../vs140/factorycache-structure.md)|Contains the location of a class factory and a value that identifies a registered [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] or COM class object.|  
|[ImplementsBase Structure](../vs140/implementsbase-structure.md)|Used to validate template parameter types in [Implements Structure](../vs140/implements-structure.md).|  
|[ImplementsHelper Structure](../vs140/implementshelper-structure.md)|Helps implement the [Implements](../vs140/implements-structure.md) structure.|  
|[InterfaceList Structure](../vs140/interfacelist-structure.md)|Used to create a recursive list of interfaces.|  
|[InterfaceListHelper Structure](../vs140/interfacelisthelper-structure.md)|Builds an `InterfaceList` type by recursively applying the specified template parameter arguments.|  
|[InterfaceTraits Structure](../vs140/interfacetraits-structure.md)|Implements common characteristics of an interface.|  
|[InvokeHelper Structure](../vs140/invokehelper-structure.md)|Provides an implementation of the Invoke() method based on the specified number and type of arguments.|  
|[IsBaseOfStrict Structure](../vs140/isbaseofstrict-structure.md)|Tests whether one type is the base of another.|  
|[IsSame Structure](../vs140/issame-structure.md)|Tests whether one specified type is the same as another specified type.|  
|[Nil Structure](../vs140/nil-structure.md)|Used to indicate an unspecified, optional template parameter.|  
|[RemoveReference Structure](../vs140/removereference-structure.md)|Strips the reference or rvalue-reference trait from the specified class template parameter.|  
|[RuntimeClassBase Structure](../vs140/runtimeclassbase-structure.md)|Used to detect `RuntimeClass` in the [Make](../vs140/make-function.md) function.|  
|[RuntimeClassBaseT Structure](../vs140/runtimeclassbaset-structure.md)|Provides helper methods for `QueryInterface` operations and getting interface IDs.|  
|[VerifyInheritanceHelper Structure](../vs140/verifyinheritancehelper-structure.md)|Tests whether one interface is derived from another interface.|  
|[VerifyInterfaceHelper Structure](../vs140/verifyinterfacehelper-structure.md)|Verifies that the interface specified by the template parameter meets certain requirements.|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[AsyncStatusInternal Enumeration](../vs140/asyncstatusinternal-enumeration.md)|Specifies a mapping between internal enumerations for the state of asynchronous operations and the **Windows::Foundation::AsyncStatus** enumeration.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[ActivationFactoryCallback Function](../vs140/activationfactorycallback-function.md)|Gets the activation factory for the specified activation ID.|  
|[Move Function](../vs140/move-function.md)|Moves the specified argument from one location to another.|  
|[RaiseException Function](../vs140/raiseexception-function.md)|Raises an exception in the calling thread.|  
|[Swap Function](../vs140/swap-function--windows-runtime-c---template-library-.md)|Exchanges the values of the two specified arguments.|  
|[TerminateMap Function](../vs140/terminatemap-function.md)|Shuts down the class factories in the specified module.|  
  
## Requirements  
 **Header:** async.h, client.h, corewrappers.h, event.h, ftm.h, implements.h, internal.h, module.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL Namespace](../vs140/microsoft--wrl-namespace.md)   
 [Microsoft::WRL::Wrappers Namespace](../vs140/microsoft--wrl--wrappers-namespace.md)