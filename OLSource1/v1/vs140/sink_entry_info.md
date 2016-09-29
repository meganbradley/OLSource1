---
title: "SINK_ENTRY_INFO"
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
  - "SINK_ENTRY_INFO"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SINK_ENTRY_INFO macro"
ms.assetid: 1a0ae260-2c82-4926-a537-db01e5f206a7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SINK_ENTRY_INFO
Use the `SINK_ENTRY_INFO` macro within an event sink map to provide the information needed by [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md) to route events to the relevant handler function.  
  
## Syntax  
  
```  
  
      SINK_ENTRY_INFO(   
   id,   
   iid,   
   dispid,   
   fn,   
   info   
)  
```  
  
#### Parameters  
 `id`  
 [in] Unsigned integer identifying the event source. This value must match the `nID` template parameter used in the related [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md) base class.  
  
 `iid`  
 [in] IID identifying the dispatch interface.  
  
 `dispid`  
 [in] DISPID identifying the specified event.  
  
 `fn`  
 [in] Name of the event handler function. This function must use the **_stdcall** calling convention and have the appropriate dispinterface-style signature.  
  
 `info`  
 [in] Type information for the event handler function. This type information is provided in the form of a pointer to an `_ATL_FUNC_INFO` structure. `CC_CDECL` is the only option supported in Windows CE for the `CALLCONV` field of the `_ATL_FUNC_INFO` structure. Any other value is unsupported thus its behavior undefined.  
  
## Remarks  
 The first four macro parameters are the same as those for the [SINK_ENTRY_EX](../vs140/sink_entry_ex.md) macro. The final parameter provides type information for the event. CE ATL implementation of ActiveX event sinks only supports return values of type HRESULT or void from your event handler methods; any other return value is unsupported and its behavior is undefined.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Composite Control Macros](../vs140/composite-control-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [BEGIN_SINK_MAP](../vs140/begin_sink_map.md)   
 [SINK_ENTRY](../vs140/sink_entry.md)   
 [SINK_ENTRY_EX](../vs140/sink_entry_ex.md)   
 [IDispEventSimpleImpl Class](../vs140/idispeventsimpleimpl-class.md)   
 [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md)