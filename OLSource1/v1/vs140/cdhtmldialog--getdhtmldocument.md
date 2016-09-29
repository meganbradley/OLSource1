---
title: "CDHtmlDialog::GetDHtmlDocument"
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
  - "CDHtmlDialog::GetDHtmlDocument"
  - "CDHtmlDialog.GetDHtmlDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDHtmlDocument method"
ms.assetid: d7e8a1fa-558e-4bd3-b85f-212a02a80fc8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::GetDHtmlDocument
Retrieves the [IHTMLDocument2](https://msdn.microsoft.com/en-us/library/aa752574.aspx) interface on the currently loaded HTML document.  
  
## Syntax  
  
```  
  
      HRESULT GetDHtmlDocument(  
   IHTMLDocument2 **pphtmlDoc   
);  
```  
  
#### Parameters  
 *\*\*pphtmlDoc*  
 A pointer to a pointer to an HTML document.  
  
## Return Value  
 A standard `HRESULT`. Returns `S_OK` if successful.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IHTMLDocument2](https://msdn.microsoft.com/en-us/library/aa752574.aspx)