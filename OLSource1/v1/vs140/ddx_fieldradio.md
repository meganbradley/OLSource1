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
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function associates a zero-based <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member variable of a record view's recordset with the currently selected radio button in a group of radio buttons in the record view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The ID of the first in a group (with style **WS_GROUP**) of adjacent radio button controls in the [CRecordView](../vs140/crecordview-class.md) or [CDaoRecordView](../vs140/cdaorecordview-class.md) object.  
  
 *value*  
 A reference to a field data member in the associated <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the [CRecordset](../vs140/crecordset-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md) object with which data is exchanged.  
  
## Remarks  
 When transferring from the recordset field to the view, this function turns on the *nth* radio button (zero-based) and turns off the other buttons. In the reverse direction, this function sets the recordset field to the ordinal number of the radio button that is currently on (checked). On a transfer from the recordset to the control, if the recordset field is Null, no button is selected. On a transfer from control to recordset, if no control is selected, the recordset field is set to Null if the field permits that.  
  
 Use the first version if you are working with the ODBC-based classes. Use the second version if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../vs140/crecordview-class.md) and [CDaoRecordView](../vs140/cdaorecordview-class.md) fields, see the article [Record Views](../vs140/record-views---mfc-data-access-.md).  
  
## Example  
 See [DDX_FieldText](../vs140/ddx_fieldtext.md) for a general DDX_Field example. Calls to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> would be similar.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_FieldText](../vs140/ddx_fieldtext.md)   
 [DDX_FieldLBString](../vs140/ddx_fieldlbstring.md)   
 [DDX_FieldLBStringExact](../vs140/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBString](../vs140/ddx_fieldcbstring.md)   
 [DDX_FieldCBStringExact](../vs140/ddx_fieldcbstringexact.md)   
 [DDX_FieldCBIndex](../vs140/ddx_fieldcbindex.md)   
 [DDX_FieldLBIndex](../vs140/ddx_fieldlbindex.md)   
 [DDX_FieldScroll](../vs140/ddx_fieldscroll.md)