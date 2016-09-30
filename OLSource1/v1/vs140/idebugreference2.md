---
title: "IDebugReference2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugReference2"
helpviewer_keywords: 
  - "IDebugReference2 interface"
ms.assetid: 3cfed312-f532-4bce-84a5-1677c14567d7
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugReference2
This interface represents a reference to a stack frame property or some other property.  
  
> [!NOTE]
>  `IDebugReference2` is reserved for future use, and all its methods should return `E_NOTIMPL`.  
  
## Syntax  
  
```  
IDebugReference2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to represent a reference to a particular kind of value. For example, the value could be a numerical value as a result of an expression evaluation, a memory context used for displaying memory, or a list of registers and their values.  
  
## Notes for Callers  
 Call [IDebugProperty2::GetReference](../vs140/idebugproperty2--getreference.md) to obtain this interface. [IDebugReference2::GetParent](../vs140/idebugreference2--getparent.md) and [IDebugReference2::GetDerivedMostReference](../vs140/idebugreference2--getderivedmostreference.md) also return this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugReference2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetReferenceInfo](../vs140/idebugreference2--getreferenceinfo.md)|Gets the [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md) structure that describes this reference.|  
|[SetValueAsString](../vs140/idebugreference2--setvalueasstring.md)|Sets the value of this reference from a string.|  
|[SetValueAsReference](../vs140/idebugreference2--setvalueasreference.md)|Sets the value of this reference from another reference.|  
|[EnumChildren](../vs140/idebugreference2--enumchildren.md)|Enumerates the children of this reference.|  
|[GetParent](../vs140/idebugreference2--getparent.md)|Gets the parent of this reference.|  
|[GetDerivedMostReference](../vs140/idebugreference2--getderivedmostreference.md)|Gets the most-derived reference of this reference.|  
|[GetMemoryBytes](../vs140/idebugreference2--getmemorybytes.md)|Gets the memory bytes to which this reference refers.|  
|[GetMemoryContext](../vs140/idebugreference2--getmemorycontext.md)|Gets a memory context for this reference.|  
|[GetSize](../vs140/idebugreference2--getsize.md)|Gets the size, in bytes, of this reference.|  
|[SetReferenceType](../vs140/idebugreference2--setreferencetype.md)|Sets this reference type.|  
|[Compare](../vs140/idebugreference2--compare.md)|Compares this reference with another.|  
  
## Remarks  
  
> [!NOTE]
>  This use of "property" should not be confused with that meaning a member variable of a class, although an `IDebugReference2` can represent such an entity.  
  
 [IDebugProperty2](../vs140/idebugproperty2.md) represents a property, while `IDebugReference2` represents a reference to a property, typically a reference to an object in the program being debugged.  
  
 The main difference between a property and a reference is that a property refers to a named instance of an object, while a reference refers to an unnamed instance. For example, a property may refer to an object in the program's heap by `"a.b"`. Another property may refer to the same object as `"c.d"`. The way of referring to this property requires that `"a.b"` or `"c.d"` be in scope. A reference to this same object is nameless; the object can be referred to as long as the memory for that object is valid.  
  
 An `IDebugProperty2` interface can be thought of as a value with a name, a type, and an address. An `IDebugReference2`, on the other hand, can be thought of as a type and an address.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugProperty2::GetReference](../vs140/idebugproperty2--getreference.md)