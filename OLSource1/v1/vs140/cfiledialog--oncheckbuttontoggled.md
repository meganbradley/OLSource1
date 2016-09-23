---
title: "CFileDialog::OnCheckButtonToggled"
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
  - afxdlgs/CFileDialog::OnCheckButtonToggled
  - OnCheckButtonToggled
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnCheckButtonToggled
ms.assetid: c0d6a488-ac42-45f3-982e-538f4e9b4781
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileDialog::OnCheckButtonToggled
Called when the check box is checked or unchecked.  
  
## Syntax  
  
```  
virtual void OnCheckButtonToggled(  
   DWORD dwIDCtl,  
   BOOL bChecked  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the check box.  
  
 `bChecked`  
 Checked or unchecked.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)