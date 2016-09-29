---
title: "SINK_ENTRY"
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
  - "SINK_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SINK_ENTRY macro"
ms.assetid: 33a5fff6-5248-47c0-8cf4-8bdf760e86e5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SINK_ENTRY
Declares the handler function (`fn`) for the specified event (`dispid`), of the control identified by `id`.  
  
## Syntax  
  
```  
  
      SINK_ENTRY(   
   id,   
   dispid,   
   fn    
)  
```  
  
#### Parameters  
 `id`  
 [in] Identifies the control.  
  
 `dispid`  
 [in] Identifies the specified event.  
  
 `fn`  
 [in] Name of the event handler function. This function must use the **_stdcall** calling convention and have the appropriate dispinterface-style signature.  
  
## Example  
 [!code[NVC_ATL_Windowing#104](../VS_csharp/codesnippet/CPP/sink_entry_1.h)]  
  
## Remarks  
 CE ATL implementation of ActiveX event sinks only supports return values of type HRESULT or void from your event handler methods; any other return value is unsupported and its behavior is undefined.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Composite Control Macros](../VS_csharp/composite-control-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [Composite Control Fundamentals](../VS_csharp/atl-composite-control-fundamentals.md)   
 [BEGIN_SINK_MAP](../VS_csharp/begin_sink_map.md)   
 [SINK_ENTRY_EX](../VS_csharp/sink_entry_ex.md)