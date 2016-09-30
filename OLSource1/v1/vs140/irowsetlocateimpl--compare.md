---
title: "IRowsetLocateImpl::Compare"
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
  - "ATL.IRowsetLocateImpl.Compare"
  - "IRowsetLocateImpl::Compare"
  - "IRowsetLocateImpl.Compare"
  - "ATL::IRowsetLocateImpl::Compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Compare method"
ms.assetid: 6f84052c-c68c-480a-982f-03748faa7d5d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetLocateImpl::Compare
Compares two bookmarks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 See [IRowsetLocate::Compare](https://msdn.microsoft.com/en-us/library/ms709539.aspx) in the *OLE DB Programmer's Reference*.  
  
## Remarks  
 Either of the bookmarks can be a standard OLE DB-defined [standard bookmark](https://msdn.microsoft.com/en-us/library/ms712954.aspx) (**DBBMK_FIRST**, **DBBMK_LAST**, or **DBBMK_INVALID**). The value returned in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> indicates the relationship between the two bookmarks:  
  
-   **DBCOMPARE_LT** (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is before <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.)  
  
-   **DBCOMPARE_EQ** (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.)  
  
-   **DBCOMPARE_GT** (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is after <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.)  
  
-   **DBCOMPARE_NE** (The bookmarks are equal and not ordered.)  
  
-   **DBCOMPARE_NOTCOMPARABLE** (The bookmarks cannot be compared.)  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetLocateImpl Class](../vs140/irowsetlocateimpl-class.md)