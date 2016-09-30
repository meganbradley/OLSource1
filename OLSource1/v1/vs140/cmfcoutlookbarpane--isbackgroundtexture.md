---
title: "CMFCOutlookBarPane::IsBackgroundTexture"
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
  - "IsBackgroundTexture"
  - "CMFCOutlookBarPane::IsBackgroundTexture"
  - "CMFCOutlookBarPane.IsBackgroundTexture"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsBackgroundTexture method"
ms.assetid: 0fe54ca3-0480-4dfe-a878-c2a5c5c2d966
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarPane::IsBackgroundTexture
Determines whether there is a background image loaded for the Outlook bar pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if there is background image to display; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 You can add a background image by calling [CMFCOutlookBarPane::SetBackImage](../vs140/cmfcoutlookbarpane--setbackimage.md) function.  
  
 If there is no background image, the background is painted with a color specified by using [SetBackColor](../vs140/cmfcoutlookbarpane--setbackcolor.md).  
  
## Requirements  
 **Header:** afxoutlookbarpane.h  
  
## See Also  
 [CMFCOutlookBarPane Class](../vs140/cmfcoutlookbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)