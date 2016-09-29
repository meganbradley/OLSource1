---
title: "DDV_MinMaxDateTime"
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
  - "DDV_MinMaxDateTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDV_MinMaxDateTime function"
ms.assetid: ec52b675-5267-4bbd-9d19-71b339681ed3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDV_MinMaxDateTime
Call `DDV_MinMaxDateTime` to verify that the time/date value in the date and time picker control ([CDateTimeCtrl](../VS_csharp/cdatetimectrl-class.md)) associated with *refValue* falls between `refMinRange` and `refMaxRange`.  
  
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
 A pointer to a [CDataExchange](../VS_csharp/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction. You don't need to delete this object.  
  
 *refValue*  
 A reference to a [CTime](../VS_csharp/ctime-class.md) or [COleDateTime](../VS_csharp/coledatetime-class.md) object associated with a member variable of the dialog box, form view, or control view object. This object contains the data to be validated.  
  
 `refMinRange`  
 Minimum date/time value allowed.  
  
 `refMaxRange`  
 Maximum date/time value allowed.  
  
## Remarks  
 For more information about DDV, see [Dialog Data Exchange and Validation](../VS_csharp/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Validation Routines](../VS_csharp/standard-dialog-data-validation-routines.md)   
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DDX_DateTimeCtrl](../VS_csharp/ddx_datetimectrl.md)   
 [DDV_MinMaxMonth](../VS_csharp/ddv_minmaxmonth.md)