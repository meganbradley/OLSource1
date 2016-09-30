---
title: "CMFCRibbonColorButton::UpdateColor"
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
  - "CMFCRibbonColorButton::UpdateColor"
  - "CMFCRibbonColorButton.UpdateColor"
  - "UpdateColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateColor method"
ms.assetid: bee06f5b-3e0d-41ba-b22a-9bc431af4526
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonColorButton::UpdateColor
Called by the framework when the user selects a color from the color table displayed when the user clicks the color button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A color selected by the user.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method changes the currently selected button's color and notifies its parent by sending a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> message with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> standard notification. Use the [GetColor](../vs140/cmfcribboncolorbutton--getcolor.md) method to retrieve the selected color.  
  
## Requirements  
 **Header:** afxribboncolorbutton.h  
  
## See Also  
 [CMFCRibbonColorButton Class](../vs140/cmfcribboncolorbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)