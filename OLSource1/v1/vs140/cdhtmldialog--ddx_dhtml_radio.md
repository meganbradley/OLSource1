---
title: "CDHtmlDialog::DDX_DHtml_Radio"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDHtmlDialog::DDX_DHtml_Radio
  - CDHtmlDialog.DDX_DHtml_Radio
  - DDX_DHtml_Radio
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDX_DHtml_Radio method
ms.assetid: 4c785547-699f-4e29-a04f-2c35d9401d65
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDHtmlDialog::DDX_DHtml_Radio
Exchanges data between a member variable and a radio button on an HTML page.  
  
## Syntax  
  
```  
  
      void DDX_DHtml_Radio(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   long& value   
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