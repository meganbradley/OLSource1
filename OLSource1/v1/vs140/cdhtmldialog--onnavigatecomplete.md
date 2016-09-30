---
title: "CDHtmlDialog::OnNavigateComplete"
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
  - "OnNavigateComplete"
  - "CDHtmlDialog.OnNavigateComplete"
  - "CDHtmlDialog::OnNavigateComplete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNavigateComplete method"
ms.assetid: 721fb4ae-46b9-4f36-8607-f69e7ceba955
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::OnNavigateComplete
Called by the framework after navigation to the specified URL is completed.  
  
## Syntax  
  
```  
  
      virtual void OnNavigateComplete(  
   LPDISPATCH pDisp,  
   LPCTSTR szUrl   
);  
```  
  
#### Parameters  
 `pDisp`  
 A pointer to an `IDispatch` object.  
  
 `szUrl`  
 A pointer to a string containing the URL that was navigated to.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::OnDocumentComplete](../vs140/cdhtmldialog--ondocumentcomplete.md)