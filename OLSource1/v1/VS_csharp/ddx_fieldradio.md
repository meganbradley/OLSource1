---
title: "DDX_FieldRadio"
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
  - "AFXDB/DDX_FieldRadio"
  - "DDX_FieldRadio"
  - "AFXDAO/DDX_FieldRadio"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "radio buttons, exchanging database data with"
  - "DDX_FieldRadio function"
  - "DAO (Data Access Objects), exchanging data with controls"
  - "ODBC, exchanging data with radio buttons"
  - "DDX (dialog data exchange), DDX_Field functions"
  - "DDX (dialog data exchange), functions"
ms.assetid: 9cf93054-1ff1-488a-9e89-695e982e7430
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_FieldRadio
The `DDX_FieldRadio` function associates a zero-based `int` member variable of a record view's recordset with the currently selected radio button in a group of radio buttons in the record view.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_FieldRadio(  
   CDataExchange* pDX,  
   int nIDC,  
   int& value,  
   CRecordset* pRecordset   
);  
void AFXAPI DDX_FieldRadio(  
   CDataExchange* pDX,  
   int nIDC,  
   int& value,  
   CDaoRecordset* pRecordset   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../VS_csharp/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The ID of the first in a group (with style **WS_GROUP**) of adjacent radio button controls in the [CRecordView](../VS_csharp/crecordview-class.md) or [CDaoRecordView](../VS_csharp/cdaorecordview-class.md) object.  
  
 *value*  
 A reference to a field data member in the associated `CRecordset` or `CDaoRecordset` object.  
  
 `pRecordset`  
 A pointer to the [CRecordset](../VS_csharp/crecordset-class.md) or [CDaoRecordset](../VS_csharp/cdaorecordset-class.md) object with which data is exchanged.  
  
## Remarks  
 When transferring from the recordset field to the view, this function turns on the *nth* radio button (zero-based) and turns off the other buttons. In the reverse direction, this function sets the recordset field to the ordinal number of the radio button that is currently on (checked). On a transfer from the recordset to the control, if the recordset field is Null, no button is selected. On a transfer from control to recordset, if no control is selected, the recordset field is set to Null if the field permits that.  
  
 Use the first version if you are working with the ODBC-based classes. Use the second version if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../VS_csharp/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../VS_csharp/crecordview-class.md) and [CDaoRecordView](../VS_csharp/cdaorecordview-class.md) fields, see the article [Record Views](../VS_csharp/record-views---mfc-data-access-.md).  
  
## Example  
 See [DDX_FieldText](../VS_csharp/ddx_fieldtext.md) for a general DDX_Field example. Calls to `DDX_FieldRadio` would be similar.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DDX_FieldText](../VS_csharp/ddx_fieldtext.md)   
 [DDX_FieldLBString](../VS_csharp/ddx_fieldlbstring.md)   
 [DDX_FieldLBStringExact](../VS_csharp/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBString](../VS_csharp/ddx_fieldcbstring.md)   
 [DDX_FieldCBStringExact](../VS_csharp/ddx_fieldcbstringexact.md)   
 [DDX_FieldCBIndex](../VS_csharp/ddx_fieldcbindex.md)   
 [DDX_FieldLBIndex](../VS_csharp/ddx_fieldlbindex.md)   
 [DDX_FieldScroll](../VS_csharp/ddx_fieldscroll.md)