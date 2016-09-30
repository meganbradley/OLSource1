---
title: "CDrawingManager::DrawShadow"
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
  - "DrawShadow"
  - "CDrawingManager.DrawShadow"
  - "CDrawingManager::DrawShadow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawShadow method"
ms.assetid: a127fa52-5d73-409f-b3c9-f4f225ab9d02
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::DrawShadow
Draws a shadow for a rectangular area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A rectangular area in your application. The drawing manager will draw a shadow underneath this area.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The width and height of the shadow.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The minimum brightness of the shadow.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum brightness of the shadow.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a bitmap that contains the image for the bottom part of the shadow.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to a bitmap that contains the image for the shadow that is drawn on the right side of the rectangle.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The color of the shadow.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how the shadow is drawn. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> draws a shadow on the right side of the rectangle.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You can provide two valid bitmaps for the bottom and right shadows by using the parameters <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If these [CBitmap](../vs140/cbitmap-class.md) objects have an attached GDI object, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will use those bitmaps as the shadows. If the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameters do not have an attached GDI object, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> draws the shadow and attaches the bitmaps to the parameters. In future calls to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, you can provide these bitmaps to speed up the drawing process. For more information about the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class and GDI objects, see [Graphic Objects](../vs140/graphic-objects.md).  
  
 If either of these parameters is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> will automatically draw the shadow.  
  
 If you set <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the shadow will be drawn underneath and to the left of the rectangular area.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class. This code snippet is part of the [Prop Sheet Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_PropSheetDemo#1](../vs140/codesnippet/CPP/cdrawingmanager--drawshadow_1.cpp)]  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)