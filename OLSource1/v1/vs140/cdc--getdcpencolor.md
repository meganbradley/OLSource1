---
title: "CDC::GetDCPenColor"
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
  - "CDC::GetDCPenColor"
  - "CDC.GetDCPenColor"
  - "GetDCPenColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "GetDCPenColor method"
ms.assetid: 76db090f-0e73-4f20-803a-7c1f7679401f
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetDCPenColor
Retrieves the current pen color.  
  
## Syntax  
  
```  
  
COLORREF GetDCPenColor( ) const;  
  
```  
  
## Return Value  
 If the function succeeds, the return value is the [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value for the current pen color.  
  
 If the function fails, the return value is **CLR_INVALID**.  
  
## Remarks  
 This member function utilizes the Win32 function [GetDCPenColor](http://msdn.microsoft.com/library/windows/desktop/dd144875), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetDCPenColor](../vs140/cdc--setdcpencolor.md)