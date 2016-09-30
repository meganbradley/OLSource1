---
title: "DDX_Slider"
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
  - "DDX_Slider"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "slider controls, data exchange with"
  - "DDX_Slider function"
  - "DDX (dialog data exchange), slider controls"
  - "controls [MFC], slider"
  - "exchanging data with slider controls"
ms.assetid: d329e756-d1a0-408b-9869-f0b3592d97cb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_Slider
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function manages the transfer of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data between a slider control in a dialog box or form view and an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data member of the dialog box or form view object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The resource ID of the slider control.  
  
 *value*  
 A reference to the value to be exchanged. This parameter holds or sets the slider control's current position.  
  
## Remarks  
 When <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called, *value* is set to the current position of the control's thumb, or the value receives the position, depending on the direction of the exchange.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For information about slider controls, see [Using CSliderCtrl](../vs140/using-csliderctrl.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_FieldSlider](../vs140/ddx_fieldslider.md)   
 [DDV_MinMaxSlider](../vs140/ddv_minmaxslider.md)