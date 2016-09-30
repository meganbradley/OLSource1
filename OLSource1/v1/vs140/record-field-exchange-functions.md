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
  
 If you are using the ODBC-based classes and you have implemented bulk row fetching, you must manually override the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> by calling the Bulk RFX functions for each data member corresponding to a data source column.  
  
 If you have not implemented bulk row fetching in the ODBC-based classes, or if you are using the DAO-based classes, then ClassWizard will override the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> by calling the RFX functions (for ODBC classes) or the DFX functions (for DAO classes) for each field data member in your recordset.  
  
 The record field exchange functions transfer data each time the framework calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Each function transfers a specific data type.  
  
 For more information about how these functions are used, see the articles [Record Field Exchange: How RFX Works (ODBC)](../vs140/record-field-exchange--how-rfx-works.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 For columns of data that you bind dynamically, you can also call the RFX or DFX functions yourself, as explained in the articles [Recordset: Dynamically Binding Data Columns (ODBC)](../vs140/recordset--dynamically-binding-data-columns--odbc-.md). Additionally, you can write your own custom RFX or DFX routines, as explained in Technical Note [43](../vs140/tn043--rfx-routines.md) (for ODBC) and Technical Note [53](../vs140/tn053--custom-dfx-routines-for-dao-database-classes.md) (for DAO).  
  
 For an example of RFX and Bulk RFX functions as they appear in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> functions, see [RFX_Text](../vs140/rfx_text.md) and [RFX_Text_Bulk](../vs140/rfx_text_bulk.md). DFX functions are very similar to the RFX functions.  
  
### RFX Functions (ODBC)  
  
|||  
|-|-|  
|[RFX_Binary](../vs140/rfx_binary.md)|Transfers arrays of bytes of type [CByteArray](../vs140/cbytearray-class.md).|  
|[RFX_Bool](../vs140/rfx_bool.md)|Transfers Boolean data.|  
|[RFX_Byte](../vs140/rfx_byte.md)|Transfers a single byte of data.|  
|[RFX_Date](../vs140/rfx_date.md)|Transfers time and date data using [CTime](../vs140/ctime-class.md) or **TIMESTAMP_STRUCT**.|  
|[RFX_Double](../vs140/rfx_double.md)|Transfers double-precision float data.|  
|[RFX_Int](../vs140/rfx_int.md)|Transfers integer data.|  
|[RFX_Long](../vs140/rfx_long.md)|Transfers long integer data.|  
|[RFX_LongBinary](../vs140/rfx_longbinary.md)|Transfers binary large object (BLOB) data with an object of the [CLongBinary](../vs140/clongbinary-class.md) class.|  
|[RFX_Single](../vs140/rfx_single.md)|Transfers float data.|  
|[RFX_Text](../vs140/rfx_text.md)|Transfers string data.|  
  
### Bulk RFX Functions (ODBC)  
  
|||  
|-|-|  
|[RFX_Binary_Bulk](../vs140/rfx_binary_bulk.md)|Transfers arrays of byte data.|  
|[RFX_Bool_Bulk](../vs140/rfx_bool_bulk.md)|Transfers arrays of Boolean data.|  
|[RFX_Byte_Bulk](../vs140/rfx_byte_bulk.md)|Transfers arrays of single bytes.|  
|[RFX_Date_Bulk](../vs140/rfx_date_bulk.md)|Transfers arrays of data of type **TIMESTAMP_STRUCT**.|  
|[RFX_Double_Bulk](../vs140/rfx_double_bulk.md)|Transfers arrays of double-precision, floating-point data.|  
|[RFX_Int_Bulk](../vs140/rfx_int_bulk.md)|Transfers arrays of integer data.|  
|[RFX_Long_Bulk](../vs140/rfx_long_bulk.md)|Transfers arrays of long integer data.|  
|[RFX_Single_Bulk](../vs140/rfx_single_bulk.md)|Transfers arrays of floating-point data.|  
|[RFX_Text_Bulk](../vs140/rfx_text_bulk.md)|Transfers arrays of data of type **LPSTR**.|  
  
### DFX Functions (DAO)  
  
|||  
|-|-|  
|[DFX_Binary](../vs140/dfx_binary.md)|Transfers arrays of bytes of type [CByteArray](../vs140/cbytearray-class.md).|  
|[DFX_Bool](../vs140/dfx_bool.md)|Transfers Boolean data.|  
|[DFX_Byte](../vs140/dfx_byte.md)|Transfers a single byte of data.|  
|[DFX_Currency](../vs140/dfx_currency.md)|Transfers currency data, of type [COleCurrency](../vs140/colecurrency-class.md).|  
|[DFX_DateTime](../vs140/dfx_datetime.md)|Transfers time and date data, of type [COleDateTime](../vs140/coledatetime-class.md).|  
|[DFX_Double](../vs140/dfx_double.md)|Transfers double-precision float data.|  
|[DFX_Long](../vs140/dfx_long.md)|Transfers long integer data.|  
|[DFX_LongBinary](../vs140/dfx_longbinary.md)|Transfers binary large object (BLOB) data with an object of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class. For DAO, it is recommended that you use [DFX_Binary](../vs140/dfx_binary.md) instead.|  
|[DFX_Short](../vs140/dfx_short.md)|Transfers short integer data.|  
|[DFX_Single](../vs140/dfx_single.md)|Transfers float data.|  
|[DFX_Text](../vs140/dfx_text.md)|Transfers string data.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CRecordset::DoFieldExchange](../vs140/crecordset--dofieldexchange.md)   
 [CRecordset::DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md)   
 [CDaoRecordset::DoFieldExchange](../vs140/cdaorecordset--dofieldexchange.md)