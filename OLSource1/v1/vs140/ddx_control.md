---
title: "DDX_Control"
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
  - "DDX_Control"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_Control function"
ms.assetid: 8d51aeb2-d8ae-4f09-9945-6f365fa5e70d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_Control
The `DDX_Control` function subclasses the control, specified by `nIDC`, of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_Control(  
   CDataExchange* pDX,  
   int nIDC,  
   CWnd& rControl   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 `nIDC`  
 The resource ID of the control to be subclassed.  
  
 *rControl*  
 A reference to a member variable of the dialog box, form view, or control view object related to the specified control.  
  
## Remarks  
 The `pDX` object is supplied by the framework when the `DoDataExchange` function is called. Therefore, `DDX_Control` should only be called within your override of `DoDataExchange`.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)