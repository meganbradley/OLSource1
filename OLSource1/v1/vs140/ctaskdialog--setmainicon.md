---
title: "CTaskDialog::SetMainIcon"
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
  - "SetMainIcon"
  - "CTaskDialog::SetMainIcon"
  - "CTaskDialog.SetMainIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMainIcon method"
ms.assetid: c0250952-640f-4cba-8cec-ee329b3c6b9a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetMainIcon
Updates the main icon of the `CTaskDialog`.  
  
## Syntax  
  
```  
void SetMainIcon(  
   HICON hMainIcon  
);  
  
void SetMainIcon(  
   LPCWSTR lpszMainIcon  
);  
```  
  
#### Parameters  
 [in] `hMainIcon`  
 The new icon.  
  
 [in] `lpszMainIcon`  
 The new icon.  
  
## Remarks  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if the `CTaskDialog` is displayed or the input parameter is `NULL`.  
  
 A `CTaskDialog` can only accept an `HICON` or `LPCWSTR` as a main icon. You can configure this by setting the `TDF_USE_HICON_MAIN` option in the constructor or in the [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md) method. By default, the `CTaskDialog` is configured to use `LPCWSTR` as the input type for the main icon. This method generates an exception if you try to set the icon using the inappropriate type.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--setmainicon_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md)