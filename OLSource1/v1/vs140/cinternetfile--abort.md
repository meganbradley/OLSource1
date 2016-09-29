---
title: "CInternetFile::Abort"
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
  - "CInternetFile.Abort"
  - "CInternetFile::Abort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetFile class, operations"
  - "Abort method"
ms.assetid: c335ee6a-3991-4632-aca4-e09fa47678b8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetFile::Abort
Closes the file associated with this object and makes the file unavailable for reading or writing.  
  
## Syntax  
  
```  
  
virtual void Abort( );  
  
```  
  
## Remarks  
 If you have not closed the file before destroying the object, the destructor closes it for you.  
  
 When handling exceptions, **Abort** differs from [Close](../vs140/cinternetfile--close.md) in two important ways. First, the **Abort** function does not throw an exception on failures because it ignores failures. Second, **Abort** does not **ASSERT** if the file has not been opened or was closed previously.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)