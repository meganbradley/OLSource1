---
title: "DDX_CBStringExact"
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
  - "DDX_CBStringExact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_CBStringExact function"
ms.assetid: 743703d2-ce6b-402b-a0a8-d2f25ecdb36a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_CBStringExact
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function manages the transfer of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data between the edit control of a combo box control in a dialog box, form view, or control view object and a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The resource ID of the combo box control associated with the control property.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
## Remarks  
 When <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called, *value* is set to the current combo box selection. If no item is selected, *value* is set to a string of zero length.  
  
> [!NOTE]
>  If the combo box is a drop-down list box, the value exchanged is limited to 255 characters.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_CBStringExact](../vs140/ddp_cbstringexact.md)