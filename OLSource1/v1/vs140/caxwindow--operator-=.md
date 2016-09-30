---
title: "CAxWindow::operator ="
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
  - "CAxWindow::operator="
  - "CAxWindow.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator=, windows"
  - "operator =, windows"
ms.assetid: 349ced38-b43c-435d-ba70-af114d7b43e1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxWindow::operator =
Assigns an `HWND` to an existing `CAxWindow` object.  
  
## Syntax  
  
```  
  
      CAxWindow<   
      TBase  
       >& operator=(  
   HWND hWnd   
);  
```  
  
#### Parameters  
 `hWnd`  
 A handle to an existing window.  
  
## Return Value  
 Returns a reference to the current `CAxWindow` object.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxWindow Class](../vs140/caxwindow-class.md)