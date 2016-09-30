---
title: "CEnumerator::Open"
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
  - "ATL.CEnumerator.Open"
  - "CEnumerator::Open"
  - "ATL::CEnumerator::Open"
  - "CEnumerator.Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open method"
ms.assetid: b22821a0-257a-4543-ad0c-2649d4ac092e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEnumerator::Open
Binds the moniker for the enumerator, if one is specified, then retrieves the rowset for the enumerator by calling [ISourcesRowset::GetSourcesRowset](https://msdn.microsoft.com/en-us/library/ms711200.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to a moniker for an enumerator.  
  
 *pClsid*  
 [in] A pointer to the **CLSID** of an enumerator.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A reference to an enumerator.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CEnumerator Class](../vs140/cenumerator-class.md)