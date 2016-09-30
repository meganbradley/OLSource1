---
title: "Updating Rowsets"
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
  - "rowsets, updating data"
  - "updating data, rowsets"
  - "updating rowsets"
  - "rowsets"
ms.assetid: 39588758-5c72-4254-a10d-cc2b1f473357
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Updating Rowsets
A very basic database operation is to update, or write data to, the data store. In OLE DB, the update mechanism is simple: your consumer application sets the values of bound data members and then writes those values to the rowset; the consumer then requests that the provider update the data store.  
  
 Consumers can perform the following kinds of updates on rowset data: setting column values within a row, inserting a row, and deleting a row. To perform these operations, the OLE DB Template class [CRowset](../vs140/crowset-class.md) implements the [IRowsetChange](https://msdn.microsoft.com/en-us/library/ms715790.aspx) interface and overrides the following interface methods:  
  
-   [SetData](../vs140/crowset--setdata.md) changes column values in a row of a rowset; it is equivalent to the SQL UPDATE command.  
  
-   [Insert](../vs140/crowset--insert.md) inserts a row into a rowset; it is equivalent to the SQL INSERT command.  
  
-   [Delete](../vs140/crowset--delete.md) deletes rows from a rowset; it is equivalent to the SQL DELETE command.  
  
## Supporting Update Operations  
 When you create a consumer with the ATL OLE DB Consumer Wizard, you can support the update operations by selecting one or more of the three check boxes **Change**, **Insert**, and **Delete**. If you select these, the wizard modifies the code appropriately to support the type of changes you choose. However, if you do not use the wizard, you need to set the following rowset properties to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to support updates:  
  
-   **DBPROPVAL_UP_CHANGE** allows you to change the data values in a row.  
  
-   **DBPROPVAL_UP_INSERT** allows you to insert a row.  
  
-   **DBPROPVAL_UP_DELETE** allows you to delete a row.  
  
 You set the properties as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Change, insert, or delete operations might fail if one or more columns is not writable. Modify your cursor map to correct this.  
  
## Setting Data in Rows  
 [CRowset::SetData](../vs140/crowset--setdata.md) sets data values in one or more columns of the current row. The following code sets the values of data members bound to the columns "Name" and "Units in Stock" of the table Products and then calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to write those values to the 100th row of the rowset:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Inserting Rows into Rowsets  
 [CRowset::Insert](../vs140/crowset--insert.md) creates and initializes a new row using data from the accessor. **Insert** creates an entirely new row after the current row; you need to specify whether to increment the current row to the next row or leave it unchanged. You do this by setting the *bGetRow* parameter:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   **false** (the default value) specifies that the current row increment to the next row (in which case it points to the inserted row).  
  
-   **true** specifies that the current row remain where it is.  
  
 The following code sets the values of data members bound to the columns of the table Products and then calls **Insert** to insert a new row with those values after the 100th row of the rowset. It is recommended that you set all column values to avoid undefined data in the new row:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For a more detailed example, see [CRowset::Insert](../vs140/crowset--insert.md).  
  
 For more information about setting the status and length data members, see [Field Status Data Members in Wizard-Generated Accessors](../vs140/field-status-data-members-in-wizard-generated-accessors.md).  
  
## Deleting Rows from Rowsets  
 [CRowset::Delete](../vs140/crowset--delete.md) deletes the current row from the rowset. The following code calls **Delete** to remove the 100th row of the rowset:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Immediate and Deferred Updates  
 Unless you specify otherwise, calls to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, **Insert**, and **Delete** methods update the data store immediately. You can, however, defer updates so that the consumer stores all changes in a local cache and then transfers them to the data store when you call one of the following update methods:  
  
-   [CRowset::Update](../vs140/crowset--update.md) transfers any pending changes made to the current row since the last fetch or **Update** call on it.  
  
-   [CRowset::UpdateAll](../vs140/crowset--updateall.md) transfers any pending changes made to all rows since the last fetch or **Update** call on it.  
  
 Note that update, as used by the update methods, has the specific meaning of making changes on command and is not to be confused with the SQL UPDATE command (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is equivalent to the SQL UPDATE command).  
  
 Deferred updates are useful, for example, in situations such as a series of banking transactions; if one transaction is canceled, you can undo the change, because you do not send the series of changes until after the last one is committed. Also, the provider can bundle the changes into one network call, which is more efficient.  
  
 To support deferred updates, you must set the **DBPROP_IRowsetChange** property in addition to the properties described in "Supporting Update Operations":  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 When you call **Update** or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the methods transfer changes from the local cache to the data store and then wipe out the local cache. Because update transfers changes only for the current row, it is important that your application keep track of which row to update and when to update it. The following example shows how to update two consecutive rows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 To ensure that pending changes are transferred, you should call **Update** before moving to another row. However, when this is tedious or inefficient, for example, when your application needs to update hundreds of rows, you can use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to update all the rows at once.  
  
 For example, if the first **Update** call were missing from the above code, row 100 would remain unchanged, while row 101 would be changed. After that point, your application would either have to call <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or move back to row 100 and call **Update** for that row to be updated.  
  
 Finally, one main reason to defer changes is to be able to undo them. Calling [CRowset::Undo](../vs140/crowset--undo.md) rolls back the state of the local change cache to the state of the data store before any pending changes were made. It is important to note that **Undo** does not roll back the state of the local cache by one step (the state before only the latest change); instead, it clears the local cache for that row. Also, **Undo** affects only the current row.  
  
## See Also  
 [Working with OLE DB Consumer Templates](../vs140/working-with-ole-db-consumer-templates.md)   
 [CRowset Class](../vs140/crowset-class.md)   
 [IRowsetChange](https://msdn.microsoft.com/en-us/library/ms715790.aspx)