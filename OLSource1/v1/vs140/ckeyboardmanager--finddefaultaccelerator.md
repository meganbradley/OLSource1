---
title: "CKeyboardManager::FindDefaultAccelerator"
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
  - "CKeyboardManager::FindDefaultAccelerator"
  - "CKeyboardManager.FindDefaultAccelerator"
  - "FindDefaultAccelerator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindDefaultAccelerator method"
ms.assetid: ee88c556-b174-4794-bbf3-101d29aed707
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager::FindDefaultAccelerator
Retrieves the default shortcut key for the specified command and window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a frame window.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies whether the frame window is the default frame window.  
  
## Return Value  
 Nonzero if the shortcut is found; otherwise 0.  
  
## Remarks  
 This method looks up the command specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and retrieves the default shortcut key. Then the method takes the string associated with this shortcut key and writes the value to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
## See Also  
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)