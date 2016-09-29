---
title: "CComObjectGlobal::CComObjectGlobal"
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
  - "CComObjectGlobal"
  - "CComObjectGlobal.CComObjectGlobal"
  - "CComObjectGlobal::CComObjectGlobal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObjectGlobal class, constructor"
  - "CComObjectGlobal constructor"
ms.assetid: f4c664a2-ce39-435c-90d6-b46d61f25a3a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectGlobal::CComObjectGlobal
The constructor. Calls `FinalConstruct` and then sets [m_hResFinalConstruct](../vs140/ccomobjectglobal--m_hresfinalconstruct.md) to the `HRESULT` returned by `FinalConstruct`.  
  
## Syntax  
  
```  
  
      CComObjectGlobal(   
   void* = NULL   
) );  
```  
  
## Remarks  
 If you have not derived your base class from [CComObjectRoot](../vs140/ccomobjectroot-class.md), you must supply your own `FinalConstruct` method. The destructor calls `FinalRelease`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectGlobal Class](../vs140/ccomobjectglobal-class.md)   
 [CComObjectRootEx::FinalConstruct](../vs140/ccomobjectrootex--finalconstruct.md)