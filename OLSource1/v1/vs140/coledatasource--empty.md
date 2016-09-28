---
title: "COleDataSource::Empty"
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
  - "COleDataSource.Empty"
  - "COleDataSource::Empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataSource class, operations"
  - "Empty method"
ms.assetid: d9cad5d4-5aff-4687-b83f-a4b0d41d58b1
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::Empty
Call this function to empty the `COleDataSource` object of data.  
  
## Syntax  
  
```  
  
void Empty( );  
```  
  
## Remarks  
 Both cached and delay render formats are emptied so they can be reused.  
  
 For more information, see [ReleaseStgMedium](http://msdn.microsoft.com/library/windows/desktop/ms693491) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)