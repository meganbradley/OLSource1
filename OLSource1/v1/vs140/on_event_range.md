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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_EVENT_RANGE
Use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro to define an event handler function for an event fired by any OLE control having a control ID within a contiguous range of IDs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The class to which this event sink map belongs.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The control ID of the first OLE control in the range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The control ID of the last OLE control in the range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The dispatch ID of the event fired by the control.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to a member function that handles the event. This function should have a **BOOL** return type, a first parameter of type **UINT** (for the control ID), and additional parameter types that match the event's parameters (see <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). The function should return **TRUE** to indicate the event was handled; otherwise **FALSE**.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A sequence of **VTS_** constants that specifies the types of the parameters for the event. The first constant should be of type **VTS_I4**, for the control ID. These are the same constants that are used in dispatch map entries such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument is a space-separated list of values from the **VTS_** constants. One or more of these values separated by spaces (not commas) specifies the function's parameter list. For example:  
  
 [!code[NVC_MFCAutomation#11](../vs140/codesnippet/CPP/on_event_range_1.cpp)]  
  
 specifies a list containing a short integer followed by a **BOOL**.  
  
 For a list of the **VTS_** constants, see [EVENT_CUSTOM](../vs140/event_custom.md).  
  
## Example  
 The following example demonstrates an event handler, for the MouseDown event, implemented for three controls (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>). The event handler function, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, is declared in the header file of the dialog class (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) as:  
  
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