---
title: "Microsoft::WRL Namespace"
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
  - "implements/Microsoft::WRL"
  - "module/Microsoft::WRL"
  - "async/Microsoft::WRL"
  - "internal/Microsoft::WRL"
  - "event/Microsoft::WRL"
  - "ftm/Microsoft::WRL"
  - "client/Microsoft::WRL"
  - "corewrappers/Microsoft::WRL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WRL namespace"
ms.assetid: 01118a8f-f564-4859-b87e-9444848585a1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Microsoft::WRL Namespace
Defines the fundamental types that make up the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)].  
  
## Syntax  
  
```  
namespace Microsoft::WRL;  
```  
  
## Members  
  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`InhibitWeakReferencePolicy`|`RuntimeClassFlags<WinRt &#124; InhibitWeakReference>`|  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[ActivationFactory Class](../VS_csharp/activationfactory-class.md)|Enables one or more classes to be activated by the Windows Runtime.|  
|[AsyncBase Class](../VS_csharp/asyncbase-class.md)|Implements the Windows Runtime asynchronous state machine.|  
|[ClassFactory Class](../VS_csharp/classfactory-class.md)|Implements the basic functionality of the `IClassFactory` interface.|  
|[ComPtr Class](../VS_csharp/comptr-class.md)|Creates a *smart pointer* type that represents the interface specified by the template parameter. ComPtr automatically maintains a reference count for the underlying interface pointer and releases the interface when the reference count goes to zero.|  
|[DeferrableEventArgs Class](../VS_csharp/deferrableeventargs-class.md)|A template class used for the event argument types for deferrals.|  
|[EventSource Class](../VS_csharp/eventsource-class.md)|Represents an event. `EventSource` member functions add, remove, and invoke event handlers.|  
|[FtmBase Class](../VS_csharp/ftmbase-class.md)|Represents a free-threaded marshaler object.|  
|[Module Class](../VS_csharp/module-class.md)|Represents a collection of related objects.|  
|[RuntimeClass Class](../VS_csharp/runtimeclass-class.md)|Represents an instantiated class that inherits the specified number of interfaces, and provides the specified Windows Runtime, classic COM, and weak reference support.|  
|[SimpleActivationFactory Class](../VS_csharp/simpleactivationfactory-class.md)|Provides a fundamental mechanism to create a Windows Runtime or classic COM base class.|  
|[SimpleClassFactory Class](../VS_csharp/simpleclassfactory-class.md)|Provides a fundamental mechanism to create a base class.|  
|[WeakRef Class](../VS_csharp/weakref-class.md)|Represents a *weak reference* that can be used by only the Windows Runtime, not classic COM. A weak reference represents an object that might or might not be accessible.|  
  
### Structures  
  
|Name|Description|  
|----------|-----------------|  
|[ChainInterfaces Structure](../VS_csharp/chaininterfaces-structure.md)|Specifies verification and initialization functions that can be applied to a set of interface IDs.|  
|[CloakedIid Structure](../VS_csharp/cloakediid-structure.md)|Indicates to the RuntimeClass, Implements and ChainInterfaces templates that the specified interface is not accessible in the IID list.|  
|[Implements Structure](../VS_csharp/implements-structure.md)|Implements QueryInterface and GetIid for the specified interfaces.|  
|[MixIn Structure](../VS_csharp/mixin-structure.md)|Ensures that a runtime class derives from Windows Runtime interfaces, if any, and then classic COM interfaces.|  
|[RuntimeClassFlags Structure](../VS_csharp/runtimeclassflags-structure.md)|Contains the type for an instance of a [RuntimeClass](../VS_csharp/runtimeclass-class.md).|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[AsyncResultType Enumeration](../VS_csharp/asyncresulttype-enumeration.md)|Specifies the type of result returned by the GetResults() method.|  
|[ModuleType Enumeration](../VS_csharp/moduletype-enumeration.md)|Specifies whether a module should support an in-process server or an out-of-process server.|  
|[RuntimeClassType Enumeration](../VS_csharp/runtimeclasstype-enumeration.md)|Specifies the type of [RuntimeClass](../VS_csharp/runtimeclass-class.md) instance that is supported.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[AsWeak Function](../VS_csharp/asweak-function.md)|Retrieves a weak reference to a specified instance.|  
|[Callback Function](../VS_csharp/callback-function--windows-runtime-c---template-library-.md)|Creates an object whose member function is a callback method.|  
|[CreateActivationFactory Function](../VS_csharp/createactivationfactory-function.md)|Creates a factory that produces instances of the specified class that can be activated by the Windows Runtime.|  
|[CreateClassFactory Function](../VS_csharp/createclassfactory-function.md)|Creates a factory that produces instances of the specified class.|  
|[Make Function](../VS_csharp/make-function.md)|Initializes the specified [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] class.|  
  
## Requirements  
 **Header:** async.h, client.h, corewrappers.h, event.h, ftm.h, implements.h, internal.h, module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Microsoft::WRL::Wrappers Namespace](../VS_csharp/microsoft--wrl--wrappers-namespace.md)