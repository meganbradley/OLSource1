---
title: "CDrawingManager::FillGradient2"
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
  - "CDrawingManager.FillGradient2"
  - "FillGradient2"
  - "CDrawingManager::FillGradient2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillGradient2 method"
ms.assetid: 32cdc703-3ee1-435d-8ef9-40c99c823d8c
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::FillGradient2
Fills a rectangular area with a specified color gradient.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The rectangular area to fill.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first color of the gradient.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The last color of the gradient.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An integer between 0 and 360. This parameter specifies the direction of the color gradient.  
  
## Remarks  
 Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to specify the direction of the color gradient. When you specify the direction of the color gradient, you also specify where the color gradient starts. A value of 0 for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> indicates the gradient starts from the top of the rectangle. As <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> increases, the starting location for the gradient moves in a counter-clockwise direction based on the angle.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class. This code snippet is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#37](../vs140/codesnippet/CPP/cdrawingmanager--fillgradient2_1.cpp)]  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)