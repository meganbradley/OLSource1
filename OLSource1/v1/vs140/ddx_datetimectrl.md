---
title: "DDX_DateTimeCtrl"
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
  - AFXOLEDB/DDX_DateTimeCtrl
  - DDX_DateTimeCtrl
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDX_DateTimeCtrl function
ms.assetid: 27885693-12b5-48ef-bb9d-be3d56d5747d
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DDX_DateTimeCtrl
The `DDX_DateTimeCtrl` function manages the transfer of date and/or time data between a date and time picker control ([CDateTimeCtrl](../vs140/cdatetimectrl-class.md)) in a dialog box or form view object and either a [CTime](../vs140/ctime-class.md) or a [COleDateTime](../vs140/coledatetime-class.md) data member of the dialog box or form view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_DateTimeCtrl(  
   CDataExchange* pDX,  
   int nIDC,  
   CTime& value   
);  
void AFXAPI DDX_DateTimeCtrl(  
   CDataExchange* pDX,  
   int nIDC,  
   COleDateTime& value   
);  
void AFXAPI DDX_DateTimeCtrl(  
   CDataExchange* pDX,  
   int nIDC,  
   CString& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction. You don't need to delete this object.  
  
 `nIDC`  
 The resource ID of the date and time picker control associated with the member variable.  
  
 *value*  
 In the first two versions, a reference to a `CTime` or `COleDateTime` member variable, dialog box, form view, or control view object with which data is exchanged. In the third version, a reference to a `CString` data member control view object.  
  
## Remarks  
 When `DDX_DateTimeCtrl` is called, *value* is set to the current state of the date and time picker control, or the control is set to *value*, depending on the direction of the exchange.  
  
 In the third version above, `DDX_DateTimeCtrl` manages the transfer of `CString` data between a date time control and a [CString](../vs140/cstringt-class.md) data member of the control view object. The string is formatted using the current locale's rules for formatting dates and times.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxoledb.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [CDateTimeCtrl::SetRange](../vs140/cdatetimectrl--setrange.md)   
 [CDateTimeCtrl::GetRange](../vs140/cdatetimectrl--getrange.md)   
 [DDV_MinMaxDateTime](../vs140/ddv_minmaxdatetime.md)