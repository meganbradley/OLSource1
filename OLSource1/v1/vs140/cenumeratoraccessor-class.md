---
title: "CEnumeratorAccessor Class"
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
  - "ATL::CEnumeratorAccessor"
  - "CEnumeratorAccessor"
  - "ATL.CEnumeratorAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEnumeratorAccessor class"
ms.assetid: 21e8e7ea-3511-4afe-b33f-d520f4ff82bb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEnumeratorAccessor Class
Used by [CEnumerator](../vs140/cenumerator-class.md) to access the data from the enumerator rowset.  
  
## Syntax  
  
```  
class CEnumeratorAccessor  
```  
  
## Members  
  
### Data Members  
  
|||  
|-|-|  
|[m_bIsParent](../vs140/cenumeratoraccessor--m_bisparent.md)|A variable indicating whether the enumerator is a parent enumerator, if the row is an enumerator.|  
|[m_nType](../vs140/cenumeratoraccessor--m_ntype.md)|A variable indicating whether the row describes a data source or an enumerator.|  
|[m_szDescription](../vs140/cenumeratoraccessor--m_szdescription.md)|The description of the data source or enumerator.|  
|[m_szName](../vs140/cenumeratoraccessor--m_szname.md)|The name of the data source or enumerator.|  
|[m_szParseName](../vs140/cenumeratoraccessor--m_szparsename.md)|String to pass to [IParseDisplayName](http://msdn.microsoft.com/library/windows/desktop/ms680604) to obtain a moniker for the data source or enumerator.|  
  
## Remarks  
 This rowset consists of the data sources and enumerators visible from the current enumerator.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)