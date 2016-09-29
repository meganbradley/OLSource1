---
title: "CMFCPropertyGridProperty::OnCtlColor"
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
  - "CMFCPropertyGridProperty.OnCtlColor"
  - "OnCtlColor"
  - "CMFCPropertyGridProperty::OnCtlColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCtlColor method"
ms.assetid: 120651a8-d4e6-4d14-9bd2-d95e0aecd89f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::OnCtlColor
Called by the framework when it must retrieve a brush to fill the background color of a property.  
  
## Syntax  
  
```  
virtual HBRUSH OnCtlColor(  
   CDC* pDC,  
   UINT nCtlColor   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `nCtlColor`  
 (This parameter is not used.)  
  
## Return Value  
 The handle to a brush if this method is successful; otherwise, `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)