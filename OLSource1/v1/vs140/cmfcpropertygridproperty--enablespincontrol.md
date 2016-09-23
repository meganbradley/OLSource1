---
title: "CMFCPropertyGridProperty::EnableSpinControl"
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
  - EnableSpinControl
  - CMFCPropertyGridProperty::EnableSpinControl
  - CMFCPropertyGridProperty.EnableSpinControl
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableSpinControl method
ms.assetid: 4f4f871c-604e-47a8-8bbc-7964b4bcfd60
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPropertyGridProperty::EnableSpinControl
Enables or disables a spin button control that is used to modify a property value.  
  
## Syntax  
  
```  
void EnableSpinControl(  
   BOOL bEnable=TRUE,  
   int nMin=0,  
   int nMax=0   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable the spin button control; `FALSE` to disable the spin button control. The default value is `TRUE`.  
  
 [in] `nMin`  
 The minimum value of the spin button control. The default value is 0.  
  
 [in] `nMax`  
 The maximum value of the spin button control. The default value is 0.  
  
## Remarks  
 The framework automatically creates a spin button control when a property is about to be edited.  
  
 The property type, which is specified by the `varValue` parameter of the [CMFCPropertyGridProperty::CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty--cmfcpropertygridproperty.md) constructor, must be a supported variant type. Otherwise, this method asserts in debug mode. The supported types include `VT_INT`, `VT_UINT`, `VT_I2`, `VT_I4`, `VT_UI2`, and `VT_UI4`.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridProperty::CreateSpinControl](../vs140/cmfcpropertygridproperty--createspincontrol.md)