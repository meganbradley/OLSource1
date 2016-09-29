---
title: "RFX_Text_Bulk"
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
  - "RFX_Text_Bulk"
  - "AFXDB/RFX_Text_Bulk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bulk RFX functions"
  - "RFX_Text_Bulk function"
ms.assetid: c5bed6e5-313d-4d3f-8a87-c032e41f63a7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RFX_Text_Bulk
Transfers multiple rows of character data from a column of an ODBC data source to a corresponding array in a `CRecordset`-derived object.  
  
## Syntax  
  
```  
  
      void RFX_Text_Bulk(  
   CFieldExchange* pFX,  
   LPCTSTR szName,  
   LPSTR* prgStrVals,  
   long** prgLengths,  
   int nMaxLength   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to a [CFieldExchange](../vs140/cfieldexchange-class.md) object. This object contains information to define the context for each call of the function. For more information, see the article [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md).  
  
 `szName`  
 The name of a data column.  
  
 `prgStrVals`  
 A pointer to an array of **LPSTR** values. This array will store the data to be transferred from the data source to the recordset. Note that with the current version of ODBC, these values cannot be Unicode.  
  
 `prgLengths`  
 A pointer to an array of long integers. This array will store the length in bytes of each value in the array pointed to by `prgStrVals`. This length excludes the null termination character. Note that the value **SQL_NULL_DATA** will be stored if the corresponding data item contains a Null value. For more details, see the ODBC API function **SQLBindCol** in the *ODBC SDK Programmer's Reference*.  
  
 `nMaxLength`  
 The maximum allowed length of the values stored in the array pointed to by `prgStrVals`, including the null termination character. To ensure that data will not be truncated, pass a value large enough to accommodate the largest data item you expect.  
  
## Remarks  
 The data source column can have an ODBC type of **SQL_LONGVARCHAR**, **SQL_CHAR**, **SQL_VARCHAR**, **SQL_DECIMAL**, or **SQL_NUMERIC**. The recordset must define a field data member of type **LPSTR**.  
  
 If you initialize `prgStrVals` and `prgLengths` to **NULL**, then the arrays they point to will be allocated automatically, with sizes equal to the rowset size.  
  
> [!NOTE]
>  Bulk record field exchange only transfers data from the data source to the recordset object. To make your recordset updateable, you must use the ODBC API function **SQLSetPos**.  
  
 For more information, see the articles [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md) and [Record Field Exchange (RFX)](../vs140/record-field-exchange--rfx-.md).  
  
## Example  
 You must manually write calls in your `DoBulkFieldExchange` override. This example shows a call to `RFX_Text_Bulk`, as well as a call to `RFX_Long_Bulk`, for data transfer. These calls are preceded by a call to [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md). Note that for parameters, you must call the RFX functions instead of the Bulk RFX functions.  
  
 [!code[NVC_MFCDatabase#42](../vs140/codesnippet/CPP/rfx_text_bulk_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [RFX_Binary_Bulk](../vs140/rfx_binary_bulk.md)   
 [RFX_Bool_Bulk](../vs140/rfx_bool_bulk.md)   
 [RFX_Byte_Bulk](../vs140/rfx_byte_bulk.md)   
 [RFX_Date_Bulk](../vs140/rfx_date_bulk.md)   
 [RFX_Double_Bulk](../vs140/rfx_double_bulk.md)   
 [RFX_Int_Bulk](../vs140/rfx_int_bulk.md)   
 [RFX_Long_Bulk](../vs140/rfx_long_bulk.md)   
 [RFX_Single_Bulk](../vs140/rfx_single_bulk.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)