---
title: "CRecordset::Delete"
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
  - "CRecordset::Delete"
  - "CRecordset.Delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Delete method"
ms.assetid: b979f1fc-a45a-4d2e-8860-176a0d7af0ac
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::Delete
Deletes the current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 After a successful deletion, the recordset's field data members are set to a Null value, and you must explicitly call one of the **Move** functions in order to move off the deleted record. Once you move off the deleted record, it is not possible to return to it. If the data source supports transactions, you can make the **Delete** call part of a transaction. For more information, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you cannot call **Delete**. This will result in a failed assertion. Although class <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> does not provide a mechanism for updating bulk rows of data, you can write your own functions by using the ODBC API function **SQLSetPos**. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
> [!CAUTION]
>  The recordset must be updatable and there must be a valid record current in the recordset when you call **Delete**; otherwise, an error occurs. For example, if you delete a record but do not scroll to a new record before you call **Delete** again, **Delete** throws a [CDBException](../vs140/cdbexception-class.md).  
  
 Unlike [AddNew](../vs140/crecordset--addnew.md) and [Edit](../vs140/crecordset--edit.md), a call to **Delete** is not followed by a call to [Update](../vs140/crecordset--update.md). If a **Delete** call fails, the field data members are left unchanged.  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\***.  
  
## Example  
 This example shows a recordset created on the frame of a function. The example assumes the existence of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, a member variable of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> already connected to the data source.  
  
 [!code[NVC_MFCDatabase#18](../vs140/codesnippet/CPP/crecordset--delete_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::BeginTrans](../vs140/cdatabase--begintrans.md)   
 [CDatabase::CommitTrans](../vs140/cdatabase--committrans.md)   
 [CDatabase::Rollback](../vs140/cdatabase--rollback.md)   
 [CDBException Class](../vs140/cdbexception-class.md)