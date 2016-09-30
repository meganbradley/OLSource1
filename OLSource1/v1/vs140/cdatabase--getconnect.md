---
title: "CDatabase::GetConnect"
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
  - "CDatabase::GetConnect"
  - "CDatabase.GetConnect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetConnect method"
  - "CDatabase class, database attributes"
ms.assetid: e90600aa-6758-40f9-ac90-9ac2309fbfcf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::GetConnect
Call this member function to retrieve the connection string used during the call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that connected the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to a data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[CString](../vs140/cstringt-class.md) containing the connection string if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> has been called; otherwise, an empty string.  
  
## Remarks  
 See [CDatabase::Open](../vs140/cdatabase--open.md) for a description of how the connection string is created.  
  
## Requirements  
 Header: afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::OpenEx](../vs140/cdatabase--openex.md)   
 [CDatabase::Open](../vs140/cdatabase--open.md)