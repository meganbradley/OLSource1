---
title: "RFX_Int"
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
  - "RFX_Int"
  - "AFXDB/RFX_Int"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RFX_Int function"
  - "RFX functions"
ms.assetid: c4e6b1bf-d6d3-4fbf-b4ca-c4f426ac6979
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RFX_Int
Transfers integer data between the field data members of a `CRecordset` object and the columns of a record on the data source of ODBC type **SQL_SMALLINT**.  
  
## Syntax  
  
```  
  
      void RFX_Int(  
   CFieldExchange* pFX,  
   const char* szName,  
   int& value   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to an object of class [CFieldExchange](../vs140/cfieldexchange-class.md). This object contains information to define the context for each call of the function. For more information about the operations a `CFieldExchange` object can specify, see the article [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md).  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type `int`, is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
## Example  
 See [RFX_Text](../vs140/rfx_text.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [RFX_Text](../vs140/rfx_text.md)   
 [RFX_Bool](../vs140/rfx_bool.md)   
 [RFX_Long](../vs140/rfx_long.md)   
 [RFX_Single](../vs140/rfx_single.md)   
 [RFX_Double](../vs140/rfx_double.md)   
 [RFX_Date](../vs140/rfx_date.md)   
 [RFX_Byte](../vs140/rfx_byte.md)   
 [RFX_Binary](../vs140/rfx_binary.md)   
 [RFX_LongBinary](../vs140/rfx_longbinary.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)