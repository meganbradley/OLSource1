---
title: "CFont::CreatePointFontIndirect"
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
  - "CreatePointFontIndirect"
  - "CFont.CreatePointFontIndirect"
  - "CFont::CreatePointFontIndirect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePointFontIndirect method"
  - "CFont class, initialization"
ms.assetid: dc8fdbfa-1b87-42ce-90a1-50de8c0883ec
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFont::CreatePointFontIndirect
This function is the same as [CreateFontIndirect](../vs140/cfont--createfontindirect.md) except that the **lfHeight** member of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is interpreted in tenths of a point rather than device units.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure that defines the characteristics of the logical font. The **lfHeight** member of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure is measured in tenths of a point rather than logical units. (For instance, set **lfHeight** to 120 to request a 12-point font.)  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the [CDC](../vs140/cdc-class.md) object to be used to convert the height in **lfHeight** to logical units. If **NULL**, a screen device context is used for the conversion.  
  
## Return Value  
 Nonzero if successful, otherwise 0.  
  
## Remarks  
 This function automatically converts the height in **lfHeight** to logical units using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> before passing the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure on to Windows.  
  
 When you finish with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object created by the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function, first select the font out of the device context, then delete the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
## Example  
 [!code[NVC_MFCDocView#74](../vs140/codesnippet/CPP/cfont--createpointfontindirect_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFont Class](../vs140/cfont-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFont::CreatePointFont](../vs140/cfont--createpointfont.md)   
 [CFont::CreateFontIndirect](../vs140/cfont--createfontindirect.md)