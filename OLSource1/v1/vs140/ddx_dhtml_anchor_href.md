---
title: "DDX_DHtml_Anchor_Href"
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
  - "DDX_DHtml_Anchor_Href"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_DHtml_Anchor_Href macro"
ms.assetid: 779d17d3-3bb2-4bba-9486-d4ba6ed22f4a
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_DHtml_Anchor_Href
Sets or retrieves the destination URL or anchor point.  
  
## Syntax  
  
```  
  
      DDX_DHtml_Anchor_Href(  
   CDataExchange* dx,  
   LPCTSTR name,  
   CString& var   
)  
```  
  
#### Parameters  
 `dx`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 *name*  
 The value that you specified for the HTML control's ID parameter.  
  
 `var`  
 The value being exchanged.  
  
## Remarks  
 This macro calls the [CDHtmlDialog::DDX_DHtml_ElementText](../vs140/cdhtmldialog--ddx_dhtml_elementtext.md) function using the DISPID_IHTMLANCHORELEMENT_HREF dispatch ID.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [DDX_DHtml Helper Macros](../vs140/ddx_dhtml-helper-macros.md)   
 [href Property (IHTMLAnchorElement)](https://msdn.microsoft.com/en-us/library/aa741842.aspx)