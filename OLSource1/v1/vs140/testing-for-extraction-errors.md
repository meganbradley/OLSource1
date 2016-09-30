---
title: "Testing for Extraction Errors"
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
helpviewer_keywords: 
  - "extraction errors"
ms.assetid: 6a681028-adba-4557-8f7b-f137932905f8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Testing for Extraction Errors
Output error processing functions, discussed in [Error Processing Functions](../vs140/output-file-stream-member-functions.md), apply to input streams. Testing for errors during extraction is important. Consider this statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a signed integer, a value greater than 32,767 (the maximum allowed value, or MAX_INT) sets the stream's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> bit, and the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object becomes unusable. All subsequent extractions result in an immediate return with no value stored.  
  
## See Also  
 [Input Streams](../vs140/input-streams.md)