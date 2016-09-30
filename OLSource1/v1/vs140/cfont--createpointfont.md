---
title: "CFont::CreatePointFont"
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
  - "CFont.CreatePointFont"
  - "CFont::CreatePointFont"
  - "CreatePointFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePointFont method"
  - "CFont class, initialization"
ms.assetid: 211af19d-bddd-4ec5-8ad4-4f8528618909
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFont::CreatePointFont
This function provides a simple way to create a font of a specified typeface and point size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Requested font height in tenths of a point. (For instance, pass 120 to request a 12-point font.)  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or pointer to a null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 30 characters. The Windows **EnumFontFamilies** function can be used to enumerate all currently available fonts. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **NULL**, the GDI uses a device-independent typeface.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the [CDC](../vs140/cdc-class.md) object to be used to convert the height in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to logical units. If **NULL**, a screen device context is used for the conversion.  
  
## Return Value  
 Nonzero if successful, otherwise 0.  
  
## Remarks  
 It automatically converts the height in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to logical units using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 When you finish with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object created by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function, first select the font out of the device context, then delete the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
## Example  
 [!code[NVC_MFCDocView#73](../vs140/codesnippet/CPP/cfont--createpointfont_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFont Class](../vs140/cfont-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFont::CreatePointFontIndirect](../vs140/cfont--createpointfontindirect.md)   
 [CFont::CreateFont](../vs140/cfont--createfont.md)