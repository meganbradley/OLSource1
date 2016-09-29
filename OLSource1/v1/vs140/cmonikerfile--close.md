---
title: "CMonikerFile::Close"
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
  - "CMonikerFile.Close"
  - "CMonikerFile::Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
ms.assetid: fb81be92-98e0-456a-bd7e-25d968a7718f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonikerFile::Close
Call this function to detach and release the stream and to release the moniker.  
  
## Syntax  
  
```  
  
virtual void Close( );  
```  
  
## Remarks  
 Can be called on unopened or already closed streams.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CMonikerFile Class](../vs140/cmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonikerFile::Open](../vs140/cmonikerfile--open.md)