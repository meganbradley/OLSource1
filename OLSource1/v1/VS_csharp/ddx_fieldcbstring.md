---
title: "DDX_FieldCBString"
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
  - "AFXDB/DDX_FieldCBString"
  - "AFXDAO/DDX_FieldCBString"
  - "DDX_FieldCBString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_FieldCBString function"
  - "combo boxes, exchanging database data with"
  - "ODBC, exchanging data with combo boxes"
  - "DDX (dialog data exchange), function macros"
  - "DAO (Data Access Objects), exchanging data with controls"
  - "DDX (dialog data exchange), DDX_Field functions"
ms.assetid: c64d7dbc-96af-40da-93fd-53d8afbbb037
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_FieldCBString
The `DDX_FieldCBString` function manages the transfer of [CString](../VS_csharp/cstringt-class.md) data between the edit control of a combo box control in a record view and a `CString` field data member of a recordset associated with the record view.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_FieldCBString(  
   CDataExchange* pDX,  
   int nIDC,  
   CString& value,  
   CRecordset* pRecordset   
);  
void AFXAPI DDX_FieldCBString(  
   CDataExchange* pDX,  
   int nIDC,  
   CString& value,  
   CDaoRecordset* pRecordset   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../VS_csharp/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The ID of a control in the [CRecordView](../VS_csharp/crecordview-class.md) or [CDaoRecordView](../VS_csharp/cdaorecordview-class.md) object.  
  
 *value*  
 A reference to a field data member in the associated `CRecordset` or `CDaoRecordset` object.  
  
 `pRecordset`  
 A pointer to the [CRecordset](../VS_csharp/crecordset-class.md) or [CDaoRecordset](../VS_csharp/cdaorecordset-class.md) object with which data is exchanged.  
  
## Remarks  
 When moving data from the recordset to the control, this function sets the current selection in the combo box to the first row that begins with the characters in the string specified in *value*. On a transfer from the recordset to the control, if the recordset field is Null, any selection is removed from the combo box and the edit control of the combo box is set to empty. On a transfer from control to recordset, if the control is empty, the recordset field is set to Null if the field permits.  
  
 Use the first version if you are working with the ODBC-based classes. Use the second version if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../VS_csharp/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../VS_csharp/crecordview-class.md) and [CDaoRecordView](../VS_csharp/cdaorecordview-class.md) fields, see the article [Record Views](../VS_csharp/record-views---mfc-data-access-.md).  
  
## Example  
 See [DDX_FieldText](../VS_csharp/ddx_fieldtext.md) for a general DDX_Field example. The example includes a call to `DDX_FieldCBString`.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DDX_FieldText](../VS_csharp/ddx_fieldtext.md)   
 [DDX_FieldRadio](../VS_csharp/ddx_fieldradio.md)   
 [DDX_FieldLBString](../VS_csharp/ddx_fieldlbstring.md)   
 [DDX_FieldLBStringExact](../VS_csharp/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBStringExact](../VS_csharp/ddx_fieldcbstringexact.md)