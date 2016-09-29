---
title: "CMFCPropertyGridCtrl::OnPropertyChanged"
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
  - "CMFCPropertyGridCtrl::OnPropertyChanged"
  - "OnPropertyChanged"
  - "CMFCPropertyGridCtrl.OnPropertyChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPropertyChanged method"
ms.assetid: 52afbf02-96c3-41ad-9566-3f053f5c4991
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::OnPropertyChanged
Called by the framework when the value of a property is changed.  
  
## Syntax  
  
```  
virtual void OnPropertyChanged(  
   CMFCPropertyGridProperty* pProp   
) const;  
```  
  
#### Parameters  
 [in] `pProp`  
 A pointer to a property object whose value has changed.  
  
## Remarks  
 By default, this method sends the [AFX_WM_PROPERTY_CHANGED](../vs140/afx-messages.md) message to the owner of the property grid control.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AFX Messages](../vs140/afx-messages.md)