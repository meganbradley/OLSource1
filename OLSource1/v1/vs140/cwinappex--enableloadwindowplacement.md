---
title: "CWinAppEx::EnableLoadWindowPlacement"
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
  - "EnableLoadWindowPlacement"
  - "CWinAppEx.EnableLoadWindowPlacement"
  - "CWinAppEx::EnableLoadWindowPlacement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableLoadWindowPlacement method"
ms.assetid: 3753b04e-8270-4a64-999b-578f62a2d191
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::EnableLoadWindowPlacement
Specifies whether the application will load the initial size and location of the main frame window from the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the application loads the initial size and location of the main frame window from the registry.  
  
## Remarks  
 By default, the size and location of the main frame is loaded from the registry together with other application settings. This occurs during [CWinAppEx::LoadState](../vs140/cwinappex--loadstate.md). If you do not want to load the initial window placement from the registry, call this method with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)