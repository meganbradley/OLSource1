---
title: "DDV_MinMaxInt"
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
  - DDV_MinMaxInt
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDV_MinMaxInt function
ms.assetid: 9ee18582-bebf-4c03-b715-d53fd359d95b
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DDV_MinMaxInt
Call `DDV_MinMaxInt` to verify that the value in the control associated with *value* falls between `minVal` and `maxVal`.  
  
## Syntax  
  
```  
  
      void AFXAPI DDV_MinMaxInt(  
   CDataExchange* pDX,  
   int value,  
   int minVal,  
   int maxVal   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is validated.  
  
 `minVal`  
 Minimum value (of type `int`) allowed.  
  
 `maxVal`  
 Maximum value (of type `int`) allowed.  
  
## Remarks  
 For more information about DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Validation Routines](../vs140/standard-dialog-data-validation-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)