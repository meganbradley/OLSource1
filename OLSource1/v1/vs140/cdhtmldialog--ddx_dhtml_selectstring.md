---
title: "CDHtmlDialog::DDX_DHtml_SelectString"
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
  - "CDHtmlDialog::DDX_DHtml_SelectString"
  - "CDHtmlDialog.DDX_DHtml_SelectString"
  - "DDX_DHtml_SelectString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_DHtml_SelectString method"
ms.assetid: 7fb8b3a2-fb47-400c-9858-b768ac12f23d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::DDX_DHtml_SelectString
Gets or sets the display text of a list box entry (based on the current index) on an HTML page.  
  
## Syntax  
  
```  
  
      void DDX_DHtml_SelectString(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   CString& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 `szId`  
 The value that you specified for the HTML control's ID parameter.  
  
 *value*  
 The value being exchanged.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)