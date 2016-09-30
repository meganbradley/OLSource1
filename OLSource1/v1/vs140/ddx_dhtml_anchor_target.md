---
title: "DDX_DHtml_Anchor_Target"
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
  - "DDX_DHtml_Anchor_Target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_DHtml_Anchor_Target macro"
ms.assetid: 7ce9fc3d-bd62-434b-8cc9-8425e1d670b0
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_DHtml_Anchor_Target
Sets or retrieves the target window or frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 *name*  
 The value that you specified for the HTML control's ID parameter.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value being exchanged.  
  
## Remarks  
 This macro calls the [CDHtmlDialog::DDX_DHtml_ElementText](../vs140/cdhtmldialog--ddx_dhtml_elementtext.md) function using the DISPID_IHTMLANCHORELEMENT_TARGET dispatch ID.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [DDX_DHtml Helper Macros](../vs140/ddx_dhtml-helper-macros.md)   
 [target Property (IHTMLAnchorElement)](https://msdn.microsoft.com/en-us/library/aa741854.aspx)