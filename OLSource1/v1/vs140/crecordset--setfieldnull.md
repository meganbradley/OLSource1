---
title: "CRecordset::SetFieldNull"
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
  - "CRecordset::SetFieldNull"
  - "CRecordset.SetFieldNull"
  - "SetFieldNull"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFieldNull method"
ms.assetid: 471ede61-0f10-4ac5-9ac7-010e5be2f2c3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::SetFieldNull
Flags a field data member of the recordset as Null (specifically having no value) or as non-Null.  
  
## Syntax  
  
```  
  
      void SetFieldNull(  
   void* pv,  
   BOOL bNull = TRUE   
);  
```  
  
#### Parameters  
 `pv`  
 Contains the address of a field data member in the recordset or **NULL**. If **NULL**, all field data members in the recordset are flagged. (C++ **NULL** is not the same as Null in database terminology, which means "having no value.")  
  
 `bNull`  
 Nonzero if the field data member is to be flagged as having no value (Null). Otherwise 0 if the field data member is to be flagged as non-Null.  
  
## Remarks  
 When you add a new record to a recordset, all field data members are initially set to a Null value and flagged as "dirty" (changed). When you retrieve a record from a data source, its columns either already have values or are Null.  
  
> [!NOTE]
>  Do not call this member function on recordsets that are using bulk row fetching. If you have implemented bulk row fetching, calling `SetFieldNull` results in a failed assertion. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 If you specifically wish to designate a field of the current record as not having a value, call `SetFieldNull` with `bNull` set to **TRUE** to flag it as Null. If a field was previously marked Null and you now want to give it a value, simply set its new value. You do not have to remove the Null flag with `SetFieldNull`. To determine whether the field is allowed to be Null, call `IsFieldNullable`.  
  
> [!CAUTION]
>  Call this member function only after you have called [Edit](../vs140/crecordset--edit.md) or [AddNew](../vs140/crecordset--addnew.md).  
  
 Using **NULL** for the first argument of the function will apply the function only to **outputColumn** fields, not **param** fields. For instance, the call  
  
 [!code[NVC_MFCDatabase#26](../vs140/codesnippet/CPP/crecordset--setfieldnull_1.cpp)]  
  
 will set only **outputColumn** fields to **NULL**; **param** fields will be unaffected.  
  
 To work on **param** fields, you must supply the actual address of the individual **param** you want to work on, such as:  
  
 [!code[NVC_MFCDatabase#27](../vs140/codesnippet/CPP/crecordset--setfieldnull_2.cpp)]  
  
 This means you cannot set all **param** fields to **NULL**, as you can with **outputColumn** fields.  
  
> [!NOTE]
>  When setting parameters to Null, a call to `SetFieldNull` before the recordset is opened results in an assertion. In this case, call [SetParamNull](../vs140/crecordset--setparamnull.md).  
  
 `SetFieldNull` is implemented through [DoFieldExchange](../vs140/crecordset--dofieldexchange.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::IsFieldNull](../vs140/crecordset--isfieldnull.md)   
 [CRecordset::SetFieldDirty](../vs140/crecordset--setfielddirty.md)   
 [CRecordset::Edit](../vs140/crecordset--edit.md)   
 [CRecordset::Update](../vs140/crecordset--update.md)   
 [CRecordset::IsFieldNullable](../vs140/crecordset--isfieldnullable.md)