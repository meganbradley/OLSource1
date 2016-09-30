---
title: "CDrawingManager::GrayRect"
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
  - "CDrawingManager::GrayRect"
  - "CDrawingManager.GrayRect"
  - "GrayRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GrayRect method"
ms.assetid: 968e61cb-c3c5-4dfd-a4b9-ef6450cc85d1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::GrayRect
Fills a rectangle with a specified gray color.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The rectangular area to fill.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The percentage of gray you want in the rectangle.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The transparent color.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The color that this method uses for de-saturation if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to -1.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 For the parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, a lower value indicates a darker color.  
  
 The maximum value for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is 200. A value larger than 200 does not change the appearance of the rectangle. If the value is -1, this method uses <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to limit the saturation of the rectangle.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)