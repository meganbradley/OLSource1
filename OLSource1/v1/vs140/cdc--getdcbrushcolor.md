---
title: "CDC::GetDCBrushColor"
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
  - "CDC.GetDCBrushColor"
  - "GetDCBrushColor"
  - "CDC::GetDCBrushColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "GetDCBrushColor method"
ms.assetid: 8ccc197c-611b-4ea0-a1cc-5dc083d00a55
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetDCBrushColor
Retrieves the current brush color.  
  
## Syntax  
  
```  
  
COLORREF GetDCBrushColor( ) const;  
  
```  
  
## Return Value  
 If the function succeeds, the return value is the [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value for the current brush color.  
  
 If the function fails, the return value is **CLR_INVALID**.  
  
## Remarks  
 This member function emulates the functionality of the function [GetDCBrushColor](http://msdn.microsoft.com/library/windows/desktop/dd144872), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetDCBrushColor](../vs140/cdc--setdcbrushcolor.md)