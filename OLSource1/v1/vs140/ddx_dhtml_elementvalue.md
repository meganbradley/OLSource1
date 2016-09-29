---
title: "DDX_DHtml_ElementValue"
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
  - "DDX_DHtml_ElementValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_DHtml_ElementValue macro"
ms.assetid: a20263ca-bf3b-4255-ad9e-3647da64a807
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_DHtml_ElementValue
Sets or retrieves the Value property from the selected control.  
  
## Syntax  
  
```  
  
      DDX_DHtml_ElementValue(  
   CDataExchange* dx,  
   LPCTSTR name,  
   var   
)  
```  
  
#### Parameters  
 `dx`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 *name*  
 The value that you specified for the HTML control's ID parameter.  
  
 `var`  
 The value being exchanged. See *value* in [CDHtmlDialog::DDX_DHtml_ElementText](../vs140/cdhtmldialog--ddx_dhtml_elementtext.md).  
  
## Remarks  
 This macro will only succeed when run on controls that have a Value property. Controls that have a Value property include edit boxes, list boxes, and combo boxes.  
  
 This macro calls the [CDHtmlDialog::DDX_DHtml_ElementText](../vs140/cdhtmldialog--ddx_dhtml_elementtext.md) function using the DISPID_A_VALUE dispatch ID.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [DDX_DHtml Helper Macros](../vs140/ddx_dhtml-helper-macros.md)