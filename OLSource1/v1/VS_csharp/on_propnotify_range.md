---
title: "ON_PROPNOTIFY_RANGE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXDISP/ON_PROPNOTIFY_RANGE"
  - "ON_PROPNOTIFY_RANGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_PROPNOTIFY_RANGE macro"
ms.assetid: e72bf6b1-c63a-42b4-a2e1-3a5d4650c809
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_PROPNOTIFY_RANGE
Use the `ON_PROPNOTIFY_RANGE` macro to define an event sink map entry for handling property notifications from any OLE control having a control ID within a contiguous range of IDs.  
  
## Syntax  
  
```  
  
ON_PROPNOTIFY_RANGE(  
theClass  
,   
idFirst  
,   
idLast  
,   
dispid  
,   
pfnRequest  
,   
pfnChanged )  
```  
  
#### Parameters  
 `theClass`  
 The class to which this event sink map belongs.  
  
 `idFirst`  
 The control ID of the first OLE control in the range.  
  
 `idLast`  
 The control ID of the last OLE control in the range.  
  
 `dispid`  
 The dispatch ID of the property involved in the notification.  
  
 `pfnRequest`  
 Pointer to a member function that handles the **OnRequestEdit** notification for this property. This function should have a **BOOL** return type and **UINT** and **BOOL\*** parameters. The function should set the parameter to **TRUE** to allow the property to change and **FALSE** to disallow. The function should return **TRUE** to indicate that notification was handled; otherwise **FALSE**.  
  
 `pfnChanged`  
 Pointer to a member function that handles the **OnChanged** notification for this property. The function should have a **BOOL** return type and a **UINT** parameter. The function should return **TRUE** to indicate that notification was handled; otherwise **FALSE**.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [ON_EVENT_RANGE](../VS_csharp/on_event_range.md)   
 [ON_PROPNOTIFY](../VS_csharp/on_propnotify.md)   
 [ON_EVENT](../VS_csharp/on_event.md)