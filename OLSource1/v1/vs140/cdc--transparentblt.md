---
title: "CDC::TransparentBlt"
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
  - "CDC.TransparentBlt"
  - "CDC::TransparentBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TransparentBlt method"
  - "transferring color data"
ms.assetid: 225ba60a-943a-434b-ab48-7bcf3955dda7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::TransparentBlt
Call this member function to transfer a bit-block of the color data, which corresponds to a rectangle of pixels from the specified source device context, into a destination device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the x-coordinate, in logical units, of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the y-coordinate, in logical units, of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the source device context.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the x-coordinate, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the y-coordinate, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The RGB color in the source bitmap to treat as transparent.  
  
## Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> allows for transparency; that is, the RGB color indicated by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is rendered transparent for the transfer.  
  
 For more information, see [TransparentBlt](http://msdn.microsoft.com/library/windows/desktop/dd145141) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::AlphaBlend](../vs140/cdc--alphablend.md)   
 [CDC::SetStretchBltMode](../vs140/cdc--setstretchbltmode.md)