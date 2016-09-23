---
title: "CFont::CreateFontIndirect"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CFont.CreateFontIndirect
  - CFont::CreateFontIndirect
  - LOGFONT
  - CreateFontIndirect
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateFontIndirect method
  - CFont class, initialization
  - structs
  - LOGFONT structure
ms.assetid: f9573b44-382a-40ab-b5d2-1769148c1816
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFont::CreateFontIndirect
Initializes a `CFont` object with the characteristics given in a [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)structure.  
  
## Syntax  
  
```  
  
      BOOL CreateFontIndirect(  
   const LOGFONT* lpLogFont   
);  
```  
  
#### Parameters  
 `lpLogFont`  
 Points to a `LOGFONT` structure that defines the characteristics of the logical font.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The font can subsequently be selected as the current font for any device.  
  
 This font has the characteristics specified in the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure. When the font is selected by using the [CDC::SelectObject](../vs140/cdc--selectobject.md) member function, the GDI font mapper attempts to match the logical font with an existing physical font. If the font mapper fails to find an exact match for the logical font, it provides an alternative font whose characteristics match as many of the requested characteristics as possible.  
  
 When you no longer need the `CFont` object created by the `CreateFontIndirect` function, use `CDC::SelectObject` to select a different font into the device context, then delete the `CFont` object that is no longer needed.  
  
## Example  
 [!code[NVC_MFCDocView#72](../vs140/codesnippet/CPP/cfont--createfontindirect_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFont Class](../vs140/cfont-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFont::CreateFont](../vs140/cfont--createfont.md)   
 [CFont::CreatePointFontIndirect](../vs140/cfont--createpointfontindirect.md)   
 [CDC::SelectObject](../vs140/cdc--selectobject.md)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)   
 [CreateFontIndirect](http://msdn.microsoft.com/library/windows/desktop/dd183500)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)