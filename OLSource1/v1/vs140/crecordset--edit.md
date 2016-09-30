---
title: "CRecordset::Edit"
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
  - "CRecordset::Edit"
  - "CRecordset.Edit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Edit method"
ms.assetid: 23e34175-5af8-4b65-9551-d6983d718ac7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::Edit
Allows changes to the current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 After you call **Edit**, you can change the field data members by directly resetting their values. The operation is completed when you subsequently call the [Update](../vs140/crecordset--update.md) member function to save your changes on the data source.  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you cannot call **Edit**. This will result in a failed assertion. Although class <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> does not provide a mechanism for updating bulk rows of data, you can write your own functions by using the ODBC API function **SQLSetPos**. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 **Edit** saves the values of the recordset's data members. If you call **Edit**, make changes, then call **Edit** again, the record's values are restored to what they were before the first **Edit** call.  
  
 In some cases, you may want to update a column by making it Null (containing no data). To do so, call [SetFieldNull](../vs140/crecordset--setfieldnull.md) with a parameter of **TRUE** to mark the field Null; this also causes the column to be updated. If you want a field to be written to the data source even though its value has not changed, call [SetFieldDirty](../vs140/crecordset--setfielddirty.md) with a parameter of **TRUE**. This works even if the field had the value Null.  
  
 If the data source supports transactions, you can make the **Edit** call part of a transaction. Note that you should call [CDatabase::BeginTrans](../vs140/cdatabase--begintrans.md) before calling **Edit** and after the recordset has been opened. Also note that calling [CDatabase::CommitTrans](../vs140/cdatabase--committrans.md) is not a substitute for calling **Update** to complete the **Edit** operation. For more information about transactions, see class [CDatabase](../vs140/cdatabase-class.md).  
  
 Depending on the current locking mode, the record being updated may be locked by **Edit** until you call **Update** or scroll to another record, or it may be locked only during the **Edit** call. You can change the locking mode with [SetLockingMode](../vs140/crecordset--setlockingmode.md).  
  
 The previous value of the current record is restored if you scroll to a new record before calling **Update**. A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is thrown if you call **Edit** for a recordset that cannot be updated or if there is no current record.  
  
 For more information, see the articles [Transaction (ODBC)](../vs140/transaction--odbc-.md) and [Recordset: Locking Records (ODBC)](../vs140/recordset--locking-records--odbc-.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCDatabase#20](../vs140/codesnippet/CPP/crecordset--edit_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::Update](../vs140/crecordset--update.md)   
 [CRecordset::AddNew](../vs140/crecordset--addnew.md)   
 [CRecordset::Delete](../vs140/crecordset--delete.md)   
 [CRecordset::SetFieldDirty](../vs140/crecordset--setfielddirty.md)   
 [CRecordset::SetFieldNull](../vs140/crecordset--setfieldnull.md)   
 [CRecordset::CanUpdate](../vs140/crecordset--canupdate.md)   
 [CRecordset::CanTransact](../vs140/crecordset--cantransact.md)   
 [CRecordset::SetLockingMode](../vs140/crecordset--setlockingmode.md)