---
title: "CDC::SetDCPenColor"
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
  - "SetDCPenColor"
  - "CDC::SetDCPenColor"
  - "CDC.SetDCPenColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "SetDCPenColor method"
ms.assetid: dfe9ea6b-ce7c-4b68-9260-f01f176b256d
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetDCPenColor
Sets the current device context (DC) pen color to the specified color value.  
  
## Syntax  
  
```  
  
      COLORREF SetDCPenColor(  
   COLORREF crColor  
);  
```  
  
#### Parameters  
 `crColor`  
 Specifies the new pen color.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 This member function utilizes the Win32 function [SetDCPenColor](http://msdn.microsoft.com/library/windows/desktop/dd162970), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDCPenColor](../vs140/cdc--getdcpencolor.md)