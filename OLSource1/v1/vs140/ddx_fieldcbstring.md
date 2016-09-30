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
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function manages the transfer of [CString](../vs140/cstringt-class.md) data between the edit control of a combo box control in a record view and a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field data member of a recordset associated with the record view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The ID of a control in the [CRecordView](../vs140/crecordview-class.md) or [CDaoRecordView](../vs140/cdaorecordview-class.md) object.  
  
 *value*  
 A reference to a field data member in the associated <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the [CRecordset](../vs140/crecordset-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md) object with which data is exchanged.  
  
## Remarks  
 When moving data from the recordset to the control, this function sets the current selection in the combo box to the first row that begins with the characters in the string specified in *value*. On a transfer from the recordset to the control, if the recordset field is Null, any selection is removed from the combo box and the edit control of the combo box is set to empty. On a transfer from control to recordset, if the control is empty, the recordset field is set to Null if the field permits.  
  
 Use the first version if you are working with the ODBC-based classes. Use the second version if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../vs140/crecordview-class.md) and [CDaoRecordView](../vs140/cdaorecordview-class.md) fields, see the article [Record Views](../vs140/record-views---mfc-data-access-.md).  
  
## Example  
 See [DDX_FieldText](../vs140/ddx_fieldtext.md) for a general DDX_Field example. The example includes a call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_FieldText](../vs140/ddx_fieldtext.md)   
 [DDX_FieldRadio](../vs140/ddx_fieldradio.md)   
 [DDX_FieldLBString](../vs140/ddx_fieldlbstring.md)   
 [DDX_FieldLBStringExact](../vs140/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBStringExact](../vs140/ddx_fieldcbstringexact.md)