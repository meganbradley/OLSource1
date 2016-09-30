---
title: "CRecordset::IsFieldNullable"
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
  - "CRecordset.IsFieldNullable"
  - "IsFieldNullable"
  - "CRecordset::IsFieldNullable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsFieldNullable method"
ms.assetid: 0d5e8780-0ca7-4fad-8a55-be32a41574c7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::IsFieldNullable
Returns nonzero if the specified field in the current record can be set to Null (having no value).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the field data member whose status you want to check, or **NULL** to determine if any of the fields can be set to a Null value.  
  
## Remarks  
 Call this member function to determine whether the specified field data member is "nullable" (can be set to a Null value; C++ **NULL** is not the same as Null, which, in database terminology, means "having no value").  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you cannot call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Instead, call the [GetODBCFieldInfo](../vs140/crecordset--getodbcfieldinfo.md) member function to determine whether a field can be set to a Null value. Note that you can always call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, regardless of whether you have implemented bulk row fetching. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 A field that cannot be Null must have a value. If you attempt to set a such a field to Null when adding or updating a record, the data source rejects the addition or update, and [Update](../vs140/crecordset--update.md) will throw an exception. The exception occurs when you call **Update**, not when you call [SetFieldNull](../vs140/crecordset--setfieldnull.md).  
  
 Using **NULL** for the first argument of the function will apply the function only to **outputColumn** fields, not **param** fields. For instance, the call  
  
 [!code[NVC_MFCDatabase#26](../vs140/codesnippet/CPP/crecordset--isfieldnullable_1.cpp)]  
  
 will set only **outputColumn** fields to **NULL**; **param** fields will be unaffected.  
  
 To work on **param** fields, you must supply the actual address of the individual **param** you want to work on, such as:  
  
 [!code[NVC_MFCDatabase#27](../vs140/codesnippet/CPP/crecordset--isfieldnullable_2.cpp)]  
  
 This means you cannot set all **param** fields to **NULL**, as you can with **outputColumn** fields.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is implemented through [DoFieldExchange](../vs140/crecordset--dofieldexchange.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\***.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::IsFieldNull](../vs140/crecordset--isfieldnull.md)   
 [CRecordset::SetFieldNull](../vs140/crecordset--setfieldnull.md)