---
title: "CWinAppEx::ReloadWindowPlacement"
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
  - "ReloadWindowPlacement"
  - "CWinAppEx.ReloadWindowPlacement"
  - "CWinAppEx::ReloadWindowPlacement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReloadWindowPlacement method"
ms.assetid: 47199d83-d69b-46fc-a6ab-1ed2420d987b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::ReloadWindowPlacement
Reloads the size and location of a window from the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a frame window.  
  
## Return Value  
 Nonzero if the method was successful; 0 if the load failed or there is no data to load.  
  
## Remarks  
 Use the function [CWinAppEx::StoreWindowPlacement](../vs140/cwinappex--storewindowplacement.md) to write the size and location of a window to the registry.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::StoreWindowPlacement](../vs140/cwinappex--storewindowplacement.md)