---
title: "Traversing a Simple Rowset"
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
  - "data access [C++], rowsets"
  - "rowsets [C++], accessing"
  - "simple rowsets"
  - "OLE DB consumers [C++], database attributes"
  - "accessors [C++], rowsets"
ms.assetid: b45acf16-4029-429d-ab8d-b7fba98b9740
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Traversing a Simple Rowset
The following example shows a quick and easy database access that does not involve commands. The following consumer code, in an ATL project, retrieves records from a table called *Artists* in a Microsoft Access database using the Microsoft OLE DB Provider for ODBC. The code creates a [CTable](../vs140/ctable-class.md) table object with an accessor based on the user record class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. It opens a connection, opens a session on the connection, and opens the table on the session.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The user record, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, looks like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Working with OLE DB Consumer Templates](../vs140/working-with-ole-db-consumer-templates.md)