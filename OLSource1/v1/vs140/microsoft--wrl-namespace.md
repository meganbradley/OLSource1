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
Defines the fundamental types that make up the [!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[ActivationFactory Class](../vs140/activationfactory-class.md)|Enables one or more classes to be activated by the Windows Runtime.|  
|[AsyncBase Class](../vs140/asyncbase-class.md)|Implements the Windows Runtime asynchronous state machine.|  
|[ClassFactory Class](../vs140/classfactory-class.md)|Implements the basic functionality of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface.|  
|[ComPtr Class](../vs140/comptr-class.md)|Creates a *smart pointer* type that represents the interface specified by the template parameter. ComPtr automatically maintains a reference count for the underlying interface pointer and releases the interface when the reference count goes to zero.|  
|[DeferrableEventArgs Class](../vs140/deferrableeventargs-class.md)|A template class used for the event argument types for deferrals.|  
|[EventSource Class](../vs140/eventsource-class.md)|Represents an event. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member functions add, remove, and invoke event handlers.|  
|[FtmBase Class](../vs140/ftmbase-class.md)|Represents a free-threaded marshaler object.|  
|[Module Class](../vs140/module-class.md)|Represents a collection of related objects.|  
|[RuntimeClass Class](../vs140/runtimeclass-class.md)|Represents an instantiated class that inherits the specified number of interfaces, and provides the specified Windows Runtime, classic COM, and weak reference support.|  
|[SimpleActivationFactory Class](../vs140/simpleactivationfactory-class.md)|Provides a fundamental mechanism to create a Windows Runtime or classic COM base class.|  
|[SimpleClassFactory Class](../vs140/simpleclassfactory-class.md)|Provides a fundamental mechanism to create a base class.|  
|[WeakRef Class](../vs140/weakref-class.md)|Represents a *weak reference* that can be used by only the Windows Runtime, not classic COM. A weak reference represents an object that might or might not be accessible.|  
  
### Structures  
  
|Name|Description|  
|----------|-----------------|  
|[ChainInterfaces Structure](../vs140/chaininterfaces-structure.md)|Specifies verification and initialization functions that can be applied to a set of interface IDs.|  
|[CloakedIid Structure](../vs140/cloakediid-structure.md)|Indicates to the RuntimeClass, Implements and ChainInterfaces templates that the specified interface is not accessible in the IID list.|  
|[Implements Structure](../vs140/implements-structure.md)|Implements QueryInterface and GetIid for the specified interfaces.|  
|[MixIn Structure](../vs140/mixin-structure.md)|Ensures that a runtime class derives from Windows Runtime interfaces, if any, and then classic COM interfaces.|  
|[RuntimeClassFlags Structure](../vs140/runtimeclassflags-structure.md)|Contains the type for an instance of a [RuntimeClass](../vs140/runtimeclass-class.md).|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[AsyncResultType Enumeration](../vs140/asyncresulttype-enumeration.md)|Specifies the type of result returned by the GetResults() method.|  
|[ModuleType Enumeration](../vs140/moduletype-enumeration.md)|Specifies whether a module should support an in-process server or an out-of-process server.|  
|[RuntimeClassType Enumeration](../vs140/runtimeclasstype-enumeration.md)|Specifies the type of [RuntimeClass](../vs140/runtimeclass-class.md) instance that is supported.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[AsWeak Function](../vs140/asweak-function.md)|Retrieves a weak reference to a specified instance.|  
|[Callback Function](../vs140/callback-function--windows-runtime-c---template-library-.md)|Creates an object whose member function is a callback method.|  
|[CreateActivationFactory Function](../vs140/createactivationfactory-function.md)|Creates a factory that produces instances of the specified class that can be activated by the Windows Runtime.|  
|[CreateClassFactory Function](../vs140/createclassfactory-function.md)|Creates a factory that produces instances of the specified class.|  
|[Make Function](../vs140/make-function.md)|Initializes the specified [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] class.|  
  
## Requirements  
 **Header:** async.h, client.h, corewrappers.h, event.h, ftm.h, implements.h, internal.h, module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Microsoft::WRL::Wrappers Namespace](../vs140/microsoft--wrl--wrappers-namespace.md)