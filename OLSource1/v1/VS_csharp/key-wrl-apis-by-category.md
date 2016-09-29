---
title: "Key WRL APIs by Category"
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
ms.assetid: 7367bacf-6b7c-4ecd-a0ce-a662db46fc66
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Key WRL APIs by Category
The following tables list primary [!INCLUDE[cppwrl](../VS_csharp/includes/cppwrl_md.md)] classes, structs, functions, and macros. Constructs in helper namespaces and classes are omitted. These lists augment the API documentation, which is arranged by namespace.  
  
### Classes  
  
|Title|Description|  
|-----------|-----------------|  
|[ActivationFactory Class](../VS_csharp/activationfactory-class.md)|Enables one or more classes to be activated by the Windows Runtime.|  
|[AsyncBase Class](../VS_csharp/asyncbase-class.md)|Implements the Windows Runtime asynchronous state machine.|  
|[ClassFactory Class](../VS_csharp/classfactory-class.md)|Implements the basic functionality of the `IClassFactory` interface.|  
|[ComPtr Class](../VS_csharp/comptr-class.md)|Creates a *smart pointer* type that represents the interface specified by the template parameter. ComPtr automatically maintains a reference count for the underlying interface pointer and releases the interface when the reference count goes to zero.|  
|[Event Class](../VS_csharp/event-class--windows-runtime-c---template-library-.md)|Represents an event.|  
|[EventSource Class](../VS_csharp/eventsource-class.md)|Represents an event. `EventSource` member functions add, remove, and invoke event handlers.|  
|[FtmBase Class](../VS_csharp/ftmbase-class.md)|Represents a free-threaded marshaler object.|  
|[HandleT Class](../VS_csharp/handlet-class.md)|Represents a handle to an object.|  
|[HString Class](../VS_csharp/hstring-class.md)|Provides support for manipulating HSTRING handles.|  
|[HStringReference Class](../VS_csharp/hstringreference-class.md)|Represents an HSTRING that is created from an existing string.|  
|[Module Class](../VS_csharp/module-class.md)|Represents a collection of related objects.|  
|[Module::GenericReleaseNotifier Class](../VS_csharp/module--genericreleasenotifier-class.md)|Invokes an event handler when the last object in the current module is released. The event handler is specified by on a lambda, functor, or pointer-to-function.|  
|[Module::MethodReleaseNotifier Class](../VS_csharp/module--methodreleasenotifier-class.md)|Invokes an event handler when the last object in the current module is released. The event handler is specified by an object and its pointer-to-a-method member.|  
|[Module::ReleaseNotifier Class](../VS_csharp/module--releasenotifier-class.md)|Invokes an event handler when the last object in a module is released.|  
|[RoInitializeWrapper Class](../VS_csharp/roinitializewrapper-class.md)|Initializes the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].|  
|[RuntimeClass Class](../VS_csharp/runtimeclass-class.md)|Represents an instantiated class that inherits the specified number of interfaces, and provides the specified Windows Runtime, classic COM, and weak reference support.|  
|[SimpleActivationFactory Class](../VS_csharp/simpleactivationfactory-class.md)|Provides a fundamental mechanism to create a Windows Runtime or classic COM base class.|  
|[SimpleClassFactory Class](../VS_csharp/simpleclassfactory-class.md)|Provides a fundamental mechanism to create a base class.|  
|[WeakRef Class](../VS_csharp/weakref-class.md)|Represents a *weak reference* that can be used by only the Windows Runtime, not classic COM. A weak reference represents an object that might or might not be accessible.|  
  
### Structures  
  
|Title|Description|  
|-----------|-----------------|  
|[ChainInterfaces Structure](../VS_csharp/chaininterfaces-structure.md)|Specifies verification and initialization functions that can be applied to a set of interface IDs.|  
|[CloakedIid Structure](../VS_csharp/cloakediid-structure.md)|Indicates to the `RuntimeClass`, `Implements` and `ChainInterfaces` templates that the specified interface is not accessible in the IID list.|  
|[Implements Structure](../VS_csharp/implements-structure.md)|Implements `QueryInterface` and `GetIid` for the specified interfaces.|  
|[MixIn Structure](../VS_csharp/mixin-structure.md)|Ensures that a runtime class derives from Windows Runtime interfaces, if any, and then classic COM interfaces.|  
  
### Functions  
  
|Title|Description|  
|-----------|-----------------|  
|[ActivateInstance Function](../VS_csharp/activateinstance-function.md)|Registers and retrieves an instance of a specified type defined in a specified class ID.|  
|[AsWeak Function](../VS_csharp/asweak-function.md)|Retrieves a weak reference to a specified instance.|  
|[Callback Function](../VS_csharp/callback-function--windows-runtime-c---template-library-.md)|Creates an object whose member function is a callback method.|  
|[CreateActivationFactory Function](../VS_csharp/createactivationfactory-function.md)|Creates a factory that produces instances of the specified class that can be activated by the Windows Runtime.|  
|[CreateClassFactory Function](../VS_csharp/createclassfactory-function.md)|Creates a factory that produces instances of the specified class.|  
|[GetActivationFactory Function](../VS_csharp/getactivationfactory-function.md)|Retrieves an activation factory for the type specified by the template parameter.|  
|[Make Function](../VS_csharp/make-function.md)|Initializes the specified [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] class.|  
  
### Macros  
  
|Title|Description|  
|-----------|-----------------|  
|[ActivatableClass Macros](../VS_csharp/activatableclass-macros.md)|Populates an internal cache that contains a factory that can create an instance of the specified class.|  
|[InspectableClass Macro](../VS_csharp/inspectableclass-macro.md)|Sets the runtime class name and trust level.|  
  
## See Also  
 [Windows Runtime C++ Template Library](../VS_csharp/windows-runtime-c---template-library--wrl-.md)