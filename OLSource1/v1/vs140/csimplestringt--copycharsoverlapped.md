---
title: "CSimpleStringT::CopyCharsOverlapped"
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
  - "CSimpleStringT.CopyCharsOverlapped"
  - "ATL::CSimpleStringT::CopyCharsOverlapped"
  - "CSimpleStringT::CopyCharsOverlapped"
  - "ATL.CSimpleStringT.CopyCharsOverlapped"
  - "ATL::CSimpleStringT<BaseType>::CopyCharsOverlapped"
  - "CopyCharsOverlapped"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyCharsOverlapped method"
ms.assetid: 1b76e655-2500-4edf-ab33-057de1d362c6
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::CopyCharsOverlapped
Copies a character or characters to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a character string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a string containing the characters to be copied.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> characters to be copied.  
  
## Remarks  
 Call this method to copy characters from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> string. Unlike <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> provides a safe method for copying from character buffers that might be overlapped.  
  
## Example  
 See the example for [CSimpleStringT::CopyChars](../vs140/csimplestringt--copychars.md), or the source code for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (located in atlsimpstr.h).  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)