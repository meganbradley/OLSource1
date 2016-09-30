---
title: "CDC::GetKerningPairs"
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
  - "CDC.GetKerningPairs"
  - "CDC::GetKerningPairs"
  - "GetKerningPairs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetKerningPairs method"
  - "CDC class, font functions"
ms.assetid: 11262555-8d96-4000-b689-9d8b165eedf3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetKerningPairs
Retrieves the character kerning pairs for the font that is currently selected in the specified device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the number of [KERNINGPAIR](http://msdn.microsoft.com/library/windows/desktop/dd145024) structures pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The function will not copy more kerning pairs than specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to an array of **KERNINGPAIR** structures that receive the kerning pairs when the function returns. This array must contain at least as many structures as specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If this parameter is **NULL**, the function returns the total number of kerning pairs for the font.  
  
## Return Value  
 Specifies the number of kerning pairs retrieved or the total number of kerning pairs in the font, if the function is successful. Zero is returned if the function fails or there are no kerning pairs for the font.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetKerningPairs](http://msdn.microsoft.com/library/windows/desktop/dd144895)   
 [KERNINGPAIR](http://msdn.microsoft.com/library/windows/desktop/dd145024)