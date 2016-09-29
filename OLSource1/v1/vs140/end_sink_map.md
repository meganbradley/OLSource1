---
title: "END_SINK_MAP"
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
  - "END_SINK_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "END_SINK_MAP macro"
ms.assetid: c8bb87a0-b224-46e5-9edc-fc4d7f1129b4
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# END_SINK_MAP
Declares the end of the event sink map for the composite control.  
  
## Syntax  
  
```  
  
END_SINK_MAP( )  
  
```  
  
## Example  
 [!code[NVC_ATL_Windowing#104](../vs140/codesnippet/CPP/end_sink_map_1.h)]  
  
## Remarks  
 CE ATL implementation of ActiveX event sinks only supports return values of type HRESULT or void from your event handler methods; any other return value is unsupported and its behavior is undefined.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Composite Control Macros](../vs140/composite-control-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [BEGIN_SINK_MAP](../vs140/begin_sink_map.md)   
 [SINK_ENTRY](../vs140/sink_entry.md)