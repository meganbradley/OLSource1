---
title: "CMFCPropertyGridProperty::CreateSpinControl"
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
  - CreateSpinControl
  - CMFCPropertyGridProperty.CreateSpinControl
  - CMFCPropertyGridProperty::CreateSpinControl
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateSpinControl method
ms.assetid: bb03f7e7-5d16-4c3e-81fd-a27fafbb3170
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPropertyGridProperty::CreateSpinControl
Called by the framework to create an editable spin button control.  
  
## Syntax  
  
```  
virtual CSpinButtonCtrl* CreateSpinControl(  
   CRect rectSpin   
);  
```  
  
#### Parameters  
 [in] `rectSpin`  
 A rectangle that defines where the editable spin button control is created.  
  
## Return Value  
 A pointer to a new [CMFCSpinButtonCtrl](../vs140/cmfcspinbuttonctrl-class.md) object that is cast as a pointer to a [CSpinButtonCtrl](../vs140/cspinbuttonctrl-class.md) object.  
  
## Remarks  
 Call the [CMFCPropertyGridProperty::EnableSpinControl](../vs140/cmfcpropertygridproperty--enablespincontrol.md) method to display an editable spin button control at the right edge of the property.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)