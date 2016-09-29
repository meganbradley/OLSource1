---
title: "RFX_Binary_Bulk"
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
  - "AFXDB/RFX_Binary_Bulk"
  - "RFX_Binary_Bulk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bulk RFX functions"
  - "RFX_Binary_Bulk function"
ms.assetid: 891c7d7e-a4e6-4691-a286-cb933357e6da
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RFX_Binary_Bulk
Transfers multiple rows of byte data from a column of an ODBC data source to a corresponding array in a `CRecordset`-derived object.  
  
## Syntax  
  
```  
  
      void RFX_Binary_Bulk(  
   CFieldExchange* pFX,  
   LPCTSTR szName,  
   BYTE** prgByteVals,  
   long** prgLengths,  
   int nMaxLength   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to a [CFieldExchange](../vs140/cfieldexchange-class.md) object. This object contains information to define the context for each call of the function. For more information, see the article [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md).  
  
 `szName`  
 The name of a data column.  
  
 `prgByteVals`  
 A pointer to an array of **BYTE** values. This array will store the data to be transferred from the data source to the recordset.  
  
 `prgLengths`  
 A pointer to an array of long integers. This array will store the length in bytes of each value in the array pointed to by `prgByteVals`. Note that the value **SQL_NULL_DATA** will be stored if the corresponding data item contains a Null value. For more details, see the ODBC API function **SQLBindCol** in the *ODBC SDK Programmer's Reference*.  
  
 `nMaxLength`  
 The maximum allowed length of the values stored in the array pointed to by `prgByteVals`. To ensure that data will not be truncated, pass a value large enough to accommodate the largest data item you expect.  
  
## Remarks  
 The data source column can have an ODBC type of **SQL_BINARY**, **SQL_VARBINARY**, or **SQL_LONGVARBINARY**. The recordset must define a field data member of type pointer to **BYTE**.  
  
 If you initialize `prgByteVals` and `prgLengths` to **NULL**, then the arrays they point to will be allocated automatically, with sizes equal to the rowset size.  
  
> [!NOTE]
>  Bulk record field exchange only transfers data from the data source to the recordset object. In order to make your recordset updateable, you must use the ODBC API function **SQLSetPos**.  
  
 For more information, see the articles [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md) and [Record Field Exchange (RFX)](../vs140/record-field-exchange--rfx-.md).  
  
## Example  
 See [RFX_Text_Bulk](../vs140/rfx_text_bulk.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [RFX_Bool_Bulk](../vs140/rfx_bool_bulk.md)   
 [RFX_Byte_Bulk](../vs140/rfx_byte_bulk.md)   
 [RFX_Date_Bulk](../vs140/rfx_date_bulk.md)   
 [RFX_Double_Bulk](../vs140/rfx_double_bulk.md)   
 [RFX_Int_Bulk](../vs140/rfx_int_bulk.md)   
 [RFX_Long_Bulk](../vs140/rfx_long_bulk.md)   
 [RFX_Single_Bulk](../vs140/rfx_single_bulk.md)   
 [RFX_Text_Bulk](../vs140/rfx_text_bulk.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)