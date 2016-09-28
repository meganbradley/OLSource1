---
title: "CDumpContext::HexDump"
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
  - "CDumpContext.HexDump"
  - "CDumpContext::HexDump"
  - "HexDump"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDumpContext class, basic input/output"
  - "HexDump method"
ms.assetid: df7500c0-c6bd-4d93-9853-d563221dad8c
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDumpContext::HexDump
Dumps an array of bytes formatted as hexadecimal numbers.  
  
## Syntax  
  
```  
  
      void HexDump(  
   LPCTSTR lpszLine,  
   BYTE* pby,  
   int nBytes,  
   int nWidth   
);  
```  
  
#### Parameters  
 *lpszLine*  
 A string to output at the start of a new line.  
  
 *pby*  
 A pointer to a buffer containing the bytes to dump.  
  
 `nBytes`  
 The number of bytes to dump.  
  
 `nWidth`  
 Maximum number of bytes dumped per line (not the width of the output line).  
  
## Remarks  
 To dump a single, specific item type as a hexadecimal number, call [CDumpContext::DumpAsHex](../vs140/cdumpcontext--dumpashex.md).  
  
## Example  
 [!code[NVC_MFC_Utilities#15](../vs140/codesnippet/CPP/cdumpcontext--hexdump_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CDumpContext Class](../vs140/cdumpcontext-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)