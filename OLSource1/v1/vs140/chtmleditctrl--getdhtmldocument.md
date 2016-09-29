---
title: "CHtmlEditCtrl::GetDHtmlDocument"
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
  - "CHtmlEditCtrl::GetDHtmlDocument"
  - "CHtmlEditCtrl.GetDHtmlDocument"
  - "GetDHtmlDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDHtmlDocument method"
ms.assetid: b4865375-78a7-4e61-8b93-0b4312a2c06e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrl::GetDHtmlDocument
Retrieves the [IHTMLDocument2](https://msdn.microsoft.com/en-us/library/aa752574.aspx) interface on the document currently loaded in the contained WebBrowser control  
  
## Syntax  
  
```  
  
      BOOL GetDHtmlDocument(  
   IHTMLDocument2 **ppDocument  
) const;  
```  
  
#### Parameters  
 `ppDocument`  
 The document interface.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrl Class](../vs140/chtmleditctrl-class.md)