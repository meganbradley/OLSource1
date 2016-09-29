---
title: "Record Field Exchange Functions"
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
  - "vc.mfc.macros"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), record field exchange (DFX)"
  - "ODBC, bulk RFX data exchange functions"
  - "RFX (record field exchange), ODBC classes"
  - "DFX (DAO record field exchange), data exchange functions"
  - "DFX functions"
  - "bulk RFX functions"
  - "DFX (DAO record field exchange)"
  - "RFX (record field exchange), DAO classes"
  - "ODBC, RFX"
  - "RFX (record field exchange), data exchange functions"
  - "RFX (record field exchange)"
ms.assetid: 6e4c5c1c-acb7-4c18-bf51-bf7959a696cd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Record Field Exchange Functions
This topic lists the Record Field Exchange ([RFX](#_mfc_rfx_functions_.28.odbc.29), [Bulk RFX](#_mfc_bulk_rfx_functions_.28.odbc.29), and [DFX](#_mfc_dfx_functions_.28.dao.29)) functions used to automate the transfer of data between a recordset object and its data source and to perform other operations on the data.  
  
 If you are using the ODBC-based classes and you have implemented bulk row fetching, you must manually override the `DoBulkFieldExchange` member function of `CRecordset` by calling the Bulk RFX functions for each data member corresponding to a data source column.  
  
 If you have not implemented bulk row fetching in the ODBC-based classes, or if you are using the DAO-based classes, then ClassWizard will override the `DoFieldExchange` member function of `CRecordset` or `CDaoRecordset` by calling the RFX functions (for ODBC classes) or the DFX functions (for DAO classes) for each field data member in your recordset.  
  
 The record field exchange functions transfer data each time the framework calls `DoFieldExchange` or `DoBulkFieldExchange`. Each function transfers a specific data type.  
  
 For more information about how these functions are used, see the articles [Record Field Exchange: How RFX Works (ODBC)](../VS_csharp/record-field-exchange--how-rfx-works.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../VS_csharp/recordset--fetching-records-in-bulk--odbc-.md).  
  
 For columns of data that you bind dynamically, you can also call the RFX or DFX functions yourself, as explained in the articles [Recordset: Dynamically Binding Data Columns (ODBC)](../VS_csharp/recordset--dynamically-binding-data-columns--odbc-.md). Additionally, you can write your own custom RFX or DFX routines, as explained in Technical Note [43](../VS_csharp/tn043--rfx-routines.md) (for ODBC) and Technical Note [53](../VS_csharp/tn053--custom-dfx-routines-for-dao-database-classes.md) (for DAO).  
  
 For an example of RFX and Bulk RFX functions as they appear in the `DoFieldExchange` and `DoBulkFieldExchange` functions, see [RFX_Text](../VS_csharp/rfx_text.md) and [RFX_Text_Bulk](../VS_csharp/rfx_text_bulk.md). DFX functions are very similar to the RFX functions.  
  
### RFX Functions (ODBC)  
  
|||  
|-|-|  
|[RFX_Binary](../VS_csharp/rfx_binary.md)|Transfers arrays of bytes of type [CByteArray](../VS_csharp/cbytearray-class.md).|  
|[RFX_Bool](../VS_csharp/rfx_bool.md)|Transfers Boolean data.|  
|[RFX_Byte](../VS_csharp/rfx_byte.md)|Transfers a single byte of data.|  
|[RFX_Date](../VS_csharp/rfx_date.md)|Transfers time and date data using [CTime](../VS_csharp/ctime-class.md) or **TIMESTAMP_STRUCT**.|  
|[RFX_Double](../VS_csharp/rfx_double.md)|Transfers double-precision float data.|  
|[RFX_Int](../VS_csharp/rfx_int.md)|Transfers integer data.|  
|[RFX_Long](../VS_csharp/rfx_long.md)|Transfers long integer data.|  
|[RFX_LongBinary](../VS_csharp/rfx_longbinary.md)|Transfers binary large object (BLOB) data with an object of the [CLongBinary](../VS_csharp/clongbinary-class.md) class.|  
|[RFX_Single](../VS_csharp/rfx_single.md)|Transfers float data.|  
|[RFX_Text](../VS_csharp/rfx_text.md)|Transfers string data.|  
  
### Bulk RFX Functions (ODBC)  
  
|||  
|-|-|  
|[RFX_Binary_Bulk](../VS_csharp/rfx_binary_bulk.md)|Transfers arrays of byte data.|  
|[RFX_Bool_Bulk](../VS_csharp/rfx_bool_bulk.md)|Transfers arrays of Boolean data.|  
|[RFX_Byte_Bulk](../VS_csharp/rfx_byte_bulk.md)|Transfers arrays of single bytes.|  
|[RFX_Date_Bulk](../VS_csharp/rfx_date_bulk.md)|Transfers arrays of data of type **TIMESTAMP_STRUCT**.|  
|[RFX_Double_Bulk](../VS_csharp/rfx_double_bulk.md)|Transfers arrays of double-precision, floating-point data.|  
|[RFX_Int_Bulk](../VS_csharp/rfx_int_bulk.md)|Transfers arrays of integer data.|  
|[RFX_Long_Bulk](../VS_csharp/rfx_long_bulk.md)|Transfers arrays of long integer data.|  
|[RFX_Single_Bulk](../VS_csharp/rfx_single_bulk.md)|Transfers arrays of floating-point data.|  
|[RFX_Text_Bulk](../VS_csharp/rfx_text_bulk.md)|Transfers arrays of data of type **LPSTR**.|  
  
### DFX Functions (DAO)  
  
|||  
|-|-|  
|[DFX_Binary](../VS_csharp/dfx_binary.md)|Transfers arrays of bytes of type [CByteArray](../VS_csharp/cbytearray-class.md).|  
|[DFX_Bool](../VS_csharp/dfx_bool.md)|Transfers Boolean data.|  
|[DFX_Byte](../VS_csharp/dfx_byte.md)|Transfers a single byte of data.|  
|[DFX_Currency](../VS_csharp/dfx_currency.md)|Transfers currency data, of type [COleCurrency](../VS_csharp/colecurrency-class.md).|  
|[DFX_DateTime](../VS_csharp/dfx_datetime.md)|Transfers time and date data, of type [COleDateTime](../VS_csharp/coledatetime-class.md).|  
|[DFX_Double](../VS_csharp/dfx_double.md)|Transfers double-precision float data.|  
|[DFX_Long](../VS_csharp/dfx_long.md)|Transfers long integer data.|  
|[DFX_LongBinary](../VS_csharp/dfx_longbinary.md)|Transfers binary large object (BLOB) data with an object of the `CLongBinary` class. For DAO, it is recommended that you use [DFX_Binary](../VS_csharp/dfx_binary.md) instead.|  
|[DFX_Short](../VS_csharp/dfx_short.md)|Transfers short integer data.|  
|[DFX_Single](../VS_csharp/dfx_single.md)|Transfers float data.|  
|[DFX_Text](../VS_csharp/dfx_text.md)|Transfers string data.|  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [CRecordset::DoFieldExchange](../Topic/CRecordset::DoFieldExchange.md)   
 [CRecordset::DoBulkFieldExchange](../Topic/CRecordset::DoBulkFieldExchange.md)   
 [CDaoRecordset::DoFieldExchange](../Topic/CDaoRecordset::DoFieldExchange.md)