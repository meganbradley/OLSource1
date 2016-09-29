---
title: "CMFCPropertyGridProperty::OnSetCursor"
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
  - "CMFCPropertyGridProperty.OnSetCursor"
  - "CMFCPropertyGridProperty::OnSetCursor"
  - "OnSetCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetCursor method"
ms.assetid: ab7fab3b-efd5-40d6-919b-40598de9d43e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::OnSetCursor
Called by the framework when the mouse pointer moves to a property item.  
  
## Syntax  
  
```  
virtual BOOL OnSetCursor() const;  
```  
  
## Return Value  
 `TRUE` if the current property is a variant type or a list of values, and this method successfully loads the insertion point (I-beam) mouse cursor; otherwise, `FALSE`.  
  
## Remarks  
 This method supports the following variant types: `VT_INT`, `VT_I2`, `VT_I4`, `VT_UINT`, `VT_UI1`, `VT_UI2`, `VT_UI4`, `VT_R4`, `VT_R8`, and `VT_BSTR`.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)