---
title: "CFont::CFont"
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
  - "CFont.CFont"
  - "CFont::CFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFont class, construction/destruction"
  - "CFont class, constructor"
ms.assetid: a8f47b1f-d579-4991-82a8-513da631ed02
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFont::CFont
Constructs a `CFont` object.  
  
## Syntax  
  
```  
  
CFont( );  
```  
  
## Remarks  
 The resulting object must be initialized with `CreateFont`, `CreateFontIndirect`, `CreatePointFont`, or `CreatePointFontIndirect` before it can be used.  
  
## Example  
 [!code[NVC_MFCDocView#70](../vs140/codesnippet/CPP/cfont--cfont_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFont Class](../vs140/cfont-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFont::CreateFontIndirect](../vs140/cfont--createfontindirect.md)   
 [CFont::CreateFont](../vs140/cfont--createfont.md)   
 [CFont::CreatePointFont](../vs140/cfont--createpointfont.md)   
 [CFont::CreatePointFontIndirect](../vs140/cfont--createpointfontindirect.md)   
 [EnumFonts](http://msdn.microsoft.com/library/windows/desktop/dd162622)