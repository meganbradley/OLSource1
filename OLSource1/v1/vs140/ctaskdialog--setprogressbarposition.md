---
title: "CTaskDialog::SetProgressBarPosition"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CTaskDialog::SetProgressBarPosition"
  - "SetProgressBarPosition"
  - "CTaskDialog.SetProgressBarPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetProgressBarPosition method"
ms.assetid: c6c69029-0331-41fe-b4eb-a29c8b0202ab
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetProgressBarPosition
Adjusts the position of the progress bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position for the progress bar.  
  
## Remarks  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is not in the progress bar range. You can change the progress bar range with [CTaskDialog::SetProgressBarRange](../vs140/ctaskdialog--setprogressbarrange.md).  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#4](../vs140/codesnippet/CPP/ctaskdialog--setprogressbarposition_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetProgressBarMarquee](../vs140/ctaskdialog--setprogressbarmarquee.md)   
 [CTaskDialog::SetProgressBarRange](../vs140/ctaskdialog--setprogressbarrange.md)   
 [CTaskDialog::SetProgressBarState](../vs140/ctaskdialog--setprogressbarstate.md)