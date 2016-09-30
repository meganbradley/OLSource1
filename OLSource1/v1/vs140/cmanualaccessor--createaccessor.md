---
title: "CManualAccessor::CreateAccessor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL::CManualAccessor::CreateAccessor"
  - "CreateAccessor"
  - "ATL.CManualAccessor.CreateAccessor"
  - "CManualAccessor.CreateAccessor"
  - "CManualAccessor::CreateAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateAccessor method"
ms.assetid: 594c8d6d-b49a-4818-a9a5-81c8115d4e42
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CManualAccessor::CreateAccessor
Allocates memory for the column bind structures and initializes the column data members.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Number of columns. This number should match the number of calls to the [CManualAccessor::AddBindEntry](../vs140/cmanualaccessor--addbindentry.md) function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A pointer to the buffer where the output columns are stored.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The size of the buffer in bytes.  
  
## Return Value  
 One of the standard <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> values.  
  
## Remarks  
 Call this function before you call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CManualAccessor Class](../vs140/cmanualaccessor-class.md)   
 [DBViewer sample](../vs140/visual-c---samples.md)