---
title: "CDC::SetBkMode"
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
  - "CDC::SetBkMode"
  - "CDC.SetBkMode"
  - "SetBkMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "SetBkMode method"
ms.assetid: 671fedb7-6648-4a69-a624-34a57be86112
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetBkMode
Sets the background mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nBkMode*  
 Specifies the mode to be set. This parameter can be either of the following values:  
  
-   **OPAQUE** Background is filled with the current background color before the text, hatched brush, or pen is drawn. This is the default background mode.  
  
-   **TRANSPARENT** Background is not changed before drawing.  
  
## Return Value  
 The previous background mode.  
  
## Remarks  
 The background mode defines whether the system removes existing background colors on the drawing surface before drawing text, hatched brushes, or any pen style that is not a solid line.  
  
## Example  
 See the example for [CWnd::OnCtlColor](../vs140/cwnd--onctlcolor.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetBkColor](../vs140/cdc--getbkcolor.md)   
 [CDC::GetBkMode](../vs140/cdc--getbkmode.md)   
 [CDC::SetBkColor](../vs140/cdc--setbkcolor.md)   
 [SetBkMode](http://msdn.microsoft.com/library/windows/desktop/dd162965)