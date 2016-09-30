---
title: "CPalette::GetPaletteEntries"
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
  - "CPalette.GetPaletteEntries"
  - "GetPaletteEntries"
  - "CPalette::GetPaletteEntries"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPaletteEntries method"
  - "CPalette class, attributes"
ms.assetid: f53416ea-eb34-4017-a1cb-c87db2fdaa5e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPalette::GetPaletteEntries
Retrieves a range of palette entries in a logical palette.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the first entry in the logical palette to be retrieved.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of entries in the logical palette to be retrieved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to an array of [PALETTEENTRY](http://msdn.microsoft.com/library/windows/desktop/dd162769) data structures to receive the palette entries. The array must contain at least as many data structures as specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 The number of entries retrieved from the logical palette; 0 if the function failed.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPalette Class](../vs140/cpalette-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetPaletteEntries](http://msdn.microsoft.com/library/windows/desktop/dd144907)   
 [CPalette::SetPaletteEntries](../vs140/cpalette--setpaletteentries.md)