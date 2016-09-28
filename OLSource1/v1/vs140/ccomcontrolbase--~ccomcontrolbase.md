---
title: "CComControlBase::~CComControlBase"
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
  - "CComControlBase::~CComControlBase"
  - "ATL::CComControlBase::~CComControlBase"
  - "~CComControlBase"
  - "ATL.CComControlBase.~CComControlBase"
  - "CComControlBase.~CComControlBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComControlBase class, destructor"
  - "~CComControlBase destructor"
ms.assetid: 8ab1566e-7f3e-4052-80bc-3f0d38afc4f6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::~CComControlBase
The destructor.  
  
## Syntax  
  
```  
  
~CComControlBase( );  
  
```  
  
## Remarks  
 If the control is windowed, `~CComControlBase` destroys it by calling [DestroyWindow](http://msdn.microsoft.com/library/windows/desktop/ms632682).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::CComControlBase](../vs140/ccomcontrolbase--ccomcontrolbase.md)