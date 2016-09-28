---
title: "DDX_LBStringExact"
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
  - "DDX_LBStringExact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_LBStringExact function"
ms.assetid: 1d7ba37d-f80c-4e72-ab33-473523e25d84
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_LBStringExact
The `DDX_CBStringExact` function manages the transfer of `CString` data between the edit control of a list box control in a dialog box, form view, or control view object and a `CString` data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_LBStringExact(  
   CDataExchange* pDX,  
   int nIDC,  
   CString& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The resource ID of the list box control associated with the control property.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
## Remarks  
 When `DDX_LBStringExact` is called to transfer data to a list box control, the first item in the control that matches *value* is selected. (To match just a prefix rather than the entire item, use [DDX_LBString](../vs140/ddx_lbstring.md).) If there are no matches, no items are selected. The matching is case-insensitive.  
  
 When `DDX_CBStringExact` is called to transfer data from a list box control, *value* is set to the current list box selection. If no item is selected, *value* is set to a string of zero length.  
  
> [!NOTE]
>  If the list box is a drop-down list box, the value exchanged is limited to 255 characters.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_LBString](../vs140/ddp_lbstring.md)