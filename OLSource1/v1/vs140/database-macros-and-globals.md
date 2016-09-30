---
title: "Database Macros and Globals"
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
  - "vc.mfc.macros.data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "global database functions [C++]"
  - "database macros [C++]"
  - "database globals [C++]"
  - "global functions [C++], database functions"
  - "macros [C++], MFC database"
ms.assetid: 5b9b9e61-1cf9-4345-9f29-3807dd466488
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Database Macros and Globals
The macros and globals listed below apply to ODBC-based database applications. They are not used with DAO-based applications.  
  
 Before MFC 4.2, the macros <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> gave asynchronous operations an opportunity to yield time to other processes. Beginning with MFC 4.2, the implementation of these macros changed because the MFC ODBC classes used only synchronous operations. The macro <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> was new to MFC 4.2.  
  
### Database Macros  
  
|||  
|-|-|  
|[AFX_ODBC_CALL](../vs140/afx_odbc_call.md)|Calls an ODBC API function that returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will repeatedly call the function until it no longer returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|[AFX_SQL_ASYNC](../vs140/afx_sql_async.md)|Calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[AFX_SQL_SYNC](../vs140/afx_sql_sync.md)|Calls an ODBC API function that does not return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
### Database Globals  
  
|||  
|-|-|  
|[AfxGetHENV](../vs140/afxgethenv.md)|Retrieves a handle to the ODBC environment currently in use by MFC. You can use this handle in direct ODBC calls.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)