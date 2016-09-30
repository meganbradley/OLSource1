---
title: "AFX_ODBC_CALL"
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
  - "AFXDB/AFX_ODBC_CALL"
  - "AFX_ODBC_CALL"
  - "SQL_STILL_EXECUTING"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_ODBC_CALL macro"
  - "database macros [C++]"
  - "SQL_STILL_EXECUTING macro"
ms.assetid: 9e5086bc-2ae2-45fa-b277-bfd14182fd1f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_ODBC_CALL
Use this macro to call any ODBC API function that may return <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An ODBC API function. For more information about ODBC API functions, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> repeatedly calls the function until it no longer returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 Before invoking <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you must declare a variable, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, of type **RETCODE**.  
  
 Note that the MFC ODBC classes now use only synchronous processing. In order to perform an asynchronous operation, you must call the ODBC API function **SQLSetConnectOption**. For more information, see the topic "Executing Functions Asynchronously" in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 This example uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to call the **SQLColumns** ODBC API function, which returns a list of the columns in the table named by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Note the declaration of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the use of recordset data members to pass parameters to the function. The example also illustrates checking the results of the call with **Check**, a member function of class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The variable <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a pointer to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object, declared elsewhere.  
  
 [!code[NVC_MFCDatabase#39](../vs140/codesnippet/CPP/afx_odbc_call_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AFX_SQL_ASYNC](../vs140/afx_sql_async.md)   
 [AFX_SQL_SYNC](../vs140/afx_sql_sync.md)