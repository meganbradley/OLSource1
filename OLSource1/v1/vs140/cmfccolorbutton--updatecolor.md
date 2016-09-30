---
title: "CMFCColorButton::UpdateColor"
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
  - "CMFCColorButton::UpdateColor"
  - "CMFCColorButton.UpdateColor"
  - "UpdateColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateColor method"
ms.assetid: d8af72f8-ddef-4957-a5f5-06b7411744e1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorButton::UpdateColor
Called by the framework when the user selects a color from the color bar that displays when the user clicks the color button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A color selected by the user.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function changes the currently selected button's color and notifies its parent by sending a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> message with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> standard notification. Use the [GetColor](../vs140/cmfccolorbutton--getcolor.md) method to retrieve the selected color.  
  
## Requirements  
 **Header:** afxcolorbutton.h  
  
## See Also  
 [CMFCColorButton Class](../vs140/cmfccolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)