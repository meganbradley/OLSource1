---
title: "CDHtmlDialog::CanAccessExternal"
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
  - "CDHtmlDialog.CanAccessExternal"
  - "CDHtmlDialog::CanAccessExternal"
  - "CanAccessExternal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAccessExternal method"
ms.assetid: cd7a2df4-f5cf-4c8c-b6a8-35afeaffcbf2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::CanAccessExternal
Overridable that is called as an access check to see whether scripting objects on the loaded page can access the external dispatch of the control site. Checks to make sure the dispatch is either safe for scripting or the current zone allows for objects that are not safe for scripting.  
  
## Syntax  
  
```  
  
virtual BOOL CanAccessExternal( );  
  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::IsExternalDispatchSafe](../vs140/cdhtmldialog--isexternaldispatchsafe.md)