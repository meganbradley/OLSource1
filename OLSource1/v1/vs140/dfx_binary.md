---
title: "DFX_Binary"
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
  - "DFX_Binary"
  - "AFXDAO/DFX_Binary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DFX functions"
  - "DFX_Binary function"
  - "binary data, exchanging with data source"
  - "DAO (Data Access Objects), exchanging data with data sources"
ms.assetid: 678021a3-2e46-44d7-8528-71bb692dcc07
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DFX_Binary
Transfers arrays of bytes between the field data members of a [CDaoRecordset](../vs140/cdaorecordset-class.md) object and the columns of a record on the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an object of class [CDaoFieldExchange](../vs140/cdaofieldexchange-class.md). This object contains information to define the context for each call of the function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type [CByteArray](../vs140/cbytearray-class.md), is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The framework preallocates this amount of memory. If your data is larger, the framework will allocated more space as needed. For better performance, set this size to a value large enough to prevent reallocations. The default size is defined in the AFXDAO.H file as **AFX_DAO_BINARY_DEFAULT_SIZE**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An option that lets you take advantage of MFC's double buffering mechanism for detecting recordset fields that have changed. The default, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, does not use double buffering, and you must call [SetFieldDirty](../vs140/cdaorecordset--setfielddirty.md) and [SetFieldNull](../vs140/cdaorecordset--setfieldnull.md) yourself. The other possible value, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, uses double buffering, and you do not have to do extra work to mark fields dirty or Null. For performance and memory reasons, avoid this value unless your binary data is relatively small.  
  
> [!NOTE]
>  You can control whether data is double buffered for all fields by default by setting [CDaoRecordset::m_bCheckCacheForDirtyFields](../vs140/cdaorecordset--m_bcheckcachefordirtyfields.md).  
  
## Remarks  
 Data is mapped between type **DAO_BYTES** in DAO and type [CByteArray](../vs140/cbytearray-class.md) in the recordset.  
  
## Example  
 See [DFX_Text](../vs140/dfx_text.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DFX_Text](../vs140/dfx_text.md)   
 [DFX_Bool](../vs140/dfx_bool.md)   
 [DFX_Currency](../vs140/dfx_currency.md)   
 [DFX_Long](../vs140/dfx_long.md)   
 [DFX_Short](../vs140/dfx_short.md)   
 [DFX_Single](../vs140/dfx_single.md)   
 [DFX_Double](../vs140/dfx_double.md)   
 [DFX_DateTime](../vs140/dfx_datetime.md)   
 [DFX_Byte](../vs140/dfx_byte.md)   
 [DFX_LongBinary](../vs140/dfx_longbinary.md)   
 [CDaoFieldExchange::SetFieldType](../vs140/cdaofieldexchange--setfieldtype.md)