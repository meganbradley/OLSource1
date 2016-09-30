---
title: "DDX_FieldText"
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
  - "DDX_FieldText"
  - "AFXDB/DDX_FieldText"
  - "AFXDAO/DDX_FieldText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_FieldText function"
  - "ODBC, exchanging data with edit controls"
  - "edit controls, exchanging database data with"
  - "DDX (dialog data exchange), function macros"
  - "DAO (Data Access Objects), exchanging data with controls"
  - "DDX (dialog data exchange), DDX_Field functions"
ms.assetid: 03c5a8ec-1223-4849-b27b-d4e66a50d69d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_FieldText
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function manages the transfer of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, **short**, **long**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, [CString](../vs140/cstringt-class.md), **float**, **double**, **BOOL**, or **BYTE** data between an edit box control and the field data members of a recordset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The ID of a control in the [CRecordView](../vs140/crecordview-class.md) or [CDaoRecordView](../vs140/cdaorecordview-class.md) object.  
  
 *value*  
 A reference to a field data member in the associated <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. The data type of value depends on which of the overloaded versions of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> you use.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to the [CRecordset](../vs140/crecordset-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md) object with which data is exchanged. This pointer enables <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to detect and set Null values.  
  
## Remarks  
 For [CDaoRecordset](../vs140/cdaorecordset-class.md) objects, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> also manages transferring [COleDateTime](../vs140/coledatetime-class.md), and [COleCurrency](../vs140/colecurrency-class.md) values. An empty edit box control indicates a Null value. On a transfer from the recordset to the control, if the recordset field is Null, the edit box is set to empty. On a transfer from control to recordset, if the control is empty, the recordset field is set to Null.  
  
 Use the versions with [CRecordset](../vs140/crecordset-class.md) parameters if you are working with the ODBC-based classes. Use the versions with [CDaoRecordset](../vs140/cdaorecordset-class.md) parameters if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../vs140/crecordview-class.md) and [CDaoRecordView](../vs140/cdaorecordview-class.md) fields, see the article [Record Views](../vs140/record-views---mfc-data-access-.md).  
  
## Example  
 The following <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function for a [CRecordView](../vs140/crecordview-class.md) contains <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function calls for three data types: <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a combo box; the other two controls are edit boxes. For DAO programming, the *m_pSet* parameter is a pointer to a [CRecordset](../vs140/crecordset-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md).  
  
 [!code[NVC_MFCDatabase#43](../vs140/codesnippet/CPP/ddx_fieldtext_1.cpp)]  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_FieldRadio](../vs140/ddx_fieldradio.md)   
 [DDX_FieldLBString](../vs140/ddx_fieldlbstring.md)   
 [DDX_FieldLBStringExact](../vs140/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBString](../vs140/ddx_fieldcbstring.md)   
 [DDX_FieldCBStringExact](../vs140/ddx_fieldcbstringexact.md)   
 [DDX_FieldCBIndex](../vs140/ddx_fieldcbindex.md)   
 [DDX_FieldLBIndex](../vs140/ddx_fieldlbindex.md)   
 [DDX_FieldScroll](../vs140/ddx_fieldscroll.md)