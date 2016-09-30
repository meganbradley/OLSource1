---
title: "CMFCToolTipCtrl::OnDrawLabel"
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
  - "CMFCToolTipCtrl.OnDrawLabel"
  - "OnDrawLabel"
  - "CMFCToolTipCtrl::OnDrawLabel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawLabel method"
ms.assetid: 86a903db-dc59-4cb9-8799-8313d52d49df
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolTipCtrl::OnDrawLabel
Draws the label of a tooltip, or calculates the size of the label.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Bounding rectangle of the label area.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the label will not be drawn.  
  
## Return Value  
 Size of the label, in pixels.  
  
## Remarks  
 Override this method in a derived class if you want to customize the appearance of the tooltip label.  
  
## Requirements  
 **Header:** afxToolTipCtrl.h  
  
## See Also  
 [CMFCToolTipCtrl Class](../vs140/cmfctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)