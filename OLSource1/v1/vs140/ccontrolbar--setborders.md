---
title: "CControlBar::SetBorders"
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
  - "CControlBar::SetBorders"
  - "SetBorders"
  - "CControlBar.SetBorders"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBorders method"
  - "CControlBar class, attributes"
ms.assetid: ab381f6c-2dc6-46af-baf0-0ba408f73df1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::SetBorders
Call this function to set the size of the control bar's borders.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *cxLeft*  
 The width (in pixels) of the control bar's left border.  
  
 *cyTop*  
 The height (in pixels) of the control bar's top border.  
  
 *cxRight*  
 The width (in pixels) of the control bar's right border.  
  
 *cyBottom*  
 The height (in pixels) of the control bar's bottom border.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CRect](../vs140/crect-class.md) object that contains the current width (in pixels)of each border of the control bar object.  
  
## Example  
 The following code example sets the top and bottom borders of the control bar to 5 pixels, and the left and right borders to 2 pixels:  
  
 [!code[NVC_MFCControlLadenDialog#61](../vs140/codesnippet/CPP/ccontrolbar--setborders_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::GetBorders](../vs140/ccontrolbar--getborders.md)