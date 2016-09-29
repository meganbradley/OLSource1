---
title: "DDX_DHtml_ElementInnerHtml"
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
  - "DDX_DHtml_ElementInnerHtml"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_DHtml_ElementInnerHtml macro"
ms.assetid: 90cdb894-4b49-4ea0-a936-0ac498f5c5b3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_DHtml_ElementInnerHtml
Sets or retrieves the HTML between the start and end tags of the current element.  
  
## Syntax  
  
```  
  
      DDX_DHtml_ElementInnerHtml(  
   CDataExchange* dx,  
   LPCTSTR name,  
   CString& var   
)  
```  
  
#### Parameters  
 `dx`  
 A pointer to a [CDataExchange](../VS_csharp/cdataexchange-class.md) object.  
  
 *name*  
 The value that you specified for the HTML control's ID parameter.  
  
 `var`  
 The value being exchanged.  
  
## Remarks  
 This macro calls the [CDHtmlDialog::DDX_DHtml_ElementText](../Topic/CDHtmlDialog::DDX_DHtml_ElementText.md) function using the DISPID_IHTMLELEMENT_INNERHTML dispatch ID.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [DDX_DHtml Helper Macros](../VS_csharp/ddx_dhtml-helper-macros.md)   
 [innerHTML Property (IHTMLElement)](http://msdn.microsoft.com/library/aa752298)