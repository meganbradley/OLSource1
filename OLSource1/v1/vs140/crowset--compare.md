---
title: "CRowset::Compare"
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
  - "CRowset<TAccessor>.Compare"
  - "CRowset<TAccessor>::Compare"
  - "ATL.CRowset<TAccessor>.Compare"
  - "ATL::CRowset<TAccessor>::Compare"
  - "CRowset.Compare"
  - "ATL::CRowset::Compare"
  - "ATL.CRowset.Compare"
  - "CRowset::Compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Compare method"
ms.assetid: a8117b40-7abd-4867-b0ba-eb9e9808204e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset::Compare
Compares two bookmarks using [IRowsetLocate::Compare](https://msdn.microsoft.com/en-us/library/ms709539.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Bookmark1*  
 [in] The first bookmark to compare.  
  
 *Bookmark2*  
 [in] The second bookmark to compare.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] A pointer to the result of the comparison.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method requires the optional interface <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which might not be supported on all providers; if this is the case, the method returns **E_NOINTERFACE**. You must also set **DBPROP_IRowsetLocate** to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> before calling **Open** on the table or command containing the rowset.  
  
 For information about using bookmarks in consumers, see [Using Bookmarks](../vs140/using-bookmarks.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)