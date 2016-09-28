---
title: "CDHtmlDialog::OnDocumentComplete"
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
  - "CDHtmlDialog::OnDocumentComplete"
  - "CDHtmlDialog.OnDocumentComplete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDocumentComplete method"
ms.assetid: 7ce43e63-935a-4d20-ad95-98f5f4729ca3
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::OnDocumentComplete
Called by the framework to notify an application when a document has achieved the `READYSTATE_COMPLETE` state.  
  
## Syntax  
  
```  
  
      virtual void OnDocumentComplete(  
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
 [CDHtmlDialog::OnNavigateComplete](../vs140/cdhtmldialog--onnavigatecomplete.md)