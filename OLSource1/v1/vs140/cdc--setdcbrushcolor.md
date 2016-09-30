---
title: "CDC::SetDCBrushColor"
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
  - "CDC.SetDCBrushColor"
  - "CDC::SetDCBrushColor"
  - "SetDCBrushColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "SetDCBrushColor method"
ms.assetid: 677688cd-c6dc-4e70-9056-2f235a561d9f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetDCBrushColor
Sets the current device context (DC) brush color to the specified color value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the new brush color.  
  
## Return Value  
 If the function succeeds, the return value specifies the previous DC brush color as a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value.  
  
 If the function fails, the return value is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method emulates the functionality of the function [SetDCBrushColor](http://msdn.microsoft.com/library/windows/desktop/dd162969), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDCBrushColor](../vs140/cdc--getdcbrushcolor.md)