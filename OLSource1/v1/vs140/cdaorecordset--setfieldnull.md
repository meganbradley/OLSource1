---
title: "CDaoRecordset::SetFieldNull"
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
  - "CDaoRecordset::SetFieldNull"
  - "CDaoRecordset.SetFieldNull"
  - "SetFieldNull"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, setting field null"
  - "recordsets, setting field flags and values"
  - "null values, recordset fields"
  - "SetFieldNull method"
ms.assetid: ba3674c6-f436-4c60-a976-727b45199a55
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetFieldNull
Call this member function to flag a field data member of the recordset as Null (specifically having no value) or as non-Null.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the address of a field data member in the recordset or **NULL**. If **NULL**, all field data members in the recordset are flagged. (C++ **NULL** is not the same as Null in database terminology, which means "having no value.")  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Nonzero if the field data member is to be flagged as having no value (Null). Otherwise 0 if the field data member is to be flagged as non-Null.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used for fields bound in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> mechanism.  
  
 When you add a new record to a recordset, all field data members are initially set to a Null value and flagged as "dirty" (changed). When you retrieve a record from a data source, its columns either already have values or are Null. If it is not appropriate to make a field Null, a [CDaoException](../vs140/cdaoexception-class.md) is thrown.  
  
 If you are using the double-buffering mechanism, for example, if you specifically wish to designate a field of the current record as not having a value, call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> set to **TRUE** to flag it as Null. If a field was previously marked Null and you now want to give it a value, simply set its new value. You do not have to remove the Null flag with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. To determine whether the field is allowed to be Null, call [IsFieldNullable](../vs140/cdaorecordset--isfieldnullable.md).  
  
 If you are not using the double-buffering mechanism, then changing the value of the field does not automatically set the field as dirty and non-Null. You must specifically set the fields dirty and non-Null. The flag contained in [m_bCheckCacheForDirtyFields](../vs140/cdaorecordset--m_bcheckcachefordirtyfields.md) controls this automatic field checking.  
  
 The DFX mechanism employs the use of **PSEUDO NULL**. For more information, see [CDaoFieldExchange::m_nOperation](../vs140/cdaofieldexchange--m_noperation.md).  
  
> [!NOTE]
>  Call this member function only after you have called [Edit](../vs140/cdaorecordset--edit.md) or [AddNew](../vs140/cdaorecordset--addnew.md).  
  
 Using **NULL** for the first argument of the function will apply the function only to **outputColumn** fields, not **param** fields in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For instance, the call  
  
 [!code[NVC_MFCDatabase#8](../vs140/codesnippet/CPP/cdaorecordset--setfieldnull_1.cpp)]  
  
 will set only **outputColumn** fields to **NULL**; **param** fields will be unaffected.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetParamValue](../vs140/cdaorecordset--setparamvalue.md)