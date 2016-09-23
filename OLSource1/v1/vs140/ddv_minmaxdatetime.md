---
title: "DDV_MinMaxDateTime"
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
  - DDV_MinMaxDateTime
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDV_MinMaxDateTime function
ms.assetid: ec52b675-5267-4bbd-9d19-71b339681ed3
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DDV_MinMaxDateTime
Call `DDV_MinMaxDateTime` to verify that the time/date value in the date and time picker control ([CDateTimeCtrl](../vs140/cdatetimectrl-class.md)) associated with *refValue* falls between `refMinRange` and `refMaxRange`.  
  
## Syntax  
  
```  
  
      void AFXAPI DDV_MinMaxDateTime(  
   CDataExchange* pDX,  
   CTime& refValue,  
   const CTime* refMinRange,  
   const CTime* refMaxRange   
);  
void AFXAPI DDV_MinMaxDateTime(  
   CDataExchange* pDX,  
   COleDateTime& refValue,  
   const COleDateTime* refMinRange,  
   const COleDateTime* refMaxRange   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction. You don't need to delete this object.  
  
 *refValue*  
 A reference to a [CTime](../vs140/ctime-class.md) or [COleDateTime](../vs140/coledatetime-class.md) object associated with a member variable of the dialog box, form view, or control view object. This object contains the data to be validated.  
  
 `refMinRange`  
 Minimum date/time value allowed.  
  
 `refMaxRange`  
 Maximum date/time value allowed.  
  
## Remarks  
 For more information about DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Validation Routines](../vs140/standard-dialog-data-validation-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_DateTimeCtrl](../vs140/ddx_datetimectrl.md)   
 [DDV_MinMaxMonth](../vs140/ddv_minmaxmonth.md)