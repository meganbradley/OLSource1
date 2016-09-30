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
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> copies the current selection of a list box control in a record view to a [CString](../vs140/cstringt-class.md) field data member of a recordset associated with the record view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The ID of a control in the [CRecordView](../vs140/crecordview-class.md) or [CDaoRecordView](../vs140/cdaorecordview-class.md) object.  
  
 *value*  
 A reference to a field data member in the associated <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the [CRecordset](../vs140/crecordset-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md) object with which data is exchanged.  
  
## Remarks  
 In the reverse direction, this function sets the current selection in the list box to the first row that begins with the characters in the string specified by *value*. On a transfer from the recordset to the control, if the recordset field is Null, any selection is removed from the list box. On a transfer from control to recordset, if the control is empty, the recordset field is set to Null.  
  
 Use the first version if you are working with the ODBC-based classes. Use the second version if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../vs140/crecordview-class.md) and [CDaoRecordView](../vs140/cdaorecordview-class.md) fields, see the article [Record Views](../vs140/record-views---mfc-data-access-.md).  
  
## Example  
 See [DDX_FieldText](../vs140/ddx_fieldtext.md) for a general DDX_Field example. Calls to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> would be similar.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_FieldText](../vs140/ddx_fieldtext.md)   
 [DDX_FieldRadio](../vs140/ddx_fieldradio.md)   
 [DDX_FieldLBStringExact](../vs140/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBString](../vs140/ddx_fieldcbstring.md)   
 [DDX_FieldCBStringExact](../vs140/ddx_fieldcbstringexact.md)   
 [DDX_FieldCBIndex](../vs140/ddx_fieldcbindex.md)   
 [DDX_FieldLBIndex](../vs140/ddx_fieldlbindex.md)   
 [DDX_FieldScroll](../vs140/ddx_fieldscroll.md)