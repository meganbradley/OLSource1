---
title: "CWinAppEx::IsStateExists"
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
  - "IsStateExists"
  - "CWinAppEx.IsStateExists"
  - "CWinAppEx::IsStateExists"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsStateExists method"
ms.assetid: 006c5676-172d-4389-91fb-07ba2fc8941f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::IsStateExists
Indicates whether the specified key is in the registry.  
  
## Syntax  
  
```  
BOOL IsStateExists(  
   LPCTSTR lpszSectionName   
);  
```  
  
#### Parameters  
 [in] `lpszSectionName`  
 A string that contains a path of a registry key.  
  
## Return Value  
 Nonzero if the key is in the registry; otherwise 0.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)