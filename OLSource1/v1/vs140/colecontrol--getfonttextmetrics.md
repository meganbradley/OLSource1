---
title: "COleControl::GetFontTextMetrics"
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
  - "COleControl.GetFontTextMetrics"
  - "GetFontTextMetrics"
  - "COleControl::GetFontTextMetrics"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFontTextMetrics method"
ms.assetid: 7f45fe8f-d574-4356-a336-e629220254b2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetFontTextMetrics
Measures the text metrics for any <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object owned by the control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Reference to a [CFontHolder](../vs140/cfontholder-class.md) object.  
  
## Remarks  
 Such a font can be selected with the [COleControl::SelectFontObject](../vs140/colecontrol--selectfontobject.md) function. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will initialize the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with valid metrics information about <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>'s font if successful, or fill the structure with zeros if not successful. You should use this function instead of [GetTextMetrics](http://msdn.microsoft.com/library/windows/desktop/dd144941) when painting your control because controls, like any embedded OLE object, may be required to render themselves into a metafile.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure for the default font is refreshed when the [SelectFontObject](../vs140/colecontrol--selectfontobject.md) function is called. You should call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> only after selecting the stock Font property to assure the information it provides is valid.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)