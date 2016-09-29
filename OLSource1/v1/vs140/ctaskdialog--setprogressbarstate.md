---
title: "CTaskDialog::SetProgressBarState"
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
  - "CTaskDialog::SetProgressBarState"
  - "CTaskDialog.SetProgressBarState"
  - "SetProgressBarState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetProgressBarState method"
ms.assetid: 5442e5d6-2c44-4992-a16b-37eb0ee470fa
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetProgressBarState
Sets the state of the progress bar and displays it on the `CTaskDialog`.  
  
## Syntax  
  
```  
void SetProgressBarState(  
   int nState = PBST_NORMAL  
);  
```  
  
#### Parameters  
 [in] `nState`  
 The state of the progress bar. See the Remarks section for the possible values.  
  
## Remarks  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if the `CTaskDialog` is already displayed and has a marquee progress bar.  
  
 The following table lists the possible values for `nState`. In all these cases, the progress bar will fill with the regular color until it reaches the designated stop position. At that point it will change color based on the state.  
  
 PBST_NORMAL  
 After the progress bar fills, the `CTaskDialog` does not change the color of the bar. By default, the regular color is green.  
  
 PBST_ERROR  
 After the progress bar fills, the `CTaskDialog` changes the color of the bar to the error color. By default, this is red.  
  
 PBST_PAUSED  
 After the progress bar fills, the `CTaskDialog` changes the color of the bar to the paused color. By default, this is yellow.  
  
 You can set where the progress bar stops with [CTaskDialog::SetProgressBarPosition](../vs140/ctaskdialog--setprogressbarposition.md).  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#4](../vs140/codesnippet/CPP/ctaskdialog--setprogressbarstate_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetProgressBarMarquee](../vs140/ctaskdialog--setprogressbarmarquee.md)   
 [CTaskDialog::SetProgressBarRange](../vs140/ctaskdialog--setprogressbarrange.md)   
 [CTaskDialog::SetProgressBarPosition](../vs140/ctaskdialog--setprogressbarposition.md)