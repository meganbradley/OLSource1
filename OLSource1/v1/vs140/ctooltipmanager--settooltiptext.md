---
title: "CTooltipManager::SetTooltipText"
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
  - "CTooltipManager.SetTooltipText"
  - "CTooltipManager::SetTooltipText"
  - "SetTooltipText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTooltipText method"
ms.assetid: bffebc0e-d176-4e6c-8ef1-dfa0a98decf0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTooltipManager::SetTooltipText
Sets the text and description for a tooltip.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a TOOLINFO object.  
  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the tooltip control for which to set the text and description.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the type of control with which this tooltip is associated.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The text to set as the tooltip text.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the tooltip description. Can be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be the same value as the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter of [CMFCTooltipManager::CreateToolTip](../vs140/ctooltipmanager--createtooltip.md) when you created the tooltip.  
  
## Requirements  
 **Header:** afxtooltipmanager.h  
  
## See Also  
 [CTooltipManager Class](../vs140/ctooltipmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)