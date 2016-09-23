---
title: "CTaskDialog::SetCommonButtons"
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
  - SetCommonButtons
  - CTaskDialog::SetCommonButtons
  - CTaskDialog.SetCommonButtons
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetCommonButtons method
ms.assetid: 6faac89d-cf27-4580-844d-8be0c533482c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::SetCommonButtons
Adds common buttons to the `CTaskDialog`.  
  
## Syntax  
  
```  
void SetCommonButtons(  
   int nButtonMask,  
   int nDisabledButtonMask = 0,  
   int nElevationButtonMask = 0  
);  
```  
  
#### Parameters  
 [in] `nButtonMask`  
 A mask of the buttons to add to the `CTaskDialog`.  
  
 [in] `nDisabledButtonMask`  
 A mask of the buttons to disable.  
  
 [in] `nElevationButtonMask`  
 A mask of the buttons that require elevation.  
  
## Remarks  
 You cannot call this method after the display window for this instance of the [CTaskDialog Class](../vs140/ctaskdialog-class.md) is created. If you do, this method throws an exception.  
  
 The buttons indicated by `nButtonMask` override any common buttons previously added to the `CTaskDialog`. Only the buttons indicated in `nButtonMask` are available.  
  
 If either `nDisabledButtonMask` or `nElevationButtonMask` contain a button that is not in `nButtonMask`, this method throws an exception by using the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro.  
  
 By default, all common buttons are enabled and do not require elevation.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#6](../vs140/codesnippet/CPP/ctaskdialog--setcommonbuttons_1.cpp)]
  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetCommonButtonOptions](../vs140/ctaskdialog--setcommonbuttonoptions.md)