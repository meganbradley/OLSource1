---
title: "CDC::DrawEdge"
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
  - "DrawEdge"
  - "CDC::DrawEdge"
  - "CDC.DrawEdge"
  - "BF_"
  - "BDR_"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BDR_ flags"
  - "Rect edges"
  - "drawing, edges"
  - "BF_ flags"
  - "DrawEdge function"
  - "CDC class, simple drawing functions"
  - "borders, DrawEdge function"
  - "edges of line drawing"
ms.assetid: e10d0fe1-f64d-4170-b38a-e0dd581cd5a3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DrawEdge
Call this member function to draw the edges of a rectangle of the specified type and style.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a **RECT** structure that contains the logical coordinates of the rectangle.  
  
 *nEdge*  
 Specifies the type of inner and outer edge to draw. This parameter must be a combination of one inner-border flag and one outer-border flag. See [DrawEdge](http://msdn.microsoft.com/library/windows/desktop/dd162477) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a table of the parameter's types.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The flags that specify the type of border to be drawn. See <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a table of the parameter's values. For diagonal lines, the **BF_RECT** flags specify the end point of the vector bounded by the rectangle parameter.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DrawEdge](http://msdn.microsoft.com/library/windows/desktop/dd162477)