---
title: "CMFCRibbonBar::LoadFromResource"
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
  - "afxribbonbar/CMFCRibbonBar::LoadFromResource"
  - "LoadFromResource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadFromResource"
ms.assetid: 63ad8625-d874-4b5d-9fa5-a78a1587dc25
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::LoadFromResource
Overloaded. Loads a Ribbon Bar from application resources.  
  
## Syntax  
  
```  
virtual BOOL LoadFromResource(  
   UINT uiXMLResID,  
   LPCTSTR lpszResType = RT_RIBBON,  
   HINSTANCE hInstance = NULL  
);  
virtual BOOL LoadFromResource(  
   LPCTSTR lpszXMLResID,  
   LPCTSTR lpszResType = RT_RIBBON,  
   HINSTANCE hInstance = NULL  
);  
```  
  
#### Parameters  
 `uiXMLResID`  
 Specifies resource ID of XML string with Ribbon Bar information.  
  
 `lpszResType`  
 Specifies type of the resource located at `uiXMLResID`.  
  
 `hInstance`  
 Handle to the module whose executable file contains the resource. If `hInstance` is `NULL`, the system loads the resource from the module that was used to create the current process.  
  
 `lpszXMLResID`  
 Specifies resource ID (in string form) with Ribbon Bar information.  
  
## Return Value  
 `TRUE` if load succeeds; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)