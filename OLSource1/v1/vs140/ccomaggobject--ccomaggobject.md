---
title: "CComAggObject::CComAggObject"
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
  - "CComAggObject::CComAggObject"
  - "ATL.CComAggObject.CComAggObject"
  - "ATL::CComAggObject::CComAggObject"
  - "ATL::CComAggObject<contained>::CComAggObject"
  - "CComAggObject.CComAggObject"
  - "CComAddObject"
  - "CComAggObject<contained>::CComAggObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComAggObject constructor"
  - "CComAggObject class, constructor"
ms.assetid: 01c3288f-62ba-428b-9666-39c9c6c60fc1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAggObject::CComAggObject
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The outer unknown.  
  
## Remarks  
 Initializes the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member, [m_contained](../vs140/ccomaggobject--m_contained.md), and increments the module lock count.  
  
 The destructor decrements the module lock count.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComAggObject::FinalConstruct](../vs140/ccomaggobject--finalconstruct.md)   
 [CComAggObject::FinalRelease](../vs140/ccomaggobject--finalrelease.md)