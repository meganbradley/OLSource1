---
title: "Implementing a Simple Consumer"
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
  - "clients, creating"
  - "OLE DB consumers, implementing"
ms.assetid: 13828167-23a4-4e94-8b6c-878262fda464
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing a Simple Consumer
The following topics show how to edit the files created by the MFC Application Wizard and ATL OLE DB Consumer Wizard to create a simple consumer. This example has the following parts:  
  
-   "Retrieving Data with the Consumer" shows how to implement code in the consumer that reads all the data, row by row, from a database table.  
  
-   "Adding Bookmark Support to the Consumer" shows how to add bookmark support to the consumer.  
  
-   "Adding XML Support to the Consumer" shows how to modify the consumer code to output the retrieved rowset data as XML data.  
  
> [!NOTE]
>  You can use the consumer application described in this section to test the MyProv and Provider sample providers.  
  
> [!NOTE]
>  To build a consumer application to test MyProv (the same provider described in [Enhancing the Simple Read-Only Provider](../vs140/enhancing-the-simple-read-only-provider.md)), you must include bookmark support as described in "Adding Bookmark Support to the Consumer."  
  
> [!NOTE]
>  To build a consumer application to test Provider, leave out the bookmark support described in "Adding Bookmark Support to the Consumer" and skip to "Adding XML Support to the Consumer."  
  
## Retrieving Data with the Consumer  
  
#### To modify the console application to use the OLE DB consumer  
  
1.  In MyCons.cpp, change the main code by inserting the bold text as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Adding Bookmark Support to the Consumer  
 A bookmark is a column that uniquely identifies rows in the table. Typically it is the key column, but not always; it is provider-specific. This section shows you how to add bookmark support. To do so, you need to do the following in the user record class:  
  
-   Instantiate the bookmarks. These are objects of type [CBookmark](../vs140/cbookmark-class.md).  
  
-   Request a bookmark column from the provider by setting the **DBPROP_IRowsetLocate** property.  
  
-   Add a bookmark entry to the column map by using the [BOOKMARK_ENTRY](../vs140/bookmark_entry.md) macro.  
  
 The previous steps give you bookmark support and a bookmark object with which to work. This code example demonstrates a bookmark as follows:  
  
-   Open a file for writing.  
  
-   Output rowset data to the file row by row.  
  
-   Move the rowset cursor to the bookmark by calling [MoveToBookmark](../vs140/crowset--movetobookmark.md).  
  
-   Output the bookmarked row, appending it to the end of the file.  
  
> [!NOTE]
>  If you use this consumer application to test the Provider sample provider application, leave out the bookmark support described in this section.  
  
#### To instantiate the bookmark  
  
1.  The accessor needs to contain an object of type [CBookmark](../vs140/cbookmark-class.md). The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter specifies the size of the bookmark buffer in bytes (typically 4 for 32-bit platforms and 8 for 64-bit platforms). Add the following declaration to the column data members in the user record class:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### To request a bookmark column from the provider  
  
1.  Add the following code in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method in the user record class:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
#### To add a bookmark entry to the column map  
  
1.  Add the following entry to the column map in the user record class:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
#### To use a bookmark in your main code  
  
1.  In the MyCons.cpp file from the console application you previously created, change the main code to read as follows. To use bookmarks, the main code needs to instantiate its own bookmark object (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>); this is a different bookmark from the one in the accessor (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For more information about bookmarks, see [Using Bookmarks](../vs140/using-bookmarks.md). Examples of bookmarks are also shown in [Updating Rowsets](../vs140/updating-rowsets.md).  
  
## Adding XML Support to the Consumer  
 As discussed in [Accessing XML Data](../vs140/accessing-xml-data.md), there are two ways to retrieve XML data from a data source: using [CStreamRowset](../vs140/cstreamrowset-class.md) or using [CXMLAccessor](../vs140/cxmlaccessor-class.md). This example uses <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which is more efficient, but requires you to have SQL Server 2000 running on the computer on which you execute this sample application.  
  
#### To modify the command class to inherit from CStreamRowset  
  
1.  In the consumer application you previously created, change your <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> declaration to specify <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> as the rowset class as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
#### To modify the main code to retrieve and output the XML data  
  
1.  In the MyCons.cpp file from the console application you previously created, change the main code to read as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [Creating an OLE DB Consumer Using a Wizard](../vs140/creating-an-ole-db-consumer-using-a-wizard.md)