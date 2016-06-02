---
title: Move an Analysis Services Database
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fa644e5d-e276-445e-98d9-673afcfb83fe
---
# Move an Analysis Services Database
  There are often situations when an [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] database administrator \(dba\) wants to move a multidimensional or tabular model database to a different location. These situations are often driven by business needs, such as moving the database to a different disk for better performance, gaining room for database growth, or to upgrade a product.  
  
 A database can be moved in many ways. This document explains the following common scenarios:  
  
-   Interactively using SSMS  
  
-   Programmatically using AMO  
  
-   By script using XMLA  
  
 All scenarios require the user to access the database folder and to use a method for moving the files to the desired final destination.  
  
> [!NOTE]  
>  Detaching a database without assigning a password to it leaves the database in an unsecured state. We recommend assigning a password to the database to protect confidential information. Also, the corresponding access security should be applied to the database folder, sub\-folders, and files to prevent unauthorized access to them.  
  
## Procedures  
  
#### Moving a database interactively using SSMS  
  
1.  Locate the database to be moved in the left or right pane of SSMS.  
  
2.  Right\-click on the database and select **Detach…**  
  
3.  Assign a password to the database to be detached, then click **OK** to execute the detach command.  
  
4.  Use any operating system mechanism or your standard method for moving files to move the database folder to the new location.  
  
5.  Locate the **Databases** folder in the left or right pane of SSMS.  
  
6.  Right\-click on the **Databases** folder and select **Attach…**  
  
7.  In the **folder** text box, type the new location of the database folder. Alternatively, you can use the browse button \(**…**\) to locate the database folder.  
  
8.  Select the **ReadWrite** mode for the database.  
  
9. Type the password used in step 3 and click **OK** to execute the attach command.  
  
#### Moving a database programmatically using AMO  
  
1.  In your C\# application, adapt the following sample code and complete the indicated tasks.  
  
 `private void MoveDb(Server server, string dbName,`  
  
 `string dbInitialLocation, string dbFinalLocation,`  
  
 `string dbPassword, ReadWriteMode dbReadWriteMode)`  
  
 `{`  
  
 `//Verify dbInitialLocation exists before continuing`  
  
 `if (server.Databases.ContainsName(dbName))`  
  
 `{`  
  
 `Database db;`  
  
 `//Save current cursor and change cursor to Cursors.WaitCursor`  
  
 `db = server.Databases[dbName];`  
  
 `db.Detach(dbPassword);`  
  
 `//Add your own code to copy the database files to the destination where you intend to attach the database`  
  
 `//Verify dbFinalLocation exists before continuing`  
  
 `server.Attach(dbFinalLocation, dbReadWriteMode, dbPassword);`  
  
 `//Restore cursor to its original`  
  
 `}`  
  
 `}`  
  
1.  In your C\# application, invoke `MoveDb()` with the necessary parameters.  
  
2.  Compile and execute your code to move the database.  
  
#### Moving a database by script using XMLA  
  
1.  Open a new XMLA tab in SSMS.  
  
2.  Copy the following script template for XMLA  
  
 `<Detach xmlns="http://schemas.microsoft.com/analysisservices/2003/engine">`  
  
 `<Object>`  
  
 `<DatabaseID>%dbName%</DatabaseID>`  
  
 `<Password>%password%</Password>`  
  
 `</Object>`  
  
 `</Detach>`  
  
1.  Replace `%dbName%` with the name of the database and `%password%` with the password. The % characters are part of the template and must be removed.  
  
2.  Execute the XMLA command.  
  
3.  Use any operating system mechanism or your standard method for moving files to move the database folder to the new location.  
  
4.  Copy the following script template for XMLA in a new XMLA tab  
  
 `<Attach xmlns="http://schemas.microsoft.com/analysisservices/2003/engine">`  
  
 `<Folder>%dbFolder%</Folder>`  
  
 `<ReadWriteMode xmlns="http://schemas.microsoft.com/analysisservices/2008/engine/100">%ReadOnlyMode%</ReadWriteMode>`  
  
 `</Attach>`  
  
1.  Replace `%dbFolder%` with the complete UNC path of the database folder, `%ReadOnlyMode%` with the corresponding value **ReadOnly** or **ReadWrite**, and `%password%` with the password. The % characters are part of the template and must be removed.  
  
2.  Execute the XMLA command.  
  
## See Also  
 [Attach](assetId:///M:Microsoft.AnalysisServices.Server.Attach(System.String))   
 [Detach](assetId:///M:Microsoft.AnalysisServices.Database.Detach)   
 [Attach and Detach Analysis Services Databases](../../Topics\TopicNameNotContainA/Attach-and-Detach-Analysis-Services-Databases.md)   
 [Database Storage Location](../../Topics\TopicNameNotContainA/Database-Storage-Location.md)   
 [Database ReadWriteModes](../../Topics\TopicNameNotContainA/Database-ReadWriteModes.md)   
 [Attach Element](../Topic/Attach%20Element.md)   
 [Detach Element](../Topic/Detach%20Element.md)   
 [ReadWriteMode Element](../Topic/ReadWriteMode%20Element.md)   
 [DbStorageLocation Element](../Topic/DbStorageLocation%20Element.md)  
  
  