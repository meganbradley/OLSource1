---
title: "DDX_CBString"
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
  - "DDX_CBString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_CBString function"
ms.assetid: c18bbd7b-5211-44dd-b302-fac3d1241741
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_CBString
The `DDX_CBString` function manages the transfer of `CString` data between the edit control of a combo box control in a dialog box, form view, or control view object and a `CString` data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_CBString(  
   CDataExchange* pDX,  
   int nIDC,  
   CString& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The resource ID of the combo box control associated with the control property.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
## Remarks  
 When `DDX_CBString` is called, *value* is set to the current combo box selection. If no item is selected, *value* is set to a string of zero length.  
  
> [!NOTE]
>  If the combo box is a drop-down list box, the value exchanged is limited to 255 characters.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_CBString](../vs140/ddp_cbstring.md)