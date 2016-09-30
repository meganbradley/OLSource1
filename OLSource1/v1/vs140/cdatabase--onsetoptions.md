---
title: "CDatabase::OnSetOptions"
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
  - "CDatabase.OnSetOptions"
  - "OnSetOptions"
  - "CDatabase::OnSetOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetOptions method"
  - "CDatabase class, database overridables"
ms.assetid: c193344c-a749-40be-a045-094a55b41e8c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::OnSetOptions
The framework calls this member function when directly executing a SQL statement with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The ODBC statement handle for which options are being set.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> also calls this member function.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> sets the login timeout value. If there have been previous calls to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and member function, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> reflects the current values; otherwise, it sets default values.  
  
> [!NOTE]
>  Prior to MFC 4.2, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> also set the processing mode to either snychronous or asynchronous. Beginning with MFC 4.2, all operations are synchronous. To perform an asynchronous operation, you must make a direct call to the ODBC API function **SQLSetPos**.  
  
 You do not need to override <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to change the timeout value. Instead, to customize the query timeout value, call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> before creating a recordset; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> will use the new value. The values set apply to subsequent operations on all recordsets or direct SQL calls.  
  
 Override <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if you want to set additional options. Your override should call the base class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> either before or after you call the ODBC API function **SQLSetStmtOption**. Follow the method illustrated in the framework's default implementation of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::ExecuteSQL](../vs140/cdatabase--executesql.md)   
 [CDatabase::SetQueryTimeout](../vs140/cdatabase--setquerytimeout.md)   
 [CRecordset::OnSetOptions](../vs140/crecordset--onsetoptions.md)