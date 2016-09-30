---
title: "User Record"
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
  - "records, user"
  - "OLE DB providers, user record"
  - "user records"
  - "user records, described"
  - "rowsets, user record"
ms.assetid: 9c0d2864-2738-4f62-a750-1016d9c3523f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User Record
The user record provides the code and data structure that represents the column data for a rowset. A user record can be created at compile time or at run time. When you create a provider using the ATL OLE DB Provider Wizard, the wizard creates a default user record that looks like this (assuming you specified a provider name [short name] of "MyProvider"):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The OLE DB provider templates handle all OLE DB specifics regarding interactions with the client. To acquire the column data needed for a response, the provider calls the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function, which you must place in the user record. You can explicitly override <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the user record, for example, by declaring it in the .h file as shown here:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This is equivalent to:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You must also implement <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the user record's .cpp file.  
  
 The PROVIDER_COLUMN_MAP macros aid in creating a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function:  
  
-   BEGIN_PROVIDER_COLUMN_MAP defines the function prototype and a static array of **ATLCOLUMNINFO** structures.  
  
-   PROVIDER_COLUMN_ENTRY defines and initializes a single **ATLCOLUMNINFO**.  
  
-   END_PROVIDER_COLUMN_MAP closes the array and the function. It also places the array element count into the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.  
  
 When a user record is created at run time, **GetColumnInfo** uses the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter to receive a pointer to a rowset or command instance. Commands and rowsets must support the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface, so column information can be obtained from this pointer.  
  
 **CommandClass** and **RowsetClass** are the command and rowset that use the user record.  
  
 For a more detailed example of how to override <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in a user record, see [Dynamically Determining Columns Returned to the Consumer](../vs140/dynamically-determining-columns-returned-to-the-consumer.md).  
  
## See Also  
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)