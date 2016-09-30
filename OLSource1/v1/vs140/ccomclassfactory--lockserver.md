---
title: "CComClassFactory::LockServer"
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
  - "LockServer"
  - "ATL.CComClassFactory.LockServer"
  - "CComClassFactory.LockServer"
  - "CComClassFactory::LockServer"
  - "ATL::CComClassFactory::LockServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LockServer method"
ms.assetid: b9f38d05-02e3-4e43-bad2-a26d66ad5cf3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory::LockServer
Increments and decrements the module lock count by calling **_Module::Lock** and **_Module::Unlock**, respectively.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] If **TRUE**, the lock count is incremented; otherwise, the lock count is decremented.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value.  
  
## Remarks  
 **_Module** refers to the global instance of [CComModule](../vs140/ccommodule-class.md) or a class derived from it.  
  
 Calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> allows a client to hold onto a class factory so that multiple objects can be created quickly.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactory Class](../vs140/ccomclassfactory-class.md)