---
title: "DFX_DateTime"
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
  - "AFXDAO/DFX_DateTime"
  - "DFX_DateTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "time, exchanging time data with data source"
  - "DFX functions"
  - "time, exchanging with data source"
  - "DFX_DateTime function"
  - "dates, recordset data"
  - "dates, exchanging with data source"
  - "dates"
  - "DAO (Data Access Objects), exchanging data with data sources"
ms.assetid: 5f28ac10-9d30-4bdb-a540-215f017d1005
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DFX_DateTime
Transfers time and date data between the field data members of a [CDaoRecordset](../VS_csharp/cdaorecordset-class.md) object and the columns of a record on the data source.  
  
## Syntax  
  
```  
  
      void AFXAPI DFX_DateTime(  
   CDaoFieldExchange* pFX,  
   LPCTSTR szName,  
   COleDateTime& value,  
   DWORD dwBindOptions = AFX_DAO_ENABLE_FIELD_CACHE   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to an object of class [CDaoFieldExchange](../VS_csharp/cdaofieldexchange-class.md). This object contains information to define the context for each call of the function.  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. The function takes a reference to a [COleDateTime](../VS_csharp/coledatetime-class.md) object. For a transfer from recordset to data source, this value is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 `dwBindOptions`  
 An option that lets you take advantage of MFC's double buffering mechanism for detecting recordset fields that have changed. The default, `AFX_DAO_ENABLE_FIELD_CACHE`, uses double buffering. The other possible value is `AFX_DAO_DISABLE_FIELD_CACHE`. If you specify this value, MFC does no checking on this field. You must call `SetFieldDirty` and `SetFieldNull` yourself.  
  
> [!NOTE]
>  You can control whether data is double buffered by default by setting [CDaoRecordset::m_bCheckCacheForDirtyFields](../Topic/CDaoRecordset::m_bCheckCacheForDirtyFields.md).  
  
## Remarks  
 Data is mapped between type **DAO_DATE** in DAO and type [COleDateTime](../VS_csharp/coledatetime-class.md) in the recordset.  
  
> [!NOTE]
>  `COleDateTime` replaces [CTime](../VS_csharp/ctime-class.md) and **TIMESTAMP_STRUCT** for this purpose in the DAO classes. `CTime` and **TIMESTAMP_STRUCT** are still used for the ODBC-based data access classes.  
  
## Example  
 See [DFX_Text](../VS_csharp/dfx_text.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DFX_Text](../VS_csharp/dfx_text.md)   
 [DFX_Bool](../VS_csharp/dfx_bool.md)   
 [DFX_Currency](../VS_csharp/dfx_currency.md)   
 [DFX_Long](../VS_csharp/dfx_long.md)   
 [DFX_Short](../VS_csharp/dfx_short.md)   
 [DFX_Single](../VS_csharp/dfx_single.md)   
 [DFX_Double](../VS_csharp/dfx_double.md)   
 [DFX_Byte](../VS_csharp/dfx_byte.md)   
 [DFX_Binary](../VS_csharp/dfx_binary.md)   
 [DFX_LongBinary](../VS_csharp/dfx_longbinary.md)   
 [CDaoFieldExchange::SetFieldType](../Topic/CDaoFieldExchange::SetFieldType.md)