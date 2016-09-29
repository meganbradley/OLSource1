---
title: "DDX_FieldSlider"
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
  - "DDX_FieldSlider"
  - "AFXDAO/DDX_FieldSlider"
  - "AFXDB/DDX_FieldSlider"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX (dialog data exchange), slider controls"
  - "controls [MFC], slider"
  - "slider controls, exchanging data with"
  - "exchanging data with slider controls"
  - "DDX_FieldSlider function"
ms.assetid: 7890b101-2ca1-4d03-aa3a-825867680652
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_FieldSlider
The `DDX_FieldSlider` function synchronizes the thumb position of a slider control in a record view and an `int` field data member of a recordset associated with the record view (or with whatever integer variable you choose to map it to).  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_FieldSlider(  
   CDataExchange* pDX,  
   int nIDC,  
   int& value,  
   CRecordset* pRecordset   
);  
void AFXAPI DDX_FieldSlider(  
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
 The resource ID of the slider control.  
  
 *value*  
 A reference to the value to be exchanged. This parameter holds or will be used to set the slider control's current thumb position.  
  
 `pRecordset`  
 A pointer to the associated `CRecordset` or `CDaoRecordset` object with which data is exchanged.  
  
## Remarks  
 When moving data from the recordset to the slider, this function sets the position of the slider to the value specified in *value*. On a transfer from the recordset to the control, if the recordset field is Null, the slider control's position is set to 0. On a transfer from the control to the recordset, if the control is empty, the value of the recordset field is 0.  
  
 `DDX_FieldSlider` does not exchange range information with slider controls capable of setting a range rather than simply a position.  
  
 Use the first override of the function if you are working with the ODBC-based classes. Use the second override with the DAO-based classes.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For examples and more information about DDX for `CRecordView` and `CDaoRecordView` fields, see [Record Views](../vs140/record-views---mfc-data-access-.md). For information about slider controls, see [Using CSliderCtrl](../vs140/using-csliderctrl.md).  
  
## Example  
 See [DDX_FieldText](../vs140/ddx_fieldtext.md) for a general DDX_Field example. Calls to `DDX_FieldSlider` would be similar.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_Slider](../vs140/ddx_slider.md)   
 [DDV_MinMaxSlider](../vs140/ddv_minmaxslider.md)   
 [DDX_FieldLBString](../vs140/ddx_fieldlbstring.md)   
 [DDX_FieldLBStringExact](../vs140/ddx_fieldlbstringexact.md)   
 [DDX_FieldCBString](../vs140/ddx_fieldcbstring.md)   
 [DDX_FieldCBStringExact](../vs140/ddx_fieldcbstringexact.md)   
 [DDX_FieldCBIndex](../vs140/ddx_fieldcbindex.md)   
 [DDX_FieldLBIndex](../vs140/ddx_fieldlbindex.md)