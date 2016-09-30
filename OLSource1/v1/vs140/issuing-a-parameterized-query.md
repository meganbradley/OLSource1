---
title: "Issuing a Parameterized Query"
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
  - "parameter queries, running using CCommand class"
ms.assetid: aedb0fce-52a4-4c97-a5c9-b2114be6c3b0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Issuing a Parameterized Query
The following example issues a simple parameterized query that retrieves records with an age field (that is greater than 30) from a table in a Microsoft Access database. To support the parameter, the user record must have an additional map. The following code, in an ATL project, uses the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class instead of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class used in the previous example, [Traversing a Simple Rowset](../vs140/traversing-a-simple-rowset.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The user record, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, looks like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Working with OLE DB Consumer Templates](../vs140/working-with-ole-db-consumer-templates.md)