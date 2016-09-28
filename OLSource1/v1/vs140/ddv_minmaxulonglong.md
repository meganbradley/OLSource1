---
title: "DDV_MinMaxULongLong"
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
  - "DDV_MinMaxULongLong"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDV_MinMaxULongLong"
ms.assetid: e45ba25b-db08-468e-b564-38d7b104d5a4
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDV_MinMaxULongLong
Call `DDV_MinMaxULongLong` to verify that the value in the control associated with *value* falls between `minVal` and `maxVal`.  
  
## Syntax  
  
```  
  
      void AFXAPI DDV_MinMaxULongLong(  
   CDataExchange* pDX,  
   ULONGLONG value,  
   ULONGLONG minVal,  
   ULONGLONG maxVal   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is validated.  
  
 `minVal`  
 Minimum value (of type **ULONGLONG**) allowed.  
  
 `maxVal`  
 Maximum value (of type **ULONGLONG**) allowed.  
  
## Remarks  
 For more information about DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Validation Routines](../vs140/standard-dialog-data-validation-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)