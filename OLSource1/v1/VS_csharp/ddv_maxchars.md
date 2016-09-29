---
title: "DDV_MaxChars"
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
  - "DDV_MaxChars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDV_MaxChars function"
ms.assetid: 566a5ac5-c9d3-49e9-9dff-ce4197d008be
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDV_MaxChars
Call `DDV_MaxChars` to verify that the amount of characters in the control associated with *value* does not exceed *nChars*.  
  
## Syntax  
  
```  
  
      void AFXAPI DDV_MaxChars(  
   CDataExchange* pDX,  
   CString const& value,  
   int nChars   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is validated.  
  
 `nChars`  
 Maximum number of characters allowed.  
  
## Remarks  
 For more information about DDV, see [Dialog Data Exchange and Validation](../VS_csharp/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Validation Routines](../VS_csharp/standard-dialog-data-validation-routines.md)   
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)