---
title: "DDV_MinMaxUnsigned"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DDV_MinMaxUnsigned"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDV_MinMaxUnsigned function"
ms.assetid: bd61ea0c-5c62-4491-913a-0fbc5327290b
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDV_MinMaxUnsigned
Call `DDV_MinMaxUnsigned` to verify that the value in the control associated with *value* falls between `minVal` and `maxVal`.  
  
## Syntax  
  
```  
  
      void AFXAPI DDV_MinMaxUnsigned(  
   CDataExchange* pDX,  
   unsigned value,  
   unsigned minVal,  
   unsigned maxVal   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is validated.  
  
 `minVal`  
 Minimum value (of type **unsigned** ) allowed.  
  
 `maxVal`  
 Maximum value (of type **unsigned** ) allowed.  
  
## Remarks  
 For more information about DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_Slider](../vs140/ddx_slider.md)   
 [DDX_FieldSlider](../vs140/ddx_fieldslider.md)