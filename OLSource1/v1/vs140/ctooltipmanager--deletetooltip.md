---
title: "CTooltipManager::DeleteToolTip"
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
  - "CTooltipManager.DeleteToolTip"
  - "DeleteToolTip"
  - "CTooltipManager::DeleteToolTip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteToolTip method"
ms.assetid: 118d2955-4726-446c-9a36-f679343938e0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTooltipManager::DeleteToolTip
Deletes a tooltip control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a pointer to a tooltip to be destroyed.  
  
## Remarks  
 Call this method for each [CToolTipCtrl](../vs140/ctooltipctrl-class.md) that was created by [CTooltipManager::CreateToolTip](../vs140/ctooltipmanager--createtooltip.md). The parent control should call this method from its <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> handler. This is required to correctly remove the tooltip from the framework. This method sets <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> before it returns.  
  
## Requirements  
 **Header:** afxtooltipmanager.h  
  
## See Also  
 [CTooltipManager Class](../vs140/ctooltipmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)