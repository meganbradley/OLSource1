---
title: "DDX_LBIndex"
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
  - "DDX_LBIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_LBIndex function"
ms.assetid: 767599d8-a710-4821-9835-b031f62b00b5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_LBIndex
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function manages the transfer of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data between a list box control in a dialog box, form view, or control view object and an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The resource ID of the list box control associated with the control property.  
  
 *index*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
## Remarks  
 When <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called, *index* is set to the index of the current list box selection. If no item is selected, *index* is set to -1.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_LBIndex](../vs140/ddp_lbindex.md)