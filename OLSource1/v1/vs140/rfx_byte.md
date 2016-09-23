---
title: "RFX_Byte"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AFXDB/RFX_Byte
  - RFX_Byte
dev_langs: 
  - C++
helpviewer_keywords: 
  - RFX_Byte function
  - RFX functions
ms.assetid: 2572d906-94b1-404b-bf2b-fb095da8359c
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# RFX_Byte
Transfers single bytes between the field data members of a `CRecordset` object and the columns of a record on the data source of ODBC type **SQL_TINYINT**.  
  
## Syntax  
  
```  
  
      void RFX_Byte(  
   CFieldExchange* pFX,  
   const char* szName,  
   BYTE& value   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to an object of class [CFieldExchange](../vs140/cfieldexchange-class.md). This object contains information to define the context for each call of the function. For more information about the operations a `CFieldExchange` object can specify, see the article [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md).  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type **BYTE**, is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
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
 [RFX_Binary](../vs140/rfx_binary.md)   
 [RFX_LongBinary](../vs140/rfx_longbinary.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)