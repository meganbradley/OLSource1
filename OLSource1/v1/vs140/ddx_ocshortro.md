---
title: "DDX_OCShortRO"
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
  - DDX_OCShortRO
  - AFXDISP/DDX_OCShortRO
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDX_OCShortRO function
ms.assetid: a2f61d6e-6f59-4906-9132-00767996772d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DDX_OCShortRO
The `DDX_OCShortRO` function manages the transfer of short data between a read-only property of an OLE control in a dialog box, form view, or control view object and a short data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_OCShortRO(  
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
 [DDX_OCShort](../vs140/ddx_ocshort.md)