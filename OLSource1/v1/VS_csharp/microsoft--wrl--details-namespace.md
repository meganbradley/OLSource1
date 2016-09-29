---
title: "Microsoft::WRL::Details Namespace"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: d71fe149-d804-4c6f-961d-43fe21ef8630
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
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
|[ComPtrRef Class](../VS_csharp/comptrref-class.md)|Represents a reference to an object of type ComPtr<T\>.|  
|[ComPtrRefBase Class](../VS_csharp/comptrrefbase-class.md)|Represents the base class for the [ComPtrRef](../VS_csharp/comptrref-class.md) class.|  
|[DontUseNewUseMake Class](../VS_csharp/dontusenewusemake-class.md)|Prevents using operator `new` in `RuntimeClass`. Consequently, you must use the [Make function](../VS_csharp/make-function.md) instead.|  
|[EventTargetArray Class](../VS_csharp/eventtargetarray-class.md)|Represents an array of event handlers.|  
|[MakeAllocator Class](../VS_csharp/makeallocator-class.md)|Allocates memory for an activatable class, with or without weak reference support.|  
|[ModuleBase Class](../VS_csharp/modulebase-class.md)|Represents the base class of the [Module](../VS_csharp/module-class.md) classes.|  
|[RemoveIUnknown Class](../VS_csharp/removeiunknown-class.md)|Makes a type that is equivalent to an `IUnknown`-based type, but has non-virtual `QueryInterface`, `AddRef`, and `Release` methods.|  
|[WeakReference Class](../VS_csharp/weakreference-class.md)|Represents a *weak reference* that can be used with the Windows Runtime or classic COM. A weak reference represents an object that might or might not be accessible.|  
  
### Structures  
  
|Name|Description|  
|----------|-----------------|  
|[ArgTraits Structure](../VS_csharp/argtraits-structure.md)|Declares a specified delegate interface and an anonymous member function that has a specified number of parameters.|  
|[ArgTraitsHelper Structure](../VS_csharp/argtraitshelper-structure.md)|Helps define common characteristics of delegate arguments.|  
|[BoolStruct Structure](../VS_csharp/boolstruct-structure.md)|Defines whether a ComPtr is managing the object lifetime of an interface. BoolStruct is used internally by the [BoolType()](../VS_csharp/comptr--operator-microsoft--wrl--details--booltype-operator.md) operator.|  
|[CreatorMap Structure](../VS_csharp/creatormap-structure.md)|Contains information about how to initialize, register, and unregister objects.|  
|[DerefHelper Structure](../VS_csharp/derefhelper-structure.md)|Represent a dereferenced pointer to the `T*` template parameter.|  
|[EnableIf Structure](../VS_csharp/enableif-structure.md)|Defines a data member of the type specified by the second template parameter if the first template parameter evaluates to `true`.|  
|[FactoryCache Structure](../VS_csharp/factorycache-structure.md)|Contains the location of a class factory and a value that identifies a registered [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] or COM class object.|  
|[ImplementsBase Structure](../VS_csharp/implementsbase-structure.md)|Used to validate template parameter types in [Implements Structure](../VS_csharp/implements-structure.md).|  
|[ImplementsHelper Structure](../VS_csharp/implementshelper-structure.md)|Helps implement the [Implements](../VS_csharp/implements-structure.md) structure.|  
|[InterfaceList Structure](../VS_csharp/interfacelist-structure.md)|Used to create a recursive list of interfaces.|  
|[InterfaceListHelper Structure](../VS_csharp/interfacelisthelper-structure.md)|Builds an `InterfaceList` type by recursively applying the specified template parameter arguments.|  
|[InterfaceTraits Structure](../VS_csharp/interfacetraits-structure.md)|Implements common characteristics of an interface.|  
|[InvokeHelper Structure](../VS_csharp/invokehelper-structure.md)|Provides an implementation of the Invoke() method based on the specified number and type of arguments.|  
|[IsBaseOfStrict Structure](../VS_csharp/isbaseofstrict-structure.md)|Tests whether one type is the base of another.|  
|[IsSame Structure](../VS_csharp/issame-structure.md)|Tests whether one specified type is the same as another specified type.|  
|[Nil Structure](../VS_csharp/nil-structure.md)|Used to indicate an unspecified, optional template parameter.|  
|[RemoveReference Structure](../VS_csharp/removereference-structure.md)|Strips the reference or rvalue-reference trait from the specified class template parameter.|  
|[RuntimeClassBase Structure](../VS_csharp/runtimeclassbase-structure.md)|Used to detect `RuntimeClass` in the [Make](../VS_csharp/make-function.md) function.|  
|[RuntimeClassBaseT Structure](../VS_csharp/runtimeclassbaset-structure.md)|Provides helper methods for `QueryInterface` operations and getting interface IDs.|  
|[VerifyInheritanceHelper Structure](../VS_csharp/verifyinheritancehelper-structure.md)|Tests whether one interface is derived from another interface.|  
|[VerifyInterfaceHelper Structure](../VS_csharp/verifyinterfacehelper-structure.md)|Verifies that the interface specified by the template parameter meets certain requirements.|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[AsyncStatusInternal Enumeration](../VS_csharp/asyncstatusinternal-enumeration.md)|Specifies a mapping between internal enumerations for the state of asynchronous operations and the **Windows::Foundation::AsyncStatus** enumeration.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[ActivationFactoryCallback Function](../VS_csharp/activationfactorycallback-function.md)|Gets the activation factory for the specified activation ID.|  
|[Move Function](../VS_csharp/move-function.md)|Moves the specified argument from one location to another.|  
|[RaiseException Function](../VS_csharp/raiseexception-function.md)|Raises an exception in the calling thread.|  
|[Swap Function](../VS_csharp/swap-function--windows-runtime-c---template-library-.md)|Exchanges the values of the two specified arguments.|  
|[TerminateMap Function](../VS_csharp/terminatemap-function.md)|Shuts down the class factories in the specified module.|  
  
## Requirements  
 **Header:** async.h, client.h, corewrappers.h, event.h, ftm.h, implements.h, internal.h, module.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL Namespace](../VS_csharp/microsoft--wrl-namespace.md)   
 [Microsoft::WRL::Wrappers Namespace](../VS_csharp/microsoft--wrl--wrappers-namespace.md)