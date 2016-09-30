---
title: "CNoAccessor Class"
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
  - "ATL::CNoAccessor"
  - "CNoAccessor"
  - "ATL.CNoAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CNoAccessor class"
ms.assetid: eb669ae5-0a56-49a3-9646-c4ae6239da31
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNoAccessor Class
Can be used as a template argument (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) for template classes, such as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, that require an accessor class argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as a template argument when you do not want the class to support parameters or output columns.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> implements the following stub methods, each of which correspond to other accessor class methods:  
  
-   **BindColumns** - Binds columns to accessors.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> - Binds the created parameters to columns.  
  
-   **Bind** - Creates bindings.  
  
-   **Close** - Closes the accessor.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> - Releases the accessors created by the class.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> - Frees any columns in the current record that need to be freed.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> - Gets column information from the opened rowset.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> - Retrieves the number of accessors created by the class.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> - Returns true if data is automatically retrieved for the accessor during a Move operation.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> - Retrieves the accessor handle of a specified accessor.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> - Retrieves the pointer to the bookmark buffer.  
  
-   **NoBindOnNullRowset** - Prevents data binding on empty rowsets.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)