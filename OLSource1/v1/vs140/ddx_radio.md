---
title: "DDX_Radio"
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
  - "DDX_Radio"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_Radio function"
ms.assetid: 87700c20-793c-4ad1-8592-233fe1e008be
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_Radio
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function manages the transfer of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data between a radio control group in a dialog box, form view, or control view object and a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data member of the dialog box, form view, or control view object. The value of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data member is determined according to which radio button within the group is selected.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The resource ID of the first radio control in the group.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
## Remarks  
 When <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is called, *value* is set to the current state of the radio control group. The value is set as a 0-based index of the radio control that is currently checked, or -1 if no radio controls are checked.  
  
 For example, in case that the first radio button in the group is checked (the button with WS_GROUP style) the value of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member is 0 and so on.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_OCText](../vs140/ddx_octext.md)