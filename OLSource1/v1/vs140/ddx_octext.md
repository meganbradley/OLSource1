---
title: "DDX_OCText"
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
  - "AFXDISP/DDX_OCText"
  - "DDX_OCText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_OCText function"
ms.assetid: 1ebb0c8b-0800-483f-87ef-9459333a62c8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_OCText
The **DDX_OCText** function manages the transfer of **CString** data between a property of an OLE control in a dialog box, form view, or control view object and a **CString** data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_OCText(  
   CDataExchange* pDX,  
   int nIDC,  
   DISPID dispid,  
   CString& value   
);   
```  
  
#### Parameters  
 `pDX`  
 A pointer to a **CDataExchange** object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
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
 [DDX_OCTextRO](../vs140/ddx_octextro.md)