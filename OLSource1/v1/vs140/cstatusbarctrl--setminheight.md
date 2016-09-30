---
title: "CStatusBarCtrl::SetMinHeight"
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
  - "CStatusBarCtrl.SetMinHeight"
  - "SetMinHeight"
  - "CStatusBarCtrl::SetMinHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMinHeight method"
  - "status bar controls, setting minumum height"
  - "CStatusBarCtrl class, attributes"
ms.assetid: 641b6dd0-c9fa-4526-919d-af588c2806dc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::SetMinHeight
Sets the minimum height of a status bar control's drawing area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Minimum height, in pixels, of the control.  
  
## Remarks  
 The minimum height is the sum of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and twice the width, in pixels, of the vertical border of the status bar control.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#9](../vs140/codesnippet/CPP/cstatusbarctrl--setminheight_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::GetRect](../vs140/cstatusbarctrl--getrect.md)   
 [CStatusBarCtrl::GetBorders](../vs140/cstatusbarctrl--getborders.md)