---
title: "RFX_Text"
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
  - "AFXDB/RFX_Text"
  - "RFX_Text"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RFX_Text function"
  - "RFX functions"
ms.assetid: de3c7581-d26c-40cb-81f3-c492ef4809f6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RFX_Text
Transfers <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data between the field data members of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object and columns of a record on the data source of ODBC type **SQL_LONGVARCHAR**, **SQL_CHAR**, **SQL_VARCHAR**, **SQL_DECIMAL**, or **SQL_NUMERIC**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an object of class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This object contains information to define the context for each call of the function. For more information about the operations a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object can specify, see the article [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The maximum allowed length of the string or array being transferred. The default value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is 255. Legal values are 1 to [INT_MAX](../vs140/data-type-constants.md). The framework allocates this amount of space for the data. For best performance, pass a value large enough to accommodate the largest data item you expect.  
  
 *nColumnType*  
 Used mainly for parameters. An integer indicating the data type of the parameter. The type is an ODBC data type of the form **SQL_XXX**.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the scale for values of ODBC type **SQL_DECIMAL** or **SQL_NUMERIC**. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is only useful when setting parameter values. For more information, see the topic "Precision, Scale, Length, and Display Size" in Appendix D of the *ODBC SDK Programmer's Reference*.  
  
## Remarks  
 Data in the data source of all of these types is mapped to and from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the recordset.  
  
## Example  
 This example shows several calls to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Notice also the two calls to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For parameters you must write the call to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and its RFX call. The output column call and its associated RFX calls are normally written by a code wizard.  
  
 [!code[NVC_MFCDatabase#19](../vs140/codesnippet/CPP/rfx_text_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [RFX_Bool](../vs140/rfx_bool.md)   
 [RFX_Long](../vs140/rfx_long.md)   
 [RFX_Int](../vs140/rfx_int.md)   
 [RFX_Single](../vs140/rfx_single.md)   
 [RFX_Double](../vs140/rfx_double.md)   
 [RFX_Date](../vs140/rfx_date.md)   
 [RFX_Byte](../vs140/rfx_byte.md)   
 [RFX_Binary](../vs140/rfx_binary.md)   
 [RFX_LongBinary](../vs140/rfx_longbinary.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)