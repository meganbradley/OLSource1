---
title: "CTaskDialog::SetProgressBarMarquee"
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
  - "SetProgressMarquee"
  - "CTaskDialog.SetProgressMarquee"
  - "CTaskDialog::SetProgressMarquee"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetProgressBarMarquee method"
ms.assetid: eb15d7b3-d89e-46f3-aa93-a25f1f8944ad
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetProgressBarMarquee
Configures a marquee bar for the `CTaskDialog` and adds it to the dialog box.  
  
## Syntax  
  
```  
void SetProgressBarMarquee(  
   BOOL bEnabled = TRUE,  
   int nMarqueeSpeed = 0  
);  
```  
  
#### Parameters  
 [in] `bEnabled`  
 `TRUE` to enable the marquee bar; `FALSE` to disable the marquee bar and remove it from the `CTaskDialog`.  
  
 [in] `nMarqueeSpeed`  
 An integer that indicates the speed of the marquee bar.  
  
## Remarks  
 The marquee bar appears underneath the main text of the [CTaskDialog Class](../vs140/ctaskdialog-class.md).  
  
 Use `nMarqueeSpeed` to set the speed of the marquee bar; larger values indicate a slower speed. A value of 0 for `nMarqueeSpeed` makes the marquee bar move at the default speed for [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if `nMarqueeSpeed` is less than 0.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#4](../vs140/codesnippet/CPP/ctaskdialog--setprogressbarmarquee_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetProgressBarPosition](../vs140/ctaskdialog--setprogressbarposition.md)   
 [CTaskDialog::SetProgressBarRange](../vs140/ctaskdialog--setprogressbarrange.md)   
 [CTaskDialog::SetProgressBarState](../vs140/ctaskdialog--setprogressbarstate.md)