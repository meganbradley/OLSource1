---
title: "CMFCPropertyGridProperty::CreateInPlaceEdit"
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
  - "CMFCPropertyGridProperty::CreateInPlaceEdit"
  - "CMFCPropertyGridProperty.CreateInPlaceEdit"
  - "CreateInPlaceEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInPlaceEdit method"
ms.assetid: 29adb69d-c261-435a-a6fd-68aba4aaae6e
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::CreateInPlaceEdit
Called by the framework to create an editable control for a property.  
  
## Syntax  
  
```  
virtual CWnd* CreateInPlaceEdit(  
   CRect rectEdit,  
   BOOL& bDefaultFormat   
);  
```  
  
#### Parameters  
 [in] `rectEdit`  
 The bounding rectangle of the editable control.  
  
 [in] `bDefaultFormat`  
 `TRUE` to use the default property format to set the text of the editable control; otherwise, `FALSE`.  
  
## Return Value  
 A pointer to the editable control if this method succeeds; otherwise, `NULL`.  
  
## Remarks  
 This method uses the values of the `varValue`, `lpszEditMask`, `lpszEditTemplate`, and `lpszValidChars` parameters that are specified in the [CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty-class.md) class constructor. By default, this method supports the `varValue` variant types. This includes `VT_BSTR`, `VT_R4`, `VT_R8`, `VT_UI1`, `VT_I2`, `VT_INT`, `VT_UINT`, `VT_I4`, `VT_UI2`, `VT_UI4`, and `VT_BOOL`.  
  
 This method creates a [CMFCMaskedEdit](../vs140/cmfcmaskededit-class.md) control if one or more of the `lpszEditMask`, `lpszEditTemplate`, or `lpszValidChars` parameters are specified; otherwise, it creates a [CEdit](../vs140/cedit-class.md) control.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit Class](../vs140/cedit-class.md)