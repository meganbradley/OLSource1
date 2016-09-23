---
title: "CDHtmlDialog::OnBeforeNavigate"
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
  - OnBeforeNavigate
  - CDHtmlDialog.OnBeforeNavigate
  - CDHtmlDialog::OnBeforeNavigate
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnBeforeNavigate method
ms.assetid: 0a7b27a1-dccf-448b-a559-a098f1a3770d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDHtmlDialog::OnBeforeNavigate
Called by the framework to cause an event to fire before a navigation occurs.  
  
## Syntax  
  
```  
  
      virtual void OnBeforeNavigate(  
   LPDISPATCH pDisp,  
   LPCTSTR szUrl   
);  
```  
  
#### Parameters  
 `pDisp`  
 A pointer to an `IDispatch` object.  
  
 `szUrl`  
 A pointer to a string containing the URL to navigate to.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::OnNavigateComplete](../vs140/cdhtmldialog--onnavigatecomplete.md)