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
Transfers `CString` data between the field data members of a [CDaoRecordset](../vs140/cdaorecordset-class.md) object and columns of a record on the data source.  
  
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
 A pointer to an object of class [CDaoFieldExchange](../vs140/cdaofieldexchange-class.md). This object contains information to define the context for each call of the function.  
  
 `szName`  
 The name of a data column.  
  
 *value*  
 The value stored in the indicated data member — the value to be transferred. For a transfer from recordset to data source, the value, of type [CString](../vs140/cstringt-class.md), is taken from the specified data member. For a transfer from data source to recordset, the value is stored in the specified data member.  
  
 `nPreAllocSize`  
 The framework preallocates this amount of memory. If your data is larger, the framework will allocated more space as needed. For better performance, set this size to a value large enough to prevent reallocations.  
  
 `dwBindOptions`  
 An option that lets you take advantage of MFC's double buffering mechanism for detecting recordset fields that have changed. The default, `AFX_DAO_ENABLE_FIELD_CACHE`, uses double buffering. The other possible value is `AFX_DAO_DISABLE_FIELD_CACHE`. If you specify this value, MFC does no checking on this field. You must call [SetFieldDirty](../vs140/cdaorecordset--setfielddirty.md) and [SetFieldNull](../vs140/cdaorecordset--setfieldnull.md) yourself.  
  
> [!NOTE]
>  You can control whether data is double buffered by default by setting [CDaoRecordset::m_bCheckCacheForDirtyFields](../vs140/cdaorecordset--m_bcheckcachefordirtyfields.md).  
  
## Remarks  
 Data is mapped between type **DAO_CHAR** in DAO (or, if the symbol **_UNICODE** is defined, **DAO_WCHAR**) and type [CString](../vs140/cstringt-class.md) in the recordset.  
  
## Example  
 This example shows several calls to `DFX_Text`. Notice also the two calls to [CDaoFieldExchange::SetFieldType](../vs140/cdaofieldexchange--setfieldtype.md). You must write the first call to `SetFieldType` and its **DFX** call. The second call and its associated **DFX** calls are normally written by the code wizard that generated the class.  
  
 [!code[NVC_MFCDatabase#2](../vs140/codesnippet/CPP/dfx_text_1.cpp)]  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DFX_Bool](../vs140/dfx_bool.md)   
 [DFX_Long](../vs140/dfx_long.md)   
 [DFX_Currency](../vs140/dfx_currency.md)   
 [DFX_Short](../vs140/dfx_short.md)   
 [DFX_Single](../vs140/dfx_single.md)   
 [DFX_Double](../vs140/dfx_double.md)   
 [DFX_DateTime](../vs140/dfx_datetime.md)   
 [DFX_Byte](../vs140/dfx_byte.md)   
 [DFX_Binary](../vs140/dfx_binary.md)   
 [DFX_LongBinary](../vs140/dfx_longbinary.md)   
 [CDaoFieldExchange::SetFieldType](../vs140/cdaofieldexchange--setfieldtype.md)