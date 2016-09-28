---
title: "CDHtmlDialog::GetElementHtml"
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
  - "CDHtmlDialog::GetElementHtml"
  - "GetElementHtml"
  - "CDHtmlDialog.GetElementHtml"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetElementHtml method"
ms.assetid: e85a04fa-44aa-4ae7-8b01-5effbbc182a6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::GetElementHtml
Retrieves the **innerHTML** property of the HTML element identified by `szElementId`.  
  
## Syntax  
  
```  
  
      BSTR GetElementHtml(  
   LPCTSTR szElementId   
);  
```  
  
#### Parameters  
 `szElementId`  
 The ID of an HTML element.  
  
## Return Value  
 The **innerHTML** property of the HTML element identified by `szElementId` or **NULL** if the element could not be found.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::GetElementText](../vs140/cdhtmldialog--getelementtext.md)   
 [CDHtmlDialog::GetElementProperty](../vs140/cdhtmldialog--getelementproperty.md)