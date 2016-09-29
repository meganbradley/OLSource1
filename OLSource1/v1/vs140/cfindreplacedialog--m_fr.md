---
title: "CFindReplaceDialog::m_fr"
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
  - "CFindReplaceDialog::m_fr"
  - "m_fr"
  - "CFindReplaceDialog.m_fr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_fr"
  - "CFindReplaceDialog class, data members"
ms.assetid: a1ca224f-3340-410b-b720-38dea0cbba8a
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFindReplaceDialog::m_fr
Used to customize a `CFindReplaceDialog` object.  
  
## Syntax  
  
```  
  
FINDREPLACE m_fr;  
  
```  
  
## Remarks  
 `m_fr` is a structure of type [FINDREPLACE](http://msdn.microsoft.com/library/windows/desktop/ms646835). Its members store the characteristics of the dialog-box object. After constructing a `CFindReplaceDialog` object, you can use `m_fr` to modify various values in the dialog box.  
  
 For more information on this structure, see the **FINDREPLACE** structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CFindReplaceDialog::CFindReplaceDialog](../vs140/cfindreplacedialog--cfindreplacedialog.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFindReplaceDialog Class](../vs140/cfindreplacedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)