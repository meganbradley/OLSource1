---
title: "CMFCPropertyGridProperty::PushChar"
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
  - "PushChar"
  - "CMFCPropertyGridProperty.PushChar"
  - "CMFCPropertyGridProperty::PushChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PushChar method"
ms.assetid: d997ecd6-4186-4da4-b32f-cd11a1fe2b0c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::PushChar
Called from the property list control when the property is selected and the user enters a new character.  
  
## Syntax  
  
```  
virtual BOOL PushChar(  
   UINT nChar   
);  
```  
  
#### Parameters  
 [in] `nChar`  
 A character.  
  
## Return Value  
 `TRUE` if the edit operation is continuing; otherwise, `FALSE`.  
  
## Remarks  
 This method supports a property that is either a list of values or one of the following variant types: `VT_INT`, `VT_I2`, `VT_I4`, `VT_UINT`, `VT_UI1`, `VT_UI2`, `VT_UI4`, `VT_R4`, `VT_R8`, and `VT_BSTR`.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)