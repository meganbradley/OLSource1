---
title: "RFX_Binary"
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
  - "RFX_Binary"
  - "AFXDB/RFX_Binary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RFX_Binary function"
  - "RFX functions"
ms.assetid: 908ff945-3ad0-43a1-9932-cdcdc8b14915
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RFX_Binary
Transfers arrays of bytes between the field data members of a `CRecordset` object and the columns of a record on the data source of ODBC type **SQL_BINARY**, **SQL_VARBINARY**, or **SQL_LONGVARBINARY**.  
  
## Syntax  
  
```  
  
      void RFX_Binary(  
   CFieldExchange* pFX,  
   const char* szName,  
   CByteArray& value,  
   int nMaxLength = 255   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to an object of class [CFieldExchange](../VS_csharp/cfieldexchange-class.md). This object contains information to define the context for each call of the function. For more information about the operations a `CFieldExchange` object can specify, see the article [Record Field Exchange: How RFX Works](../VS_csharp/record-field-exchange--how-rfx-works.md).  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type [CByteArray](../VS_csharp/cbytearray-class.md), is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 `nMaxLength`  
 The maximum allowed length of the string or array being transferred. The default value of `nMaxLength` is 255. Legal values are 1 to [INT_MAX](../VS_csharp/data-type-constants.md). The framework allocates this amount of space for the data. For best performance, pass a value large enough to accommodate the largest data item you expect.  
  
## Remarks  
 Data in the data source of these types is mapped to and from type `CByteArray` in the recordset.  
  
## Example  
 See [RFX_Text](../VS_csharp/rfx_text.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [RFX_Text](../VS_csharp/rfx_text.md)   
 [RFX_Bool](../VS_csharp/rfx_bool.md)   
 [RFX_Long](../VS_csharp/rfx_long.md)   
 [RFX_Int](../VS_csharp/rfx_int.md)   
 [RFX_Single](../VS_csharp/rfx_single.md)   
 [RFX_Double](../VS_csharp/rfx_double.md)   
 [RFX_Date](../VS_csharp/rfx_date.md)   
 [RFX_Byte](../VS_csharp/rfx_byte.md)   
 [RFX_LongBinary](../VS_csharp/rfx_longbinary.md)   
 [CFieldExchange::SetFieldType](../Topic/CFieldExchange::SetFieldType.md)