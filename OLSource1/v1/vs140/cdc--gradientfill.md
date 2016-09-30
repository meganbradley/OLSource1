---
title: "CDC::GradientFill"
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
  - "GradientFill"
  - "CDC.GradientFill"
  - "CDC::GradientFill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "filling images"
  - "filling triangles"
  - "filling rectangles"
  - "GradientFill method"
ms.assetid: 934ed8c3-35f5-40fb-98bd-6919acff262b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GradientFill
Call this member function to fill rectangle and triangle structures with color that smoothly fades from one side to the other.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pVertices*  
 Pointer to an array of [TRIVERTEX](http://msdn.microsoft.com/library/windows/desktop/dd145142) structures that each define a triangle vertex.  
  
 *nVertices*  
 The number of vertices.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Array of [GRADIENT_TRIANGLE](http://msdn.microsoft.com/library/windows/desktop/dd144959) structures in triangle mode, or an array of [GRADIENT_RECT](http://msdn.microsoft.com/library/windows/desktop/dd144958) structures in rectangle mode.  
  
 *nMeshElements*  
 The number of elements (triangles or rectangles) in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies gradient fill mode. For a list of possible values, see [GradientFill](http://msdn.microsoft.com/library/windows/desktop/dd144957) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
## Remarks  
 For more information, see <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [EMRGRADIENTFILL](http://msdn.microsoft.com/library/windows/desktop/dd162542)