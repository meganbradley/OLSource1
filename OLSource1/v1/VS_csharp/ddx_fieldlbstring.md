---
title: "DDX_FieldLBString"
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
  - "AFXDAO/DDX_FieldLBString"
  - "DDX_FieldLBString"
  - "AFXDB/DDX_FieldLBString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "list boxes, exchanging database data with"
  - "DDX_FieldLBString function"
  - "ODBC, exchanging data with list boxes"
  - "DDX (dialog data exchange), function macros"
  - "DAO (Data Access Objects), exchanging data with controls"
  - "DDX (dialog data exchange), DDX_Field functions"
  - "DDX (dialog data exchange), functions"
ms.assetid: 97013771-ca50-416a-829c-feba800e77cd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_FieldLBString
The `DDX_FieldLBString` copies the current selection of a list box control in a record view to a [CString](../VS_csharp/cstringt-class.md) field data member of a recordset associated with the record view.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_FieldLBString(  
   CDataExchange* pDX,  
   int nIDC,  
   CString& value,  
   CRecordset* pRecordset   
);  
void AFXAPI DDX_FieldLBString(  
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
 In the reverse direction, this function sets the current selection in the list box to the first row that begins with the characters in the string specified by *value*. On a transfer from the recordset to the control, if the recordset field is Null, any selection is removed from the list box. On a transfer from control to recordset, if the control is empty, the recordset field is set to Null.  
  
 Use the first version if you are working with the ODBC-based classes. Use the second version if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../VS_csharp/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../VS_csharp/crecordview-class.md) and [CDaoRecordView](../VS_csharp/cdaorecordview-class.md) fields, see the article [Record Views](../VS_csharp/record-views---mfc-data-access-.md).  
  
## Example  
 See [DDX_FieldText](../VS_csharp/ddx_fieldtext.md) for a general DDX_Field example. Calls to `DDX_FieldLBString` would be similar.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DDX_FieldText](../VS_csharp/ddx_fieldtext.md)   
 [DDX_FieldRadio](../VS_csharp/ddx_fieldradio.md)   
 [DDX_FieldLBStringExact](../VS_csharp/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBString](../VS_csharp/ddx_fieldcbstring.md)   
 [DDX_FieldCBStringExact](../VS_csharp/ddx_fieldcbstringexact.md)   
 [DDX_FieldCBIndex](../VS_csharp/ddx_fieldcbindex.md)   
 [DDX_FieldLBIndex](../VS_csharp/ddx_fieldlbindex.md)   
 [DDX_FieldScroll](../VS_csharp/ddx_fieldscroll.md)