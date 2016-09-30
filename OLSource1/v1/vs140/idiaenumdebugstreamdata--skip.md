---
title: "IDiaEnumDebugStreamData::Skip"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumDebugStreamData::Skip method"
ms.assetid: 106ae1d3-a379-4077-babf-2665e697b0c4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumDebugStreamData::Skip
Skips a specified number of records in an enumerated sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 celt  
 [in] The number of records to skip in the enumerated sequence.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if there are no more records to skip.  
  
## See Also  
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)