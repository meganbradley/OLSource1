---
title: "DDX_FieldScroll"
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
  - "AFXDAO/DDX_FieldScroll"
  - "AFXDB/DDX_FieldScroll"
  - "DDX_FieldScroll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX (dialog data exchange), setting position of scroll-bar control"
  - "recordsets, setting scroll-bar control from"
  - "DDX_FieldScroll function"
  - "scroll bars, setting position from recordsets"
ms.assetid: 929184e9-d8ac-434d-bc2e-73dbfca2f085
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_FieldScroll
The `DDX_FieldScroll` function synchronizes the scroll position of a scroll bar control in a record view and an `int` field data member of a recordset associated with the record view (or with whatever integer variable you choose to map it to).  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_FieldScroll(  
   CDataExchange* pDX,  
   int nIDC,  
   int& value,  
   CRecordset* pRecordset   
);  
void AFXAPI DDX_FieldScroll(  
   CDataExchange* pDX,  
   int nIDC,  
   int& value,  
   CDaoRecordset* pRecordset   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 *nIDC\**  
 The ID of the first in a group (with style **WS_GROUP**) of adjacent radio button controls in the [CRecordView](../vs140/crecordview-class.md) or [CDaoRecordView](../vs140/cdaorecordview-class.md) object.  
  
 *value*  
 A reference to a field data member in the associated `CRecordset` or `CDaoRecordset` object.  
  
 `pRecordset`  
 A pointer to the [CRecordset](../vs140/crecordset-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md) object with which data is exchanged.  
  
## Remarks  
 When moving data from the recordset to the control, this function sets the scroll position of the scroll bar control to the value specified in *value*. On a transfer from the recordset to the control, if the recordset field is Null, the scroll bar control is set to 0. On a transfer from control to recordset, if the control is empty, the value of the recordset field is 0.  
  
 Use the first version if you are working with the ODBC-based classes. Use the second version if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../vs140/crecordview-class.md) and [CDaoRecordView](../vs140/cdaorecordview-class.md) fields, see the article [Record Views](../vs140/record-views---mfc-data-access-.md).  
  
## Example  
 See [DDX_FieldText](../vs140/ddx_fieldtext.md) for a general DDX_Field example. Calls to `DDX_FieldScroll` would be similar.  
  
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
 [DDX_Scroll](../vs140/ddx_scroll.md)