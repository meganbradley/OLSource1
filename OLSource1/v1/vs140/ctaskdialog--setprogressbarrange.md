---
title: "CTaskDialog::SetProgressBarRange"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SetProgressBarRange
  - CTaskDialog.SetProgressBarRange
  - CTaskDialog::SetProgressBarRange
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetProgressBarRange method
ms.assetid: 9b6ce5e0-03ff-483d-b7de-d50c630ee946
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::SetProgressBarRange
Adjusts the range of the progress bar.  
  
## Syntax  
  
```  
void SetProgressBarRange(  
   int nRangeMin,  
   int nRangeMax  
);  
```  
  
#### Parameters  
 [in] `nRangeMin`  
 The lower bound of the progress bar.  
  
 [in] `nRangeMax`  
 The upper bound of the progress bar.  
  
## Remarks  
 The position of the progress bar is relative to `nRangeMin` and `nRangeMax`. For example, if `nRangeMin` is 50 and `nRangeMax` is 100, a position of 75 is halfway across the progress bar. Use [CTaskDialog::SetProgressBarPosition](../vs140/ctaskdialog--setprogressbarposition.md) to set the position of the progress bar.  
  
 To display the progress bar, the option `TDF_SHOW_PROGRESS_BAR` must be enabled and `TDF_SHOW_MARQUEE_PROGRESS_BAR` must not be enabled. This method automatically sets `TDF_SHOW_PROGRESS_BAR` and clears `TDF_SHOW_MARQUEE_PROGRESS_BAR`. Use [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md) to manually change the options for this instance of the [CTaskDialog Class](../vs140/ctaskdialog-class.md).  
  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if `nRangeMin` is not less than `nRangeMax`. This method also throws an exception if the `CTaskDialog` is already displayed and has a marquee progress bar.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#4](../vs140/codesnippet/CPP/ctaskdialog--setprogressbarrange_1.cpp)]
  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetProgressBarPosition](../vs140/ctaskdialog--setprogressbarposition.md)   
 [CTaskDialog::SetProgressBarState](../vs140/ctaskdialog--setprogressbarstate.md)   
 [CTaskDialog::SetProgressBarMarquee](../vs140/ctaskdialog--setprogressbarmarquee.md)