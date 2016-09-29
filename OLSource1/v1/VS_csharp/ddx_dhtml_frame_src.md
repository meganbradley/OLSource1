---
title: "DDX_DHtml_Frame_Src"
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
  - "DDX_DHtml_Frame_Src"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_DHtml_Frame_Src macro"
ms.assetid: 11cd0b7f-7b8a-4a59-8808-f0a1bb039b3d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_DHtml_Frame_Src
Sets or retrieves the URL of the associated frame.  
  
## Syntax  
  
```  
  
      DDX_DHtml_Frame_Src(  
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
 This macro calls the [CDHtmlDialog::DDX_DHtml_ElementText](../Topic/CDHtmlDialog::DDX_DHtml_ElementText.md) function using the DISPID_IHTMLFRAMEBASE_SRC dispatch ID.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [DDX_DHtml Helper Macros](../VS_csharp/ddx_dhtml-helper-macros.md)   
 [src Property (IHTMLFrameBase)](https://msdn.microsoft.com/en-us/library/aa752423.aspx)