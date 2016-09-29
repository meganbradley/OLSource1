---
title: "DFX_Byte"
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
  - "AFXDAO/DFX_Byte"
  - "DFX_Byte"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DFX_Byte function"
  - "DFX functions"
  - "BYTE data transfer"
  - "DAO (Data Access Objects), exchanging data with data sources"
ms.assetid: 01d7864e-ff59-44e8-b935-86c8a14f07a6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DFX_Byte
Transfers single bytes between the field data members of a [CDaoRecordset](../VS_csharp/cdaorecordset-class.md) object and the columns of a record on the data source.  
  
## Syntax  
  
```  
  
      void AFXAPI DFX_Byte(  
   CDaoFieldExchange* pFX,  
   LPCTSTR szName,  
   BYTE& value,  
   DWORD dwBindOptions = AFX_DAO_ENABLE_FIELD_CACHE   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to an object of class [CDaoFieldExchange](../VS_csharp/cdaofieldexchange-class.md). This object contains information to define the context for each call of the function.  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type **BYTE**, is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 `dwBindOptions`  
 An option that lets you take advantage of MFC's double buffering mechanism for detecting recordset fields that have changed. The default, `AFX_DAO_ENABLE_FIELD_CACHE`, uses double buffering. The other possible value is `AFX_DAO_DISABLE_FIELD_CACHE`. If you specify this value, MFC does no checking on this field. You must call `SetFieldDirty` and `SetFieldNull` yourself.  
  
> [!NOTE]
>  You can control whether data is double buffered by default by setting [CDaoRecordset::m_bCheckCacheForDirtyFields](../Topic/CDaoRecordset::m_bCheckCacheForDirtyFields.md).  
  
## Remarks  
 Data is mapped between type **DAO_BYTES** in DAO and type **BYTE** in the recordset.  
  
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
 [DFX_DateTime](../VS_csharp/dfx_datetime.md)   
 [DFX_Binary](../VS_csharp/dfx_binary.md)   
 [DFX_LongBinary](../VS_csharp/dfx_longbinary.md)   
 [CDaoFieldExchange::SetFieldType](../Topic/CDaoFieldExchange::SetFieldType.md)