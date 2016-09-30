---
title: "COleControl::SelectStockFont"
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
  - "SelectStockFont"
  - "COleControl::SelectStockFont"
  - "COleControl.SelectStockFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectStockFont method"
ms.assetid: 2e1fbe3d-db30-4491-a52e-4deff0a70c7f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SelectStockFont
Selects the stock Font property into a device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The device context into which the font will be selected.  
  
## Return Value  
 A pointer to the previously selected <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. You should use [CDC::SelectObject](../vs140/cdc--selectobject.md) to select this font back into the device context when you are finished.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetFont](../vs140/colecontrol--getfont.md)   
 [COleControl::SetFont](../vs140/colecontrol--setfont.md)