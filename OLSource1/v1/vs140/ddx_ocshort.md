---
title: "DDX_OCShort"
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
  - "DDX_OCShort"
  - "AFXDISP/DDX_OCShort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_OCShort function"
ms.assetid: 28029c88-2aea-4482-8943-fc77fbad357c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_OCShort
The `DDX_OCShort` function manages the transfer of short data between a property of an OLE control in a dialog box, form view, or control view object and a short data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_OCShort(  
   CDataExchange* pDX,  
   int nIDC,  
   DISPID dispid,  
   short& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The ID of an OLE control in the dialog box, form view, or control view object.  
  
 `dispid`  
 The dispatch ID of a property of the control.  
  
 *value*  
 A reference to a member variable of the dialog box, form view or control view object with which data is exchanged.  
  
## Remarks  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_OCShortRO](../vs140/ddx_ocshortro.md)