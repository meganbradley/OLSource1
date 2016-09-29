---
title: "CDHtmlDialog::DDX_DHtml_SelectIndex"
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
  - "CDHtmlDialog.DDX_DHtml_SelectIndex"
  - "DDX_DHtml_SelectIndex"
  - "CDHtmlDialog::DDX_DHtml_SelectIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_DHtml_SelectIndex method"
ms.assetid: af2d1e55-0f76-4e71-969e-a9fd21b206d8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::DDX_DHtml_SelectIndex
Gets or sets the index of a list box on an HTML page.  
  
## Syntax  
  
```  
  
      void DDX_DHtml_SelectIndex(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   long& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 `szId`  
 The value that you specified for the HTML control's id parameter.  
  
 *value*  
 The value being exchanged.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)