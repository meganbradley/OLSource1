---
title: "ON_PROPNOTIFY"
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
  - "ON_PROPNOTIFY"
  - "AFXCTL/ON_PROPNOTIFY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_PROPNOTIFY macro"
ms.assetid: 512c824e-ab5f-4880-8c5a-cac308e94b57
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_PROPNOTIFY
Use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro to define an event sink map entry for handling property notifications from an OLE control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The class to which this event sink map belongs.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The control ID of the OLE control.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The dispatch ID of the property involved in the notification.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a member function that handles the **OnRequestEdit** notification for this property. This function should have a **BOOL** return type and a **BOOL\*** parameter. This function should set the parameter to **TRUE** to allow the property to change and **FALSE** to disallow. The function should return **TRUE** to indicate the notification was handled; otherwise **FALSE**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to a member function that handles the **OnChanged** notification for this property. The function should have a **BOOL** return type and a **UINT** parameter. The function should return **TRUE** to indicate that notification was handled; otherwise **FALSE**.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument is a space-separated list of values from the **VTS_** constants. One or more of these values separated by spaces (not commas) specifies the function's parameter list. For example:  
  
 [!code[NVC_MFCAutomation#11](../vs140/codesnippet/CPP/on_propnotify_1.cpp)]  
  
 specifies a list containing a short integer followed by a **BOOL**.  
  
 For a list of the **VTS_** constants, see [EVENT_CUSTOM](../vs140/event_custom.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_EVENT_RANGE](../vs140/on_event_range.md)   
 [ON_PROPNOTIFY_RANGE](../vs140/on_propnotify_range.md)