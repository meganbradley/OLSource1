---
title: "COleControl::GetStockTextMetrics"
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
  - "COleControl.GetStockTextMetrics"
  - "COleControl::GetStockTextMetrics"
  - "GetStockTextMetrics"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStockTextMetrics method"
ms.assetid: f038f57b-cd7f-4f2c-8afa-3762ea9b5771
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetStockTextMetrics
Measures the text metrics for the control's stock Font property, which can be selected with the [SelectStockFont](../vs140/colecontrol--selectstockfont.md) function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function will initialize the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with valid metrics information if successful, or fill the structure with zeros if not successful. Use this function instead of [GetTextMetrics](http://msdn.microsoft.com/library/windows/desktop/dd144941) when painting your control because controls, like any embedded OLE object, may be required to render themselves into a metafile.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure for the default font is refreshed when the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function is called. You should call this function only after selecting the stock font to assure the information it provides is valid.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)