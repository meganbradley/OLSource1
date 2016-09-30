---
title: "CKeyboardManager::IsKeyPrintable"
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
  - "CKeyboardManager::IsKeyPrintable"
  - "CKeyboardManager.IsKeyPrintable"
  - "IsKeyPrintable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsKeyPrintable method"
ms.assetid: ff64b148-aa9b-4dac-a42e-7ad1475289d4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager::IsKeyPrintable
Indicates whether a character is printable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The character that this method checks.|  
  
## Return Value  
 Nonzero if the character is printable, zero if it is not.  
  
## Remarks  
 This method fails if a call to [GetKeyboardState](http://msdn.microsoft.com/library/windows/desktop/ms646299) fails.  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
## See Also  
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)