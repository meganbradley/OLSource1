---
title: "Dynamically Binding Columns in Your Provider"
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
  - "columns [C++], dynamic column binding"
  - "dynamic column binding"
  - "providers [C++], dynamic column binding"
ms.assetid: 45e811e3-f5a7-4627-98cc-bf817c4e556e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dynamically Binding Columns in Your Provider
Make sure you really need dynamic column binding. You might need it because:  
  
-   Your rowset columns are not defined at compile time.  
  
-   You support an element such as bookmarks that adds columns.  
  
### To implement dynamic column binding  
  
1.  Remove any **PROVIDER_COLUMN_MAP**s from your code.  
  
2.  In the user record (your structure), add the following declaration:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Implement the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function. This function lays out how the information is stored. You might need to get properties or other information for this function. You might want to create a macro, similar to the [COLUMN_ENTRY](../vs140/column_entry.md) macro, to add your own information.  
  
     The following example shows a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Working with OLE DB Provider Templates](../vs140/working-with-ole-db-provider-templates.md)