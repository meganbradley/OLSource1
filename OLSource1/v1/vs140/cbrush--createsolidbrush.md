---
title: "CBrush::CreateSolidBrush"
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
  - "CBrush.CreateSolidBrush"
  - "CBrush::CreateSolidBrush"
  - "CreateSolidBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "solid color brushes"
  - "CreateSolidBrush method"
ms.assetid: 7cf61aef-04ec-46f6-9c0c-60d6befd9ed9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBrush::CreateSolidBrush
Initializes a brush with a specified solid color.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) structure that specifies the color of the brush. The color specifies an RGB value and can be constructed with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro in WINDOWS.H.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The brush can subsequently be selected as the current brush for any device context.  
  
 When an application has finished using the brush created by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, it should select the brush out of the device context.  
  
## Example  
 See the example for [CBrush::CBrush](../vs140/cbrush--cbrush.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBrush Class](../vs140/cbrush-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush::CreateBrushIndirect](../vs140/cbrush--createbrushindirect.md)   
 [CBrush::CreateDIBPatternBrush](../vs140/cbrush--createdibpatternbrush.md)   
 [CBrush::CreateHatchBrush](../vs140/cbrush--createhatchbrush.md)   
 [CBrush::CreatePatternBrush](../vs140/cbrush--createpatternbrush.md)   
 [CreateSolidBrush](http://msdn.microsoft.com/library/windows/desktop/dd183518)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)