---
title: "ON_EVENT_RANGE"
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
  - "ON_EVENT_RANGE"
  - "AFXDISP/ON_EVENT_RANGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_EVENT_RANGE macro"
ms.assetid: 27d6eac3-aa91-43cc-bdf1-e5a7585dc1cc
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_EVENT_RANGE
Use the `ON_EVENT_RANGE` macro to define an event handler function for an event fired by any OLE control having a control ID within a contiguous range of IDs.  
  
## Syntax  
  
```  
  
ON_EVENT_RANGE(  
theClass  
,   
idFirst  
,   
idLast  
,   
dispid  
,   
pfnHandler  
,   
vtsParams )  
```  
  
#### Parameters  
 `theClass`  
 The class to which this event sink map belongs.  
  
 `idFirst`  
 The control ID of the first OLE control in the range.  
  
 `idLast`  
 The control ID of the last OLE control in the range.  
  
 `dispid`  
 The dispatch ID of the event fired by the control.  
  
 `pfnHandler`  
 Pointer to a member function that handles the event. This function should have a **BOOL** return type, a first parameter of type **UINT** (for the control ID), and additional parameter types that match the event's parameters (see `vtsParams`). The function should return **TRUE** to indicate the event was handled; otherwise **FALSE**.  
  
 `vtsParams`  
 A sequence of **VTS_** constants that specifies the types of the parameters for the event. The first constant should be of type **VTS_I4**, for the control ID. These are the same constants that are used in dispatch map entries such as `DISP_FUNCTION`.  
  
## Remarks  
 The `vtsParams` argument is a space-separated list of values from the **VTS_** constants. One or more of these values separated by spaces (not commas) specifies the function's parameter list. For example:  
  
 [!code[NVC_MFCAutomation#11](../vs140/codesnippet/CPP/on_event_range_1.cpp)]  
  
 specifies a list containing a short integer followed by a **BOOL**.  
  
 For a list of the **VTS_** constants, see [EVENT_CUSTOM](../vs140/event_custom.md).  
  
## Example  
 The following example demonstrates an event handler, for the MouseDown event, implemented for three controls (`IDC_MYCTRL1` through `IDC_MYCTRL3`). The event handler function, `OnRangeMouseDown`, is declared in the header file of the dialog class (`CMyDlg`) as:  
  
 [!code[NVC_MFCAutomation#12](../vs140/codesnippet/CPP/on_event_range_2.h)]  
  
 The code below is defined in the implementation file of the dialog class.  
  
 [!code[NVC_MFCAutomation#13](../vs140/codesnippet/CPP/on_event_range_3.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_EVENT](../vs140/on_event.md)   
 [ON_PROPNOTIFY](../vs140/on_propnotify.md)   
 [ON_PROPNOTIFY_RANGE](../vs140/on_propnotify_range.md)