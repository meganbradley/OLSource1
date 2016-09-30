---
title: "CWinApp::EnableTaskbarInteraction"
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
  - "EnableTaskbarInteraction"
  - "afxwin/CWinApp::EnableTaskbarInteraction"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableTaskbarInteraction"
ms.assetid: f15b28c1-247c-4d69-acd8-9bfa96cd604f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::EnableTaskbarInteraction
Enables Taskbar interaction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether interaction with Windows 7 taskbar should be enabled (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>), or disabled (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
## Return Value  
 Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if taskbar interaction can be enabled or disabled.  
  
## Remarks  
 This method must be called before creation of main window, otherwise it asserts and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)