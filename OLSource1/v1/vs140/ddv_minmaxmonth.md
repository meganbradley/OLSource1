---
title: "DDV_MinMaxMonth"
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
  - "DDV_MinMaxMonth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDV_MinMaxMonth function"
ms.assetid: ae7d50a3-ded3-440d-b4b1-a9869488feed
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDV_MinMaxMonth
Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to verify that the time/date value in the month calendar control ([CMonthCalCtrl](../vs140/cmonthcalctrl-class.md)) associated with *refValue* falls between <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 *refValue*  
 A reference to an object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> associated with a member variable of the dialog box, form view, or control view object. This object contains the data to be validated. MFC passes this reference when <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Minimum date/time value allowed.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
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