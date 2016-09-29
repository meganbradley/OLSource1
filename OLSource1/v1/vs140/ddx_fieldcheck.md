---
title: "DDX_FieldCheck"
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
  - "DDX_FieldCheck"
  - "AFXDB/DDX_FieldCheck"
  - "AFXDAO/DDX_FieldCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_FieldCheck function"
ms.assetid: 8b050006-52df-4fd6-9f47-cceaccaa10c5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_FieldCheck
The `DDX_FieldCheck` function manages the transfer of `int` data between a check box control in a dialog box, form view, or control view object and an `int` data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_FieldCheck(  
   CDataExchange* pDX,  
   int nIDC,  
   int& value,  
   CRecordset* pRecordset   
);  
void AFXAPI DDX_FieldCheck(  
   CDataExchange* pDX,  
   int nIDC,  
   int& value,  
   CDaoRecordset* pRecordset   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The resource ID of the check box control associated with the control property.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
 `pRecordset`  
 A pointer to the [CRecordset](../vs140/crecordset-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md) object with which data is exchanged.  
  
## Remarks  
 When `DDX_FieldCheck` is called, *value* is set to the current state of the check box control, or the control's state is set to *value*, depending on the direction of transfer.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_FieldText](../vs140/ddx_fieldtext.md)   
 [DDX_FieldRadio](../vs140/ddx_fieldradio.md)   
 [DDX_FieldLBString](../vs140/ddx_fieldlbstring.md)   
 [DDX_FieldLBStringExact](../vs140/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBString](../vs140/ddx_fieldcbstring.md)