---
title: "Transaction: Performing a Transaction in a Recordset (ODBC)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transactions, updating recordsets"
ms.assetid: cf1d6b48-7fb8-4903-84f7-a1822054534d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Transaction: Performing a Transaction in a Recordset (ODBC)
This topic explains how to perform a transaction in a recordset.  
  
> [!NOTE]
>  Only one level of transactions is supported; you cannot nest transactions.  
  
#### To perform a transaction in a recordset  
  
1.  Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object's **BeginTrans** member function.  
  
2.  If you have not implemented bulk row fetching, call the **AddNew/Update**, **Edit/Update**, and **Delete** member functions of one or more recordset objects of the same database as many times as needed. For more information, see [Recordset: Adding, Updating, and Deleting Records (ODBC)](../vs140/recordset--adding--updating--and-deleting-records--odbc-.md). If you have implemented bulk row fetching, you must write your own functions to update the data source.  
  
3.  Finally, call the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object's **CommitTrans** member function. If an error occurs in one of the updates or you decide to cancel the changes, call its **Rollback** member function.  
  
 The following example uses two recordsets to delete a student's enrollment from a school registration database, removing the student from all classes in which the student is enrolled. Because the **Delete** calls in both recordsets must succeed, a transaction is required. The example assumes the existence of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, a member variable of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> already connected to the data source, and the recordset classes <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> variable contains a value obtained from the user.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  Calling **BeginTrans** again without calling **CommitTrans** or **Rollback** is an error.  
  
## See Also  
 [Transaction (ODBC)](../vs140/transaction--odbc-.md)   
 [Transaction: How Transactions Affect Updates (ODBC)](../vs140/transaction--how-transactions-affect-updates--odbc-.md)   
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [CRecordset Class](../vs140/crecordset-class.md)