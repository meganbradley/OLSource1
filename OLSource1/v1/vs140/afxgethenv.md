---
title: "AfxGetHENV"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXDB/AfxGetHENV"
  - "AfxGetHENV"
  - "SQL_HENV_NULL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxGetHENV function"
  - "global functions, database functions"
  - "SQL_HENV_NULL constant"
ms.assetid: d8be2a8e-b93a-460f-affb-cf65b2f3dc10
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxGetHENV
You can use the returned handle in direct ODBC calls, but you must not close the handle or assume that the handle is still valid and available after any existing `CDatabase`- or `CRecordset`-derived objects have been destroyed.  
  
## Syntax  
  
```  
  
HENV AFXAPI AfxGetHENV( );  
  
```  
  
## Return Value  
 The handle to the ODBC environment currently in use by MFC. Can be `SQL_HENV_NULL` if there are no [CDatabase](../vs140/cdatabase-class.md) objects and no [CRecordset](../vs140/crecordset-class.md) objects in use.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)