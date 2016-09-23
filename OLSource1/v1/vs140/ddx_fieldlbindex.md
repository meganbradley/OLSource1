---
title: "DDX_FieldLBIndex"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - DDX_FieldLBIndex
  - AFXDAO/DDX_FieldLBIndex
  - AFXDB/DDX_FieldLBIndex
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDX_FieldLBIndex function
  - recordsets, transferring data to combo and list boxes
  - DDX (dialog data exchange), from list box index to recordset
  - list boxes, transferring data from indexes
ms.assetid: b424516a-f7c7-45ce-9a74-4e55a181f5a3
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DDX_FieldLBIndex
The `DDX_FieldLBIndex` function synchronizes the index of the selected item in a list box control in a record view and an `int` field data member of a recordset associated with the record view.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_FieldLBIndex(  
   CDataExchange* pDX,  
   int nIDC,  
   int& index,  
   CRecordset* pRecordset   
);  
void AFXAPI DDX_FieldLBIndex(  
   CDataExchange* pDX,  
   int nIDC,  
   int& index,  
   CDaoRecordset* pRecordset   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The ID of a control in the [CRecordView](../vs140/crecordview-class.md) or [CDaoRecordView](../vs140/cdaorecordview-class.md) object.  
  
 *index*  
 A reference to a field data member in the associated `CRecordset` or `CDaoRecordset` object.  
  
 `pRecordset`  
 A pointer to the [CRecordset](../vs140/crecordset-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md) object with which data is exchanged.  
  
## Remarks  
 When moving data from the recordset to the control, this function sets the selection in the control based on the value specified in *index*. On a transfer from the recordset to the control, if the recordset field is Null, MFC sets the value of the index to 0. On a transfer from control to recordset, if the control is empty, the recordset field is set to 0.  
  
 Use the first version if you are working with the ODBC-based classes. Use the second version if you are working with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For examples and more information about DDX for [CRecordView](../vs140/crecordview-class.md) and [CDaoRecordView](../vs140/cdaorecordview-class.md) fields, see the article [Record Views](../vs140/record-views---mfc-data-access-.md).  
  
## Example  
 See [DDX_FieldText](../vs140/ddx_fieldtext.md) for a general DDX_Field example.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_FieldText](../vs140/ddx_fieldtext.md)   
 [DDX_FieldRadio](../vs140/ddx_fieldradio.md)   
 [DDX_FieldLBString](../vs140/ddx_fieldlbstring.md)   
 [DDX_FieldLBStringExact](../vs140/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBStringExact](../vs140/ddx_fieldcbstringexact.md)   
 [DDX_FieldCBIndex](../vs140/ddx_fieldcbindex.md)   
 [DDX_FieldScroll](../vs140/ddx_fieldscroll.md)   
 [DDX_LBIndex](../vs140/ddx_lbindex.md)