---
title: "RFX_LongBinary"
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
  - "AFXDB/RFX_LongBinary"
  - "RFX_LongBinary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RFX_LongBinary function"
  - "RFX functions"
ms.assetid: 2249ff6d-1598-4660-9197-1fa1e4fc1451
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RFX_LongBinary
Transfers binary large object (BLOB) data using class [CLongBinary](../vs140/clongbinary-class.md) between the field data members of a `CRecordset` object and the columns of a record on the data source of ODBC type **SQL_LONGVARBINARY** or **SQL_LONGVARCHAR**.  
  
## Syntax  
  
```  
  
      void RFX_LongBinary(  
   CFieldExchange* pFX,  
   const char* szName,  
   CLongBinary& value   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to an object of class [CFieldExchange](../vs140/cfieldexchange-class.md). This object contains information to define the context for each call of the function. For more information about the operations a `CFieldExchange` object can specify, see the article [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md).  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type `CLongBinary`, is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
## Example  
 See [RFX_Text](../vs140/rfx_text.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [RFX_Text](../vs140/rfx_text.md)   
 [RFX_Bool](../vs140/rfx_bool.md)   
 [RFX_Long](../vs140/rfx_long.md)   
 [RFX_Int](../vs140/rfx_int.md)   
 [RFX_Single](../vs140/rfx_single.md)   
 [RFX_Double](../vs140/rfx_double.md)   
 [RFX_Date](../vs140/rfx_date.md)   
 [RFX_Byte](../vs140/rfx_byte.md)   
 [RFX_Binary](../vs140/rfx_binary.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)   
 [CLongBinary Class](../vs140/clongbinary-class.md)