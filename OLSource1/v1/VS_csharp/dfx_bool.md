---
title: "DFX_Bool"
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
  - "AFXDAO/DFX_Bool"
  - "DFX_Bool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Boolean values, data transfer"
  - "DFX functions"
  - "DFX_Bool function"
  - "DAO (Data Access Objects), exchanging data with data sources"
ms.assetid: d7c9707e-6381-4360-a363-49f817c30a5e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DFX_Bool
Transfers Boolean data between the field data members of a [CDaoRecordset](../VS_csharp/cdaorecordset-class.md) object and the columns of a record on the data source.  
  
## Syntax  
  
```  
  
      void AFXAPI DFX_Bool(  
   CDaoFieldExchange* pFX,  
   LPCTSTR szName,  
   BOOL& value,  
   DWORD dwBindOptions = AFX_DAO_ENABLE_FIELD_CACHE   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to an object of class [CDaoFieldExchange](../VS_csharp/cdaofieldexchange-class.md). This object contains information to define the context for each call of the function.  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type **BOOL**, is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 `dwBindOptions`  
 An option that lets you take advantage of MFC's double buffering mechanism for detecting recordset fields that have changed. The default, `AFX_DAO_ENABLE_FIELD_CACHE`, uses double buffering. The other possible value is `AFX_DAO_DISABLE_FIELD_CACHE`. If you specify this value, MFC does no checking on this field. You must call `SetFieldDirty` and `SetFieldNull` yourself.  
  
> [!NOTE]
>  You can control whether data is double buffered by default by setting [CDaoRecordset::m_bCheckCacheForDirtyFields](../Topic/CDaoRecordset::m_bCheckCacheForDirtyFields.md).  
  
## Remarks  
 Data is mapped between type **DAO_BOOL** in DAO and type **BOOL** in the recordset.  
  
## Example  
 See [DFX_Text](../VS_csharp/dfx_text.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DFX_Text](../VS_csharp/dfx_text.md)   
 [DFX_Long](../VS_csharp/dfx_long.md)   
 [DFX_Currency](../VS_csharp/dfx_currency.md)   
 [DFX_Short](../VS_csharp/dfx_short.md)   
 [DFX_Single](../VS_csharp/dfx_single.md)   
 [DFX_Double](../VS_csharp/dfx_double.md)   
 [DFX_DateTime](../VS_csharp/dfx_datetime.md)   
 [DFX_Byte](../VS_csharp/dfx_byte.md)   
 [DFX_Binary](../VS_csharp/dfx_binary.md)   
 [DFX_LongBinary](../VS_csharp/dfx_longbinary.md)   
 [CDaoFieldExchange::SetFieldType](../Topic/CDaoFieldExchange::SetFieldType.md)