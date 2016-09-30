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
Transfers arrays of bytes between the field data members of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and the columns of a record on the data source of ODBC type **SQL_BINARY**, **SQL_VARBINARY**, or **SQL_LONGVARBINARY**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an object of class [CFieldExchange](../vs140/cfieldexchange-class.md). This object contains information to define the context for each call of the function. For more information about the operations a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object can specify, see the article [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type [CByteArray](../vs140/cbytearray-class.md), is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The maximum allowed length of the string or array being transferred. The default value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is 255. Legal values are 1 to [INT_MAX](../vs140/data-type-constants.md). The framework allocates this amount of space for the data. For best performance, pass a value large enough to accommodate the largest data item you expect.  
  
## Remarks  
 Data in the data source of these types is mapped to and from type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the recordset.  
  
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
 [RFX_LongBinary](../vs140/rfx_longbinary.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)