---
title: "CEdit::Copy"
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
  - "CEdit::Copy"
  - "CEdit.Copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEdit class, general operations"
  - "Copy method"
ms.assetid: dccd7d20-6968-4328-b41e-c155120a2282
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::Copy
Call this function to coy the current selection (if any) in the edit control to the Clipboard in **CF_TEXT** format.  
  
## Syntax  
  
```  
  
void Copy( );  
```  
  
## Remarks  
 For more information, see [WM_COPY](http://msdn.microsoft.com/library/windows/desktop/ms649022) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#5](../vs140/codesnippet/CPP/cedit--copy_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::Clear](../vs140/cedit--clear.md)   
 [CEdit::Cut](../vs140/cedit--cut.md)   
 [CEdit::Paste](../vs140/cedit--paste.md)