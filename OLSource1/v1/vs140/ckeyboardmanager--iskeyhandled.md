---
title: "CKeyboardManager::IsKeyHandled"
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
  - "CKeyboardManager::IsKeyHandled"
  - "IsKeyHandled"
  - "CKeyboardManager.IsKeyHandled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsKeyHandled method"
ms.assetid: 2f7d97ce-0cc1-470d-b259-faf389550461
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager::IsKeyHandled
Determines whether the specified key is handled by the [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The key to check.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Specifies the behavior of the shortcut key. For a list of possible values, see [ACCEL Structure](http://msdn.microsoft.com/library/windows/desktop/ms646340).|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A frame window. This method determines whether a shortcut key is handled in this frame.|  
|[in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A Boolean parameter that indicates whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the default frame window.|  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the shortcut key is handled. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the key is not handled or if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 The input parameters must match the entry in the accelerator table both for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to determine whether a shortcut key is handled in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
## See Also  
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)