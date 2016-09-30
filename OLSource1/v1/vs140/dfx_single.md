---
title: "DFX_Single"
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
  - "AFXDAO/DFX_Single"
  - "DFX_Single"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DFX_Single function"
  - "floating-point numbers, exchanging with data source"
  - "DFX functions"
  - "single float data exchange with data source"
  - "DAO (Data Access Objects), exchanging data with data sources"
ms.assetid: 393113ae-ef11-42eb-a34d-f9b140532496
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DFX_Single
Transfers floating-point data between the field data members of a [CDaoRecordset](../vs140/cdaorecordset-class.md) object and the columns of a record on the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an object of class [CDaoFieldExchange](../vs140/cdaofieldexchange-class.md). This object contains information to define the context for each call of the function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type **float**, is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An option that lets you take advantage of MFC's double buffering mechanism for detecting recordset fields that have changed. The default, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, uses double buffering. The other possible value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If you specify this value, MFC does no checking on this field. You must call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> yourself.  
  
> [!NOTE]
>  You can control whether data is double buffered by default by setting [CDaoRecordset::m_bCheckCacheForDirtyFields](../vs140/cdaorecordset--m_bcheckcachefordirtyfields.md).  
  
## Remarks  
 Data is mapped between type **DAO_R4** in DAO and type **float** in the recordset.  
  
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
 [DFX_Double](../vs140/dfx_double.md)   
 [DFX_DateTime](../vs140/dfx_datetime.md)   
 [DFX_Byte](../vs140/dfx_byte.md)   
 [DFX_Binary](../vs140/dfx_binary.md)   
 [DFX_LongBinary](../vs140/dfx_longbinary.md)   
 [CDaoFieldExchange::SetFieldType](../vs140/cdaofieldexchange--setfieldtype.md)