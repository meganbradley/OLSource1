---
title: "COleStreamFile::Detach"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleStreamFile::Detach
  - COleStreamFile.Detach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Detach method
  - COleStreamFile class, attributes and operations
ms.assetid: 0f13e536-ae87-4063-9ba2-a15353e4bab6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleStreamFile::Detach
Disassociates the stream from the object without closing the stream.  
  
## Syntax  
  
```  
  
LPSTREAM Detach( );  
```  
  
## Return Value  
 A pointer to the stream (`IStream`) that was associated with the object.  
  
## Remarks  
 The stream must be closed in some other fashion before the program terminates.  
  
 For more information, see [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleStreamFile Class](../vs140/colestreamfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleStreamFile::Attach](../vs140/colestreamfile--attach.md)