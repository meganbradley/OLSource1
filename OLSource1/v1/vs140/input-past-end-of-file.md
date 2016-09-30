---
title: "Input past end of file"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrID62"
dev_langs: 
  - "VB"
ms.assetid: 65292704-6e7d-4622-9f50-eb655a59b016
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Input past end of file
Either an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement is reading from a file that is empty or one in which all the data is used, or you used the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function with a file opened for binary access.  
  
### To correct this error  
  
1.  Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function immediately before the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement to detect the end of the file.  
  
2.  If the file is opened for binary access, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileSystem.Input*>   
 \<xref:Microsoft.VisualBasic.FileSystem.EOF*>   
 \<xref:Microsoft.VisualBasic.FileSystem.Seek*>   
 \<xref:Microsoft.VisualBasic.FileSystem.Loc*>