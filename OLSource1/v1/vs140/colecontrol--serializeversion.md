---
title: "COleControl::SerializeVersion"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SerializeVersion
  - COleControl.SerializeVersion
  - COleControl::SerializeVersion
dev_langs: 
  - C++
helpviewer_keywords: 
  - SerializeVersion method
ms.assetid: 184a7e14-f022-45a4-bb8f-d7b5a96a8e88
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::SerializeVersion
Serializes or initializes the state of a control's version information.  
  
## Syntax  
  
```  
  
      DWORD SerializeVersion(  
   CArchive& ar,  
   DWORD dwVersionDefault,  
   BOOL bConvert = TRUE   
);  
```  
  
#### Parameters  
 `ar`  
 A `CArchive` object to serialize to or from.  
  
 `dwVersionDefault`  
 The current version number of the control.  
  
 `bConvert`  
 Indicates whether persistent data should be converted to the latest format when it is saved, or maintained in the same format it had when it was loaded.  
  
## Return Value  
 The version number of the control. If the specified archive is loading, `SerializeVersion` returns the version loaded from that archive. Otherwise, it returns the currently loaded version.  
  
## Remarks  
 You can improve a control's binary persistence performance by using `SerializeVersion`, `SerializeExtent`, and `SerializeStockProps` to override **COleControl::Serialize**. For an example, see the code at [SerializeExtent](../vs140/colecontrol--serializeextent.md). For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SerializeExtent](../vs140/colecontrol--serializeextent.md)   
 [COleControl::SerializeStockProps](../vs140/colecontrol--serializestockprops.md)   
 [COleControl::ResetVersion](../vs140/colecontrol--resetversion.md)