---
title: "CCmdTarget::EnableTypeLib"
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
  - "CCmdTarget.EnableTypeLib"
  - "EnableTypeLib"
  - "CCmdTarget::EnableTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, attributes"
  - "EnableTypeLib method"
ms.assetid: 32475d00-6f3d-4688-85c3-ba84b3f34dc3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::EnableTypeLib
Enables an object's type library.  
  
## Syntax  
  
```  
  
void EnableTypeLib( );  
```  
  
## Remarks  
 Call this member function in the constructor of your `CCmdTarget`-derived object if it provides type information. For more information, see Knowledge Base article Q185720, "HOWTO: Provide Type Information From an MFC Automation Server." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at [http://support.microsoft.com](http://support.microsoft.com/).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)