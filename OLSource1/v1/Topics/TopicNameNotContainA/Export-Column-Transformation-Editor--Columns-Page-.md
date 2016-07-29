---
title: "Export Column Transformation Editor (Columns Page)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b659a5c2-5509-4b5b-9c82-136c971d5c7f
caps.latest.revision: 29
manager: jhubbard
---
# Export Column Transformation Editor (Columns Page)
Use the **Columns** page of the **Export Column Transformation Editor** dialog box to specify columns in the data flow to extract to files. You can specify whether the Export Column transformation appends data to a file or overwrites an existing file.  
  
 To learn more about the Export Column transformation, see [Export Column Transformation](../../Topics/TopicNameNotContainA/Export-Column-Transformation.md).  
  
## Options  
 **Extract Column**  
 Select from the list of input columns that contain text or image data. All rows should have definitions for **Extract Column** and **File Path Column**.  
  
 **File Path Column**  
 Select from the list of input columns that contain file paths and file names. All rows should have definitions for **Extract Column** and **File Path Column**.  
  
 **Allow Append**  
 Specify whether the transformation appends data to existing files. The default is **false**.  
  
 **Force Truncate**  
 Specify whether the transformation deletes the contents of existing files before writing data. The default is **false**.  
  
 **Write BOM**  
 Specify whether to write a byte-order mark (BOM) to the file. A BOM is only written if the data has the **DT_NTEXT** or DT_WSTR data type and is not appended to an existing data file.  
  
## See Also  
 [Integration Services Error and Message Reference](../../Topics/TopicNameNotContainA/Integration-Services-Error-and-Message-Reference.md)   
 [Export Column Transformation Editor (Error Output Page)](../../Topics/TopicNameNotContainA/Export-Column-Transformation-Editor--Error-Output-Page-.md)