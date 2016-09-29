---
title: "CEdit::Paste"
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
  - "CEdit.Paste"
  - "CEdit::Paste"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEdit class, general functions"
  - "Paste method"
ms.assetid: 77e4ef92-3535-4025-9d2d-aa46ad41873a
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::Paste
Call this function to insert the data from the Clipboard into the `CEdit` at the insertion point.  
  
## Syntax  
  
```  
  
void Paste( );  
```  
  
## Remarks  
 Data is inserted only if the Clipboard contains data in **CF_TEXT** format.  
  
 For more information, see [WM_PASTE](http://msdn.microsoft.com/library/windows/desktop/ms649028) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#20](../vs140/codesnippet/CPP/cedit--paste_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::Clear](../vs140/cedit--clear.md)   
 [CEdit::Copy](../vs140/cedit--copy.md)   
 [CEdit::Cut](../vs140/cedit--cut.md)