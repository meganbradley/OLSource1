---
title: "COleControl::SerializeStockProps"
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
  - "COleControl::SerializeStockProps"
  - "COleControl.SerializeStockProps"
  - "SerializeStockProps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SerializeStockProps method"
ms.assetid: 96dd06e4-6f41-42d7-ac24-0c1a06a22ab1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SerializeStockProps
Serializes or initializes the state of the `COleControl` stock properties: Appearance, BackColor, BorderStyle, Caption, Enabled, Font, ForeColor, and Text.  
  
## Syntax  
  
```  
  
      void SerializeStockProps(  
   CArchive& ar   
);  
```  
  
#### Parameters  
 `ar`  
 A `CArchive` object to serialize to or from.  
  
## Remarks  
 For a description of stock properties, see [ActiveX Controls: Adding Stock Properties](../vs140/mfc-activex-controls--adding-stock-properties.md).  
  
 You can improve a control's binary persistence performance by using `SerializeStockProps`, `SerializeExtent`, and `SerializeVersion` to override **COleControl::Serialize**. For an example, see the code at [SerializeExtent](../vs140/colecontrol--serializeextent.md). For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SerializeExtent](../vs140/colecontrol--serializeextent.md)   
 [COleControl::SerializeVersion](../vs140/colecontrol--serializeversion.md)   
 [COleControl::ResetStockProps](../vs140/colecontrol--resetstockprops.md)