---
title: "A Sample Generic-Text Program"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_TCHAR type"
  - "mappings, TCHAR.H data types"
  - "generic-text example [CRT]"
  - "TCHAR type"
  - "TCHAR.H data types, mapping"
ms.assetid: a03de0db-8118-4bd9-a03f-640e8dfc5ed3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A Sample Generic-Text Program
**Microsoft Specific**  
  
 The following program, GENTEXT.C, provides a more detailed illustration of the use of generic-text mappings defined in TCHAR.H:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> has been defined, GENTEXT.C maps to the following MBCS program:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has been defined, GENTEXT.C maps to the following Unicode version of the program. For more information about using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in Unicode programs as a replacement for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, see [Using wmain](../vs140/using-wmain.md) in *C Language Reference*.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If neither <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has been defined, GENTEXT.C maps to single-byte ASCII code, as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [Generic-Text Mappings](../vs140/generic-text-mappings.md)   
 [Data Type Mappings](../vs140/data-type-mappings.md)   
 [Constant and Global Variable Mappings](../vs140/constant-and-global-variable-mappings.md)   
 [Routine Mappings](../vs140/routine-mappings.md)   
 [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md)