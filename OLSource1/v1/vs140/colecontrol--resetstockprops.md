---
title: "COleControl::ResetStockProps"
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
  - "COleControl.ResetStockProps"
  - "COleControl::ResetStockProps"
  - "ResetStockProps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ResetStockProps method"
ms.assetid: 8cf24674-5011-4d66-82e8-44bdaeb8b36b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::ResetStockProps
Initializes the state of the `COleControl` stock properties to their default values.  
  
## Syntax  
  
```  
  
void ResetStockProps( );  
```  
  
## Remarks  
 The properties are: Appearance, BackColor, BorderStyle, Caption, Enabled, Font, ForeColor, hWnd, and Text. For a description of stock properties, see [ActiveX Controls: Adding Stock Properties](../vs140/mfc-activex-controls--adding-stock-properties.md).  
  
 You can improve a control's binary initialization performance by using `ResetStockProps` and `ResetVersion` to override `COleControl::OnResetState`. See the example below. For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
## Example  
 [!code[NVC_MFCAxCtl#7](../vs140/codesnippet/CPP/colecontrol--resetstockprops_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::ResetVersion](../vs140/colecontrol--resetversion.md)   
 [COleControl::SerializeStockProps](../vs140/colecontrol--serializestockprops.md)