---
title: "CDHtmlDialog::GetElementText"
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
  - "CDHtmlDialog.GetElementText"
  - "CDHtmlDialog::GetElementText"
  - "GetElementText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetElementText method"
ms.assetid: 74783d22-0aa4-4096-9c8b-4cd29f59b10c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::GetElementText
Retrieves the **innerText** property of the HTML element identified by `szElementId`.  
  
## Syntax  
  
```  
  
      BSTR GetElementText(  
   LPCTSTR szElementId   
);  
```  
  
#### Parameters  
 `szElementId`  
 The ID of an HTML element.  
  
## Return Value  
 The **innerText** property of the HTML element identified by `szElementId` or **NULL** if the property or element could not be found.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::GetElementHtml](../vs140/cdhtmldialog--getelementhtml.md)   
 [CDHtmlDialog::GetElementProperty](../vs140/cdhtmldialog--getelementproperty.md)