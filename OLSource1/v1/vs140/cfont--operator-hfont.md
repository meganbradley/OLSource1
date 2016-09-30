---
title: "CFont::operator HFONT"
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
  - "CFont::operatorHFONT"
  - "CFont.operatorHFONT"
  - "operatorHFONT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFont class, attributes"
  - "operator HFONT"
ms.assetid: df583301-da1e-4da8-98a0-b2f399e2aa24
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFont::operator HFONT
Use this operator to get the Windows GDI handle of the font attached to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The handle of the Windows GDI font object attached to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if successful; otherwise **NULL**.  
  
## Remarks  
 Since this operator is automatically used for conversions from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to [Fonts and Text](http://msdn.microsoft.com/library/windows/desktop/dd144819), you can pass <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> objects to functions that expect **HFONT**s.  
  
 For more information about using graphic objects, see [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#77](../vs140/codesnippet/CPP/cfont--operator-hfont_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFont Class](../vs140/cfont-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)