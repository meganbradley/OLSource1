---
title: "CMultiLock::CMultiLock"
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
  - "CMultiLock.CMultiLock"
  - "CMultiLock::CMultiLock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMultiLock class, constructor"
ms.assetid: 665fa4d9-256b-4b17-9493-e00b73e30d4e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMultiLock::CMultiLock
Constructs a **CMultiLock** object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Array of pointers to the synchronization objects to be waited on. Cannot be **NULL**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number of objects in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Must be greater than 0.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies whether to initially attempt to access any of the supplied objects.  
  
## Remarks  
 This function is called after creating the array of synchronization objects to be waited on. It is usually called from within the thread that must wait for one of the synchronization objects to become available.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CMultiLock Class](../vs140/cmultilock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)