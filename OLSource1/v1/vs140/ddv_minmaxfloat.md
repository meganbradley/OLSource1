---
title: "DDV_MinMaxFloat"
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
  - DDV_MinMaxFloat
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDV_MinMaxFloat function
ms.assetid: 920bf5f7-8f86-476e-82cc-65c70394f964
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DDV_MinMaxFloat
Call `DDV_MinMaxFloat` to verify that the value in the control associated with *value* falls between `minVal` and `maxVal`.  
  
## Syntax  
  
```  
  
      void AFXAPI DDV_MinMaxFloat(  
   CDataExchange* pDX,  
   float value,  
   float minVal,  
   float maxVal   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is validated.  
  
 `minVal`  
 Minimum value (of type **float**) allowed.  
  
 `maxVal`  
 Maximum value (of type **float**) allowed.  
  
## Remarks  
 For more information about DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Validation Routines](../vs140/standard-dialog-data-validation-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)