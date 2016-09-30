---
title: "CWinAppEx::InitShellManager"
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
  - "CWinAppEx.InitShellManager"
  - "CWinAppEx::InitShellManager"
  - "InitShellManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitShellManager method"
ms.assetid: 74e0ffec-3c8b-4df8-aca7-98f39d72b575
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::InitShellManager
Initializes the [CShellManager](../vs140/cshellmanager-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the method creates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object; 0 if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object already exists.  
  
## Remarks  
 If you call [CWinAppEx::GetShellManager](../vs140/cwinappex--getshellmanager.md), the default implementation of that method calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 If your application already has a shell manager and you call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, your application raises an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore, do not call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if you create a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object directly. If you are not using a custom <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::GetShellManager](../vs140/cwinappex--getshellmanager.md)   
 [CShellManager Class](../vs140/cshellmanager-class.md)