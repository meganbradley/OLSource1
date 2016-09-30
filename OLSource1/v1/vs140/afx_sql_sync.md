---
title: "AFX_SQL_SYNC"
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
  - "AFXDB/AFX_SQL_SYNC"
  - "AFX_SQL_SYNC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "database macros [C++]"
  - "AFX_SQL_SYNC macro"
ms.assetid: c8ce5e33-5fbe-4ab0-8bc0-02d044c5af6b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_SQL_SYNC
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro simply calls the function <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An ODBC API function. For more information about these functions, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 Use this macro to call ODBC API functions that will not return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 Before calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you must declare a variable, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, of type **RETCODE**. You can check the value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> after the macro call.  
  
 Note that the implementation of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> changed in MFC 4.2. Because checking the server status was no longer required, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> simply assigns a value to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For example, instead of making the call  
  
 [!code[NVC_MFCDatabase#40](../vs140/codesnippet/CPP/afx_sql_sync_1.cpp)]  
  
 you can simply make the assignment  
  
 [!code[NVC_MFCDatabase#41](../vs140/codesnippet/CPP/afx_sql_sync_2.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AFX_SQL_ASYNC](../vs140/afx_sql_async.md)   
 [AFX_ODBC_CALL](../vs140/afx_odbc_call.md)