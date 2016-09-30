---
title: "CStatic::GetBitmap"
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
  - "CStatic.GetBitmap"
  - "CStatic::GetBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBitmap method"
  - "CStatic class, operations"
ms.assetid: 9c2f32ea-a92b-4222-93e0-16f54887f784
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatic::GetBitmap
Gets the handle of the bitmap, previously set with [SetBitmap](../vs140/cstatic--setbitmap.md), that is associated with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A handle to the current bitmap, or **NULL** if no bitmap has been set.  
  
## Example  
 [!code[NVC_MFC_CStatic#3](../vs140/codesnippet/CPP/cstatic--getbitmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::SetBitmap](../vs140/cstatic--setbitmap.md)   
 [STM_GETIMAGE](http://msdn.microsoft.com/library/windows/desktop/bb760778)   
 [Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183377)