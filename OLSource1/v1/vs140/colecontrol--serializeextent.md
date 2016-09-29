---
title: "COleControl::SerializeExtent"
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
  - "COleControl.SerializeExtent"
  - "SerializeExtent"
  - "COleControl::SerializeExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SerializeExtent method"
ms.assetid: 4573e344-4f90-4f50-9470-85534213481c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SerializeExtent
Serializes or initializes the state of the display space allotted to the control.  
  
## Syntax  
  
```  
  
      void SerializeExtent(  
   CArchive& ar   
);  
```  
  
#### Parameters  
 `ar`  
 A `CArchive` object to serialize to or from.  
  
## Remarks  
 You can improve a control's binary persistence performance by using `SerializeExtent`, `SerializeStockProps`, and `SerializeVersion` to override **COleControl::Serialize**. See the example below. For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
## Example  
 [!code[NVC_MFCAxCtl#8](../vs140/codesnippet/CPP/colecontrol--serializeextent_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SerializeStockProps](../vs140/colecontrol--serializestockprops.md)   
 [COleControl::SerializeVersion](../vs140/colecontrol--serializeversion.md)