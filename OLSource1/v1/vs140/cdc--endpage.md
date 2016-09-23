---
title: "CDC::EndPage"
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
  - CDC.EndPage
  - EndPage
  - CDC::EndPage
dev_langs: 
  - C++
helpviewer_keywords: 
  - EndPage method
  - CDC class, printer escape functions
ms.assetid: bf4a85bd-08e9-444f-970b-ded418cdc283
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::EndPage
Informs the device that the application has finished writing to a page.  
  
## Syntax  
  
```  
  
int EndPage( );  
```  
  
## Return Value  
 Greater than or equal to 0 if the function is successful, or a negative value if an error occurred.  
  
## Remarks  
 This member function is typically used to direct the device driver to advance to a new page.  
  
 This member function replaces the **NEWFRAME** printer escape. Unlike **NEWFRAME**, this function is always called after printing a page.  
  
## Example  
 See the example for [CDC::StartDoc](../vs140/cdc--startdoc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::StartPage](../vs140/cdc--startpage.md)   
 [CDC::StartDoc](../vs140/cdc--startdoc.md)   
 [CDC::Escape](../vs140/cdc--escape.md)