---
title: "CButton::GetIdealSize"
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
  - "CButton.GetIdealSize"
  - "GetIdealSize"
  - "CButton::GetIdealSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIdealSize method"
ms.assetid: 808e4b37-0800-4903-9e80-ff95d780204b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::GetIdealSize
Retrieves the ideal size for the button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *psize*  
 A pointer to the current size of the button.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the **BCM_GETIDEALSIZE** message, as described in the [Buttons](http://msdn.microsoft.com/library/windows/desktop/bb775943) section of the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)