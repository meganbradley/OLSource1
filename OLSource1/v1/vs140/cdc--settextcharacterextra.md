---
title: "CDC::SetTextCharacterExtra"
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
  - "CDC::SetTextCharacterExtra"
  - "SetTextCharacterExtra"
  - "CDC.SetTextCharacterExtra"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTextCharacterExtra method"
  - "CDC class, text functions"
ms.assetid: 0bc765bf-f160-4001-9de6-a301193ace8d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetTextCharacterExtra
Sets the amount of intercharacter spacing.  
  
## Syntax  
  
```  
  
      int SetTextCharacterExtra(  
   int nCharExtra   
);  
```  
  
#### Parameters  
 `nCharExtra`  
 Specifies the amount of extra space (in logical units) to be added to each character. If the current mapping mode is not `MM_TEXT`, `nCharExtra` is transformed and rounded to the nearest pixel.  
  
## Return Value  
 The amount of the previous intercharacter spacing.  
  
## Remarks  
 GDI adds this spacing to each character, including break characters, when it writes a line of text to the device context. The default value for the amount of intercharacter spacing is 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTextCharacterExtra](../vs140/cdc--gettextcharacterextra.md)   
 [SetTextCharacterExtra](http://msdn.microsoft.com/library/windows/desktop/dd145092)