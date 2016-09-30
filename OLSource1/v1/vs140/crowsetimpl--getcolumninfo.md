---
title: "CRowsetImpl::GetColumnInfo"
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
  - "GetColumnInfo"
  - "CRowsetImpl.GetColumnInfo"
  - "CRowsetImpl::GetColumnInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetColumnInfo method"
ms.assetid: 9ef76525-f996-4c6f-81b9-68eb260350ef
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowsetImpl::GetColumnInfo
Retrieves column information for a particular client request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to the user's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> derived class.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A pointer (output) to the number of columns returned.  
  
## Return Value  
 A pointer to a static **ATLCOLUMNINFO** structure.  
  
## Remarks  
 This method is an advanced override.  
  
 This method is called by several base implementation classes to retrieve column information for a particular client request. Usually, this method would be called by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If you override this method, you must place a version of the method in your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived class. Because the method may be placed in a non-templatized class, you must change <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to the appropriate <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>-derived class.  
  
 The following example demonstrates **GetColumnInfo's** usage. In this example, **CMyRowset** is a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-derived class. In order to override <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for all instances of this class, place the following method in the **CMyRowset** class definition:  
  
 [!code[NVC_OLEDB_Provider#1](../vs140/codesnippet/CPP/crowsetimpl--getcolumninfo_1.h)]  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [CRowsetImpl Class](../vs140/crowsetimpl-class.md)