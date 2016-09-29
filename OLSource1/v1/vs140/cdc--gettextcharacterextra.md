---
title: "CDC::GetTextCharacterExtra"
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
  - "CDC.GetTextCharacterExtra"
  - "CDC::GetTextCharacterExtra"
  - "GetTextCharacterExtra"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextCharacterExtra method"
  - "CDC class, text functions"
ms.assetid: ce1ef793-a738-4d3b-9ab3-53955885ab6b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetTextCharacterExtra
Retrieves the current setting for the amount of intercharacter spacing.  
  
## Syntax  
  
```  
  
int GetTextCharacterExtra( ) const;  
```  
  
## Return Value  
 The amount of the intercharacter spacing.  
  
## Remarks  
 GDI adds this spacing to each character, including break characters, when it writes a line of text to the device context.  
  
 The default value for the amount of intercharacter spacing is 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetTextCharacterExtra](../vs140/cdc--settextcharacterextra.md)   
 [GetTextCharacterExtra](http://msdn.microsoft.com/library/windows/desktop/dd144933)