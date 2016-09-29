---
title: "CEdit::GetPasswordChar"
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
  - "GetPasswordChar"
  - "CEdit.GetPasswordChar"
  - "CEdit::GetPasswordChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPasswordChar method"
  - "CEdit class, general operations"
ms.assetid: 30e262bb-2855-4657-b1ee-b8ae75409c06
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetPasswordChar
Call this function to retrieve the password character that is displayed in an edit control when the user enters text.  
  
## Syntax  
  
```  
TCHAR GetPasswordChar( ) const;  
```  
  
## Return Value  
 Specifies the character to be displayed instead of the character that the user typed. The return value is `NULL` if no password character exists.  
  
## Remarks  
 If you create the edit control with the **ES_PASSWORD** style, the DLL that supports the control determines the default password character. The manifest or the [InitCommonControlsEx](http://msdn.microsoft.com/library/windows/desktop/bb775697) method determines which DLL supports the edit control. If user32.dll supports the edit control, the default password character is ASTERISK ('*', U+002A). If comctl32.dll version 6 supports the edit control, the default character is BLACK CIRCLE ('●', U+25CF). For more information about which DLL and version supports the common controls, see [Shell and Common Controls Versions](http://msdn.microsoft.com/library/windows/desktop/bb776779).  
  
 This method sends the [EM_GETPASSWORDCHAR](http://msdn.microsoft.com/library/windows/desktop/bb761594) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#14](../vs140/codesnippet/CPP/cedit--getpasswordchar_1.cpp)]  
  
## Requirements  
 **Header** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::SetPasswordChar](../vs140/cedit--setpasswordchar.md)   
 [Shell and Common Controls Versions](http://msdn.microsoft.com/library/windows/desktop/bb776779)   
 [InitCommonControlsEx](http://msdn.microsoft.com/library/windows/desktop/bb775697)