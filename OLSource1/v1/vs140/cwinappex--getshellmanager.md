---
title: "CWinAppEx::GetShellManager"
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
  - "GetShellManager"
  - "CWinAppEx::GetShellManager"
  - "CWinAppEx.GetShellManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetShellManager method"
ms.assetid: 4982591b-2426-47d4-acfc-6f9607b67d67
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetShellManager
Returns a pointer to the global [CShellManager](../vs140/cshellmanager-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the global <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Remarks  
 If the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is not initialized, this function calls [CWinAppEx::InitShellManager](../vs140/cwinappex--initshellmanager.md) before it returns a pointer.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::InitShellManager](../vs140/cwinappex--initshellmanager.md)   
 [CShellManager Class](../vs140/cshellmanager-class.md)