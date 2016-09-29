---
title: "CDC::SetTextColor"
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
  - "CDC::SetTextColor"
  - "CDC.SetTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "SetTextColor method"
ms.assetid: 150dcfe8-4320-4950-89db-f594dbb68034
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetTextColor
Sets the text color to the specified color.  
  
## Syntax  
  
```  
  
      virtual COLORREF SetTextColor(  
   COLORREF crColor   
);  
```  
  
#### Parameters  
 `crColor`  
 Specifies the color of the text as an RGB color value.  
  
## Return Value  
 An RGB value for the previous text color.  
  
## Remarks  
 The system will use this text color when writing text to this device context and also when converting bitmaps between color and monochrome device contexts.  
  
 If the device cannot represent the specified color, the system sets the text color to the nearest physical color. The background color for a character is specified by the `SetBkColor` and `SetBkMode` member functions.  
  
## Example  
 See the example for [CWnd::OnCtlColor](../vs140/cwnd--onctlcolor.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTextColor](../vs140/cdc--gettextcolor.md)   
 [CDC::BitBlt](../vs140/cdc--bitblt.md)   
 [CDC::SetBkColor](../vs140/cdc--setbkcolor.md)   
 [CDC::SetBkMode](../vs140/cdc--setbkmode.md)   
 [SetTextColor](http://msdn.microsoft.com/library/windows/desktop/dd145093)