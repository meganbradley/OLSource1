---
title: "CEnumerator::GetMoniker"
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
  - "GetMoniker"
  - "CEnumerator.GetMoniker"
  - "CEnumerator::GetMoniker"
  - "ATL.CEnumerator.GetMoniker"
  - "ATL::CEnumerator::GetMoniker"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMoniker method"
ms.assetid: 69a5cf2d-4a94-41dc-812d-bc1661d516d2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEnumerator::GetMoniker
Parses the display name to extract the component of the string that can be converted into a moniker.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *ppMoniker*  
 [out] The moniker parsed from the display name ([CEnumeratorAccessor::m_szParseName](../vs140/cenumeratoraccessor--m_szparsename.md)) of the current row.  
  
 *lpszDisplayName*  
 [in] The display name to parse.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CEnumerator Class](../vs140/cenumerator-class.md)