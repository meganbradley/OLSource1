---
title: "CDrawingManager::DrawAlpha"
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
  - "DrawAlpha"
  - "CDrawingManager::DrawAlpha"
  - "CDrawingManager.DrawAlpha"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawAlpha method"
ms.assetid: 290189c1-3eef-46bf-8768-9641383a981c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::DrawAlpha
Displays bitmaps that have transparent or semitransparent pixels.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context for the destination.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The destination rectangle.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the device context for the source.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The source rectangle.  
  
## Remarks  
 This method performs alpha-blending for two bitmaps. For more information about alpha-blending, see [AlphaBlend](http://msdn.microsoft.com/library/windows/desktop/dd183351) in the Windows SDK.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)