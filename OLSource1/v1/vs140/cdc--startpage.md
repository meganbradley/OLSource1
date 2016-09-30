---
title: "CDC::StartPage"
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
  - "CDC.StartPage"
  - "StartPage"
  - "CDC::StartPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StartPage method"
  - "CDC class, printer escape functions"
ms.assetid: 0f9a5df5-e225-4955-b016-58633feb7d37
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::StartPage
Call this member function to prepare the printer driver to receive data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Greater than or equal to 0 if the function is successful, or a negative value if an error occurred.  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> supersedes the **NEWFRAME** and **BANDINFO** escapes.  
  
 For an overview of the sequence of printing calls, see the [StartDoc](../vs140/cdc--startdoc.md) member function.  
  
 The system disables the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function between calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [CDC::StartDoc](../vs140/cdc--startdoc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Escape](../vs140/cdc--escape.md)   
 [CDC::EndPage](../vs140/cdc--endpage.md)