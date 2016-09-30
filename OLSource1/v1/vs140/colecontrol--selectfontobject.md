---
title: "COleControl::SelectFontObject"
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
  - "SelectFontObject"
  - "COleControl.SelectFontObject"
  - "COleControl::SelectFontObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectFontObject method"
ms.assetid: 6efb627a-b791-4a09-9056-1c9cc98533cd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SelectFontObject
Selects a font into a device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a device context object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to the [CFontHolder](../vs140/cfontholder-class.md) object representing the font to be selected.  
  
## Return Value  
 A pointer to the previously selected font. When the caller has finished all drawing operations that use *fontHolder,* it should reselect the previously selected font by passing it as a parameter to [CDC::SelectObject](../vs140/cdc--selectobject.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)