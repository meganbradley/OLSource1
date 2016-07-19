---
title: Lookup Transformation Editor (Advanced Page)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f3395c65-0320-47f9-8d83-daaa082d8713
manager: jhubbard
---
# Lookup Transformation Editor (Advanced Page)
Use the **Advanced** page of the **Lookup Transformation Editor** dialog box to configure partial caching and to modify the SQL statement for the Lookup transformation.  
  
 To learn more about the Lookup transformation, see [Lookup Transformation](../../Topics/TopicNameNotContainA/Lookup-Transformation.md).  
  
## Options  
 **Cache size (32-bit)**  
 Adjust the  cache size (in megabytes) for 32-bit computers. The default value is 5 megabytes.  
  
 **Cache size (64-bit)**  
 Adjust the cache size (in megabytes) for 64-bit computers. The default value is 5 megabytes.  
  
 **Enable cache for rows with no matching entries**  
 Cache rows with no matching entries in the reference dataset.  
  
 **Allocation from cache**  
 Specify the percentage of the cache to allocate for rows with no matching entries in the reference dataset.  
  
 **Modify the SQL statement**  
 Modify the SQL statement that is used to generate the reference dataset.  
  
> [!NOTE]  
>  The optional SQL statement that you specify on this page overrides and replaces the table name that you specified on the **Connection** page of the **Lookup Transformation Editor**. For more information, see [Lookup Transformation Editor (Connection Page)](../../Topics/TopicNameNotContainA/Lookup-Transformation-Editor--Connection-Page-.md).  
  
 **Set Parameters**  
 Map input columns to parameters by using the **Set Query Parameters** dialog box.  
  
## External Resources  
 Blog entry, [Lookup cache modes](http://go.microsoft.com/fwlink/?LinkId=219518) on blogs.msdn.com  
  
## See Also  
 [Lookup Transformation Editor (General Page)](../../Topics/TopicNameNotContainA/Lookup-Transformation-Editor--General-Page-.md)   
 [Lookup Transformation Editor (Connection Page)](../../Topics/TopicNameNotContainA/Lookup-Transformation-Editor--Connection-Page-.md)   
 [Lookup Transformation Editor (Columns Page)](../../Topics/TopicNameNotContainA/Lookup-Transformation-Editor--Columns-Page-.md)   
 [Lookup Transformation Editor (Error Output Page)](../../Topics/TopicNameNotContainA/Lookup-Transformation-Editor--Error-Output-Page-.md)   
 [Integration Services Error and Message Reference](../../Topics/TopicNameNotContainA/Integration-Services-Error-and-Message-Reference.md)   
 [Fuzzy Lookup Transformation](../../Topics/TopicNameNotContainA/Fuzzy-Lookup-Transformation.md)