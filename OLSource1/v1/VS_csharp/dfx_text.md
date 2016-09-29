---
title: "DFX_Text"
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
  - "AFXDAO/DFX_Text"
  - "DFX_Text"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CString objects, data"
  - "DFX functions"
  - "text, exchanging with data source"
  - "DFX_Text function"
  - "DAO (Data Access Objects), exchanging data with data sources"
ms.assetid: c4a2c4d5-76c5-4c7d-915b-d9e06c8b1de5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DFX_Text
Transfers `CString` data between the field data members of a [CDaoRecordset](../VS_csharp/cdaorecordset-class.md) object and columns of a record on the data source.  
  
## Syntax  
  
```  
  
      void AFXAPI DFX_Text(  
   CDaoFieldExchange* pFX,  
   LPCTSTR szName,  
   CString& value,  
   int nPreAllocSize = AFX_DAO_TEXT_DEFAULT_SIZE,  
   DWORD dwBindOptions = AFX_DAO_ENABLE_FIELD_CACHE   
);  
```  
  
#### Parameters  
 `pFX`  
 A pointer to an object of class [CDaoFieldExchange](../VS_csharp/cdaofieldexchange-class.md). This object contains information to define the context for each call of the function.  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type [CString](../VS_csharp/cstringt-class.md), is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 `nPreAllocSize`  
 The framework preallocates this amount of memory. If your data is larger, the framework will allocated more space as needed. For better performance, set this size to a value large enough to prevent reallocations.  
  
 `dwBindOptions`  
 An option that lets you take advantage of MFC's double buffering mechanism for detecting recordset fields that have changed. The default, `AFX_DAO_ENABLE_FIELD_CACHE`, uses double buffering. The other possible value is `AFX_DAO_DISABLE_FIELD_CACHE`. If you specify this value, MFC does no checking on this field. You must call [SetFieldDirty](../Topic/CDaoRecordset::SetFieldDirty.md) and [SetFieldNull](../Topic/CDaoRecordset::SetFieldNull.md) yourself.  
  
> [!NOTE]
>  You can control whether data is double buffered by default by setting [CDaoRecordset::m_bCheckCacheForDirtyFields](../Topic/CDaoRecordset::m_bCheckCacheForDirtyFields.md).  
  
## Remarks  
 Data is mapped between type **DAO_CHAR** in DAO (or, if the symbol **_UNICODE** is defined, **DAO_WCHAR**) and type [CString](../VS_csharp/cstringt-class.md) in the recordset.  
  
## Example  
 This example shows several calls to `DFX_Text`. Notice also the two calls to [CDaoFieldExchange::SetFieldType](../Topic/CDaoFieldExchange::SetFieldType.md). You must write the first call to `SetFieldType` and its **DFX** call. The second call and its associated **DFX** calls are normally written by the code wizard that generated the class.  
  
 [!code[NVC_MFCDatabase#2](../VS_csharp/codesnippet/CPP/dfx_text_1.cpp)]  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DFX_Bool](../VS_csharp/dfx_bool.md)   
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