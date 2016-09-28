---
title: "CFileDialog::SetControlItemText"
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
  - "afxdlgs/CFileDialog::SetControlItemText"
  - "SetControlItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetControlItemText"
ms.assetid: 3ec14d4f-d4aa-471c-9de8-b0c1b2283150
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::SetControlItemText
Sets the text of a control item. For example, the text that accompanies a radio button or an item in a menu.  
  
## Syntax  
  
```  
HRESULT SetControlItemText(  
   DWORD dwIDCtl,  
   DWORD dwIDItem,  
   const CString& strLabel  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the container control.  
  
 `dwIDItem`  
 The ID of the item.  
  
 `strLabel`  
 Item's text.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)