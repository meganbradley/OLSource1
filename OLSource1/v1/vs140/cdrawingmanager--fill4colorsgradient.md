---
title: "CDrawingManager::Fill4ColorsGradient"
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
  - "Fill4ColorsGradient"
  - "CDrawingManager::Fill4ColorsGradient"
  - "CDrawingManager.Fill4ColorsGradient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Fill4ColorsGradient method"
ms.assetid: f2ca6395-f07f-4976-99b4-00f0da6f6a21
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::Fill4ColorsGradient
Fills a rectangular area with two color gradients.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The rectangle to fill.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The initial color for the first color gradient.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The final color for the first color gradient.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The initial color for the second color gradient.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The final color for the second color gradient.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> colors a horizontal or vertical gradient. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> indicates a horizontal gradient.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An integer from 0-100. This value indicates the percentage of the rectangle to fill with the first color gradient.  
  
## Remarks  
 When a rectangle is filled with two color gradients, they are either located above each other or next to each other, depending on the value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Each color gradient is calculated independently with the method [CDrawingManager::FillGradient](../vs140/cdrawingmanager--fillgradient.md).  
  
 This method generates an assertion failure if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is less than 0 or more than 100.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)