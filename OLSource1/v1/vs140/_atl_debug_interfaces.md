---
title: "_ATL_DEBUG_INTERFACES"
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
  - "ATL::_ATL_DEBUG_INTERFACES"
  - "ATL._ATL_DEBUG_INTERFACES"
  - "_ATL_DEBUG_INTERFACES"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_DEBUG_INTERFACES macro"
  - "_ATL_DEBUG_INTERFACES macro"
ms.assetid: 874b767b-c605-4afc-8d8b-819478d24224
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_DEBUG_INTERFACES
Define this macro before including any ATL header files to trace all `AddRef` and **Release** calls on your components' interfaces to the output window.  
  
## Syntax  
  
```  
  
#define _ATL_DEBUG_INTERFACES  
  
```  
  
## Remarks  
 The trace output will appear as shown below:  
  
 `ATL: QIThunk - 2008         AddRef  :   Object = 0x00d81ba0   Refcount = 1   CBug - IBug`  
  
 The first part of each trace will always be `ATL: QIThunk`. Next is a value identifying the particular *interface thunk* being used. An interface thunk is an object used to maintain a reference count and provide the tracing capability used here. A new interface thunk is created on every call to `QueryInterface` except for requests for the **IUnknown** interface (in this case, the same thunk is returned every time to comply with COM's identity rules).  
  
 Next you'll see `AddRef` or **Release** indicating which method was called. Following that, you'll see a value identifying the object whose interface reference count was changed. The value traced is the **this** pointer of the object.  
  
 The reference count that is traced is the reference count on that thunk after `AddRef` or **Release** was called. Note that this reference count may not match the reference count for the object. Each thunk maintains its own reference count to help you fully comply with COM's reference-counting rules.  
  
 The final piece of information traced is the name of the object and the interface being affected by the `AddRef` or **Release** call.  
  
 Any interface leaks that are detected when the server shuts down and `_Module.Term` is called will be logged like this:  
  
 `ATL: QIThunk - 2005         LEAK    :   Object = 0x00d81ca0   Refcount = 1   MaxRefCount = 1   CBug - IBug`  
  
 The information provided here maps directly to the information provided in the previous trace statements, so you can examine the reference counts throughout the whole lifetime of an interface thunk. In addition, you get an indication of the maximum reference count on that interface thunk.  
  
> [!NOTE]
>  `_ATL_DEBUG_INTERFACES` can be used in retail builds.  
  
## Tips  
  
-   You can see when a new interface thunk is created by looking for `AddRef` calls with a `Refcount` of 1.  
  
-   You can see when an interface thunk is destroyed by looking for `Release` calls with a `Refcount` of 0.  
  
-   The trace statements are output in a tab-separated format so you can easily cut and paste the information into a spreadsheet such as Microsoft Excel to provide advanced filtering, searching, and sorting capabilities.  
  
-   If your code seems to work fine when `_ATL_DEBUG_INTERFACES` is not defined, but causes access violations when the macro is defined, you almost certainly have a mismatched reference-counting bug in your client code, similar to the one shown below:  
  
     [!code[NVC_ATL_Utilities#124](../vs140/codesnippet/CPP/_atl_debug_interfaces_1.cpp)]  
  
     This code may appear to work under some common circumstances, but it is clearly buggy. For this code to work at all, it relies on implementation details of the COM object providing the `IBug` interface (`IBug` cannot be implemented as a tear-off interface) and it is location-dependent (the client must be in the same apartment as the `IBug` implementation). Use of the `_ATL_DEBUG_INTERFACES` macro can bring such bugs to light.  
  
## See Also  
 [Debugging and Error Reporting Macros](../vs140/debugging-and-error-reporting-macros.md)   
 [Macros](../vs140/atl-macros.md)