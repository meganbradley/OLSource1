---
title: "CDC::DrawEscape"
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
  - "CDC::DrawEscape"
  - "DrawEscape"
  - "CDC.DrawEscape"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawEscape method"
  - "CDC class, printer escape functions"
ms.assetid: 8107c2d4-226f-4a2f-8d63-94ed376608de
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DrawEscape
Accesses drawing capabilities of a video display that are not directly available through the graphics device interface (GDI).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the escape function to be performed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of bytes of data pointed to by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to the input structure required for the specified escape.  
  
## Return Value  
 Specifies the outcome of the function. Greater than zero if successful, except for the **QUERYESCSUPPORT** draw escape, which checks for implementation only; or zero if the escape is not implemented; or less than zero if an error occurred.  
  
## Remarks  
 When an application calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the data identified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is passed directly to the specified display driver.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Escape](../vs140/cdc--escape.md)   
 [DrawEscape](http://msdn.microsoft.com/library/windows/desktop/dd162478)