---
title: "BEGIN_SINK_MAP"
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
  - "ATL.BEGIN_SINK_MAP"
  - "ATL::BEGIN_SINK_MAP"
  - "BEGIN_SINK_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sink maps"
  - "event sink maps, ATL"
  - "BEGIN_SINK_MAP macro"
ms.assetid: 32542b3d-ac43-4139-8ac4-41c48481744f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_SINK_MAP
Declares the beginning of the event sink map for the composite control.  
  
## Syntax  
  
```  
  
BEGIN_SINK_MAP( _class )  
```  
  
#### Parameters  
 `_class`  
 [in] Specifies the control.  
  
## Example  
 [!code[NVC_ATL_Windowing#104](../vs140/codesnippet/CPP/begin_sink_map_1.h)]  
  
## Remarks  
 CE ATL implementation of ActiveX event sinks only supports return values of type HRESULT or void from your event handler methods; any other return value is unsupported and its behavior is undefined.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Composite Control Macros](../vs140/composite-control-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [SINK_ENTRY](../vs140/sink_entry.md)   
 [END_SINK_MAP](../vs140/end_sink_map.md)