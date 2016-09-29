---
title: "CFontHolder::GetFontHandle"
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
  - "CFontHolder.GetFontHandle"
  - "GetFontHandle"
  - "CFontHolder::GetFontHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFontHandle method"
ms.assetid: ed17316b-6c67-4333-b386-1835a30f1eef
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontHolder::GetFontHandle
Call this function to get a handle to a Windows font.  
  
## Syntax  
  
```  
  
      HFONT GetFontHandle( );  
HFONT GetFontHandle(  
   long cyLogical,  
   long cyHimetric   
);  
```  
  
#### Parameters  
 `cyLogical`  
 Height, in logical units, of the rectangle in which the control is drawn.  
  
 `cyHimetric`  
 Height, in `MM_HIMETRIC` units, of the control.  
  
## Return Value  
 A handle to the Font object; otherwise **NULL**.  
  
## Remarks  
 The ratio of `cyLogical` and `cyHimetric` is used to calculate the proper display size, in logical units, for the font's point size expressed in `MM_HIMETRIC` units:  
  
 Display size = (`cyLogical` / `cyHimetric`) X font size  
  
 The version with no parameters returns a handle to a font sized correctly for the screen.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CFontHolder Class](../vs140/cfontholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)