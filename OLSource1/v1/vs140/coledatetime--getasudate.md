---
title: "COleDateTime::GetAsUDATE"
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
  - "GetAsUDATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAsUDATE method"
ms.assetid: 4bbf0258-7f84-4b80-bc29-0afcf69022d9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetAsUDATE
Call this method to obtain the time in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object as a **UDATE** data structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a **UDATE** structure to receive the converted date/time value from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Returns **true** if successful; **false** if the conversion fails, or if the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is **NULL** or invalid.  
  
## Remarks  
 A **UDATE** structure represents an "unpacked" date.  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)