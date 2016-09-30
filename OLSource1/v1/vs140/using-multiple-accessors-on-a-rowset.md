---
title: "Using Multiple Accessors on a Rowset"
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
  - "BEGIN_ACCESSOR macro"
  - "BEGIN_ACCESSOR macro, multiple accessors"
  - "rowsets [C++], multiple accessors"
  - "accessors [C++], rowsets"
ms.assetid: 80d4dc5d-4940-4a28-a4ee-d8602f71d2a6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Multiple Accessors on a Rowset
There are three basic scenarios in which you need to use multiple accessors:  
  
-   **Multiple read/write rowsets.** In this scenario, you have a table with a primary key. You want to be able to read all the columns in the row, including the primary key. You also want to be able to write data to all the columns except the primary key (because you cannot write to the primary key column). In this case, you set up two accessors:  
  
    -   Accessor 0 contains all columns.  
  
    -   Accessor 1 contains all columns except the primary key.  
  
-   **Performance.** In this scenario, one or more columns contain a large amount of data, for example, graphics, sound, or video files. Every time you move to a row, you probably do not want to retrieve the column with the large data file, because doing so would slow down your application's performance.  
  
     You can set up separate accessors in which the first accessor contains all columns except the one with large data, and it retrieves data from these columns automatically; this is the auto accessor. The second accessor retrieves only the column containing large data, but it does not retrieve data from this column automatically. You can have other methods update or fetch the large data on demand.  
  
    -   Accessor 0 is an automatic accessor; it retrieves all the columns except the one with large data.  
  
    -   Accessor 1 is not an automatic accessor; it retrieves the column with large data.  
  
     Use the auto argument to specify whether the accessor is an auto accessor.  
  
-   **Multiple ISequentialStream columns.** In this scenario, you have more than one column containing <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data. However, each accessor is limited to one <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data stream. To solve this problem, set up several accessors, each containing one <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer.  
  
 You normally create accessors using the [BEGIN_ACCESSOR](../vs140/begin_accessor.md) and [END_ACCESSOR](../vs140/end_accessor.md) macros. You can also use the [db_accessor](../vs140/db_accessor.md) attribute. (Accessors are described further in [User Records](../vs140/user-records.md).) The macros or the attribute specify whether an accessor is an automatic or a non-automatic accessor:  
  
-   In an automatic accessor, move methods such as **MoveFirst**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> retrieve data for all specified columns automatically. Accessor 0 should be the automatic accessor.  
  
-   In a non-automatic accessor, the retrieval does not occur until you explicitly call a method such as **Update**, **Insert**, **Fetch**, or **Delete**. In the scenarios described above, you might not want to retrieve all the columns on every move. You can place one or more columns in a separate accessor and make that a non-automatic accessor, as shown below.  
  
 The following example uses multiple accessors to read and write to the jobs table of the SQL Server pubs database using multiple accessors. This is the most common use of multiple accessors; see the "multiple read/write rowsets" scenario above.  
  
 The user record class is as follows. It sets up two accessors: accessor 0 contains only the primary key column (ID) and accessor 1 contains other columns.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The main code is as follows. Calling <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> automatically retrieves data from the primary key column ID using accessor 0. Note how the **Insert** method near the end uses accessor 1 to avoid writing to the primary key column.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Using Accessors](../vs140/using-accessors.md)   
 [User Records](../vs140/user-records.md)